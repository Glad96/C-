// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
using System;

class Program
{
    static void Main()
    {
        int[,] array = 
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        Console.Write("Введите номер строки: ");
        int row = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите номер столбца: ");
        int column = Convert.ToInt32(Console.ReadLine());
        int value = 0;
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);
        if (row >= 0 && row < rows && column >= 0 && column < columns)
        {
            Console.WriteLine (array[row, column]);
        }
        else
        {
            Console.WriteLine("Такого элемента нет.");
        }
    }
}