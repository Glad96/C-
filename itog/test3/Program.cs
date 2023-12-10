// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 3, 5, 6, 7, 1 };

        arrayBackwards(array, array.Length - 1);
    }
    static void arrayBackwards(int[] array, int index)
    {
        if (index < 0)
        {
        return;
        }
        Console.WriteLine(array[index]);
        arrayBackwards(array, index - 1);
    }
}
