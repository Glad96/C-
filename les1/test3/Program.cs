class Program
{
    static void Main()
    {
        Console.Write("Введите число из отрезка [10, 99]: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 9 && number < 100)
        {
            int firstDigit = number / 10;
            int secondDigit = number % 10;
            int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;Console.WriteLine(maxDigit);
        }
        else
            Console.WriteLine("Ошибка");
    }
}