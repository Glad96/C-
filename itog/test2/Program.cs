// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
using System;
class Program
{
    static void

    Main(string[] args)
    {   
    Console.Write("введите числа ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("введите числа ");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine(Ackermann(m, n));
    }
    static int
    Ackermann(int m, int n)
    {
        if (m == 0)
        {
        return n + 1;
        }
        if (m > 0 && n == 0)
        {
        return Ackermann(m - 1, 1);
        }
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}
