// Ccылка на блок схему картинкой https://ibb.co/2ZHkXz1
using System;
namespace Program
{
    class Program
    {
        static void Main()
        {
            // Ввод исходного массива
            Console.WriteLine("Введите исходный массив строк:");
            string[] inputArray = Console.ReadLine().Split(' ');
            
            // Формирование нового массива
            string[] outputArray = new string[0];
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length <= 3)
                {
                    outputArray = outputArray.Append(inputArray[i]).ToArray();
                }
            }

            // Вывод нового массива
            Console.WriteLine("Новый массив:");
            for (int i = 0; i < outputArray.Length; i++)
            {
                Console.WriteLine(outputArray[i]);
            }
        }
    }
}