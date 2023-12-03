// Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)
using System;
class Program
{
    static void Main()
    {
        int[] array = {2, 5, 6, 7, 9};
        int start = 0;
        int end = array.Length - 1;

        while (start < end)
        {
            // Обмен значениями
            int temp = array[start];
            array[start] = array[end];
            array[end] = temp;

            start++;
            end--;
        }
        foreach (int x in array)
        {
            Console.Write(x + ", ");
        }
    }
}