// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
using System;

class Program
{
    static void Main()
    {
        Console.Write("введите числа ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("введите числа ");
        int n = Convert.ToInt32(Console.ReadLine());
        PrintNumbers(m, n);
    }
    static void PrintNumbers(int m, int n)
    {
        if (m > n)
        {
        return;
        }
        Console.WriteLine(m);
        PrintNumbers(m + 1, n);
    }
}
