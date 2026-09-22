using System;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Сергей Есенин");

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("«Берёза»");

        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Белая берёза");

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Под моим окном");

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Принакрылась снегом,");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Точно серебром.");

        Console.ResetColor();

        Console.WriteLine();
        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}