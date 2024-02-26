using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число x: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = 5 * x + 20;
        Console.WriteLine($"Результат: {y*2}");
    }
}