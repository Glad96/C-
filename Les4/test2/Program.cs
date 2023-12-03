// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[,]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        if (rows > 1)
        {
            for (int i = 0; i < columns; i++)
            {
                int temp = matrix[0, i];
                matrix[0, i] = matrix[rows - 1, i];
                matrix[rows - 1, i] = temp;
            }
            Console.WriteLine("Измененный массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Массив пустой или имеет менее двух строк.");
        }

        Console.ReadLine();
    }
}