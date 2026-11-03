
using System;

class Program
{

    static bool IsInside(double x, double y)
    {
        if (x >= 2 || (y >= 0.5 && y <= 1.5))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void Main()
    {
        Console.Write("Введите x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        if (IsInside(x, y))
        {
            Console.WriteLine("Точка принадлежит области");
        }
        else
        {
            Console.WriteLine("Точка не принадлежит области");
        }

        Console.ReadKey();
    }
}
