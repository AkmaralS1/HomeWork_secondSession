﻿//Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
n = Math.Abs(n);
if (n < 100)
Console.WriteLine("Третьей цифры нет");
else
{
while (n > 1000)
n = n / 10;
Console.WriteLine(n % 10);
}