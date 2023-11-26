// Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].
class Program
{
    static void Main()
    {
         int[] array = {10,1,2,33,4,5,61,71,8};
         int X = 0;
         foreach (int item in array)
         {
            if (item > 19 && item < 91)
                {
                X += 1;
                }
         }
         
        Console.WriteLine(X);
    }
}       