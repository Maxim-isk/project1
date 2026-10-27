using System;

class Program
{
    static bool Check(int m, int n)
    {
        return m > 0 || n > 0;
    }

    static void Main()
    {
        Console.Write("Введите m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(Check(m, n));
    }
}