
using System;

class Program
{
    static double Calculate(int n)
    {
        return Math.Sqrt(n) + n;
    }

    static void Main()
    {
        double x = Calculate(6) / 2.0
                 + Calculate(13) / 5.0
                 + Calculate(21) / 3.0;

        Console.WriteLine($"x = {x:F3}");
    }
}
