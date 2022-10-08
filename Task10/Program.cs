// Задача 10
Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
while (n >=100 )
    n /= 10;
int m = n % 10;
Console.WriteLine(m);