using System;

Console.Write("Введите длину ребра: ");
double a = Convert.ToDouble(Console.ReadLine());

double V = Math.Sqrt(2) * a * a * a / 3;
double S = 2 * Math.Sqrt(3) * a * a;

Console.WriteLine("Объем: " + V.ToString("F2"));
Console.WriteLine("Площадь поверхности: " + S.ToString("F2"));