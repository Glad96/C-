//Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("введите число "); string[] numbers = Console.ReadLine().Split(' ');
            if (numbers[0] == "q")
                return;
            int x = Convert.ToInt32(numbers[0]);
            int y = Convert.ToInt32(numbers[1]);
            if ((x + y) % 2 == 0)
                return;
        }
    }
}