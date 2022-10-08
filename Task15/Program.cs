// Task 15

Console.Clear();
Console.Write("Введитие цифру: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 7)
    n = Convert.ToInt32(Console.ReadLine());

if (n > 5)
    Console.WriteLine("Выходной");
else
    Console.WriteLine("Будни");
