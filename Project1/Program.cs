import vk_api
from vk_api.longpoll import VkLongPoll, VkEventType
import requests
from vk_api.upload import VkUpload
TOKEN = 'ваш_токен_доступа'
vk_session = vk_api.VkApi(token=TOKEN)
vk = vk_session.get_api()
longpoll = VkLongPoll(vk_session)
upload = VkUpload(vk_session)

def send_message(user_id, message):
    vk.messages.send(user_id=user_id, message=message, random_id=0)

def send_image(user_id, image_url):
    image = requests.get(image_url, stream=True)
    if image.status_code == 200:
        photo = upload.photo_messages(photos=image.raw)[0]
        attachment = f"photo{photo['owner_id']}_{photo['id']}"
        vk.messages.send(user_id=user_id, attachment=attachment, random_id=0)

for event in longpoll.listen():
    if event.type == VkEventType.MESSAGE_NEW and event.to_me:
        user_id = event.user_id
        text = event.text.lower()
        if not text and event.attachments:
            attachment = event.attachments[0]['photo']['sizes'][-1]['url']
            send_image(user_id, attachment)
        elif text == 'привет':
            send_message(user_id, 'Привет! Чем могу помочь?')
        else:
            pass