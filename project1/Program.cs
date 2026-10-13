
using System;

class Program
{
    static double Calculate(double x)
    {
        return Math.Sqrt(x + 1.0 / Math.Sqrt(x * x + 4));
    }

    static void Main()
    {
        Console.Write("Введите x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        double y = Calculate(x);

        Console.WriteLine($"Результат y = {y:F3}");
    }
}
