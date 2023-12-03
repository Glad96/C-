//Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int[] arr_int = new int[10];
        int i = 0;
        int count = 0;
        while (i < 10)
        {
            arr_int[i] = rnd.Next(100, 1000);
            i = i + 1;
        }
        foreach (int X in arr_int)
        {
            Console.WriteLine(arr_int);
            if (X % 2 == 0)
                count = count + 1;
        }
        Console.WriteLine(count);
    }
}