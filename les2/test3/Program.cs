// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.
class Program
{
    static void Main()
    {
        float[] array = {10.4f,1.4f,2.1f,33.1f,4.1f,5.1f,61.5f,71.5f,80.1f};
        float max = array.Max();
        float min = array.Min();
    Console.WriteLine(max - min);
    }
}      
