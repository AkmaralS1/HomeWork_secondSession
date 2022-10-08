// Task 15

Console.Clear();
Console.Write("Введитие цифру: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 5 && n < 8)
    Console.WriteLine("Это выходной день!");
if (n >= 1 && n <= 5 )
    Console.WriteLine("Это будний день!");
else
    Console.WriteLine("Ошиблись, попробуйте сначала");
