
using System;

class Program
{

    static bool DecodePosition(string pos, out int x, out int y)
    {
        x = 0;
        y = 0;

        if (pos.Length != 2)
            return false;

        char letter = char.ToLower(pos[0]);
        char number = pos[1];

        if (letter < 'a' || letter > 'h' || number < '1' || number > '8')
            return false;

        x = letter - 'a' + 1;
        y = number - '0';

        return true;
    }

    static bool KnightAttack(int x1, int y1, int x2, int y2)
    {
        int dx = Math.Abs(x1 - x2);
        int dy = Math.Abs(y1 - y2);

        return (dx == 2 && dy == 1) || (dx == 1 && dy == 2);
    }

    static bool RookAttack(int x1, int y1, int x2, int y2)
    {
        return x1 == x2 || y1 == y2;
    }

    static void Main()
    {
        Console.Write("Введите позицию белого коня: ");
        string white = Console.ReadLine();

        Console.Write("Введите позицию черной ладьи: ");
        string black = Console.ReadLine();

        int wx, wy, bx, by;

        if (!DecodePosition(white, out wx, out wy) ||
            !DecodePosition(black, out bx, out by))
        {
            Console.WriteLine("Неправильная позиция!");
            return;
        }

        if (wx == bx && wy == by)
        {
            Console.WriteLine("Фигуры не могут стоять на одной клетке!");
            return;
        }

        if (KnightAttack(wx, wy, bx, by) ||
            RookAttack(bx, by, wx, wy))
        {
            Console.WriteLine("Одна из фигур находится под боем!");
        }
        else
        {
            Console.WriteLine("Фигуры не находятся под боем.");
        }

        Console.ReadKey();
    }
}
