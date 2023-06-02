Console.Clear();
Console.Write("Введи трёхзначное число: ");
int n = int.Parse(Console.ReadLine()!);
if ( n >= 100 && n < 1000);
    int n2 = (n % 100 - n % 10) / 10;
Console.WriteLine(n2);






