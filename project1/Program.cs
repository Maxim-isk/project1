using System;

Console.Write("Введите двузначное число: ");
int n = int.Parse(Console.ReadLine());

int tens = n / 10;
int ones = n % 10;

Console.WriteLine("Число десятков: " + tens);
Console.WriteLine("Число единиц: " + ones);
Console.WriteLine("Сумма цифр: " + (tens + ones));
Console.WriteLine("Произведение цифр: " + (tens * ones));