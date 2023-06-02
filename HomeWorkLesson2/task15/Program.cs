Console.Clear();
Console.Write("введите цифру: ");
int n = int.Parse(Console.ReadLine()!);
if ( n == 6 || n == 7)
    Console.Writeline(n, "yes");
else if ( n < 6 )
    Console.Writeline(n, "no");


