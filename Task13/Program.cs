// Task 13
Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = 0;     
if (n < 100)
    {
        Console.Write("Третьей цифры нет");
        n = Convert.ToInt32(Console.ReadLine());
    }
if (n > 1000) 
    a = n / 10;    
Console.WriteLine($"Третья цифра: {a % 10}");
