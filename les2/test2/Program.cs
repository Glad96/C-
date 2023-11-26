// Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.
class Program
{
    static void Main()
    {
         int[] array = {10,1,2,33,4,5,61,71,80};
         int X = 0;
         foreach (int item in array)
         {
            int remains = item % 2;
            if (remains == 0)
                {
                X += 1;
                }
         }
         
        Console.WriteLine(X);
    }
}      