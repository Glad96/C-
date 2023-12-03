// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
using System;

class Program
{
    static void Main()
    {
        int[,] array = {
            { 11, 21, 31 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);
        int minSum = int.MaxValue;
        int minSumRow = 0;
        for (int row = 0; row < rows; row++)
        {
            int sum = 0;
            for (int column = 0; column < columns; column++)
            {
                sum += array[row, column];
            }
            if (sum < minSum)
            {
                minSum = sum;
                minSumRow = row;
            }
        }
        Console.WriteLine("Строка с наименьшей суммой элементов: " + minSumRow);
    }
}