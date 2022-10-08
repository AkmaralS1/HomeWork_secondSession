// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
n = Math.Abs(n);
while (n < 100 || n > 999)
n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine((n % 100) / 10);