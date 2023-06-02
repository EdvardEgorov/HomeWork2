Console.Clear();
int number = new Random().Next(10, 1000);
Console.WriteLine(number);
if (number >= 100 && number < 1000)
{
int n3 = (number % 100 - number % 10) / 10;
Console.WriteLine(n3);
}
else if ( number >= 10 && number < 100)
    Console.WriteLine("третьей цифры нет");
else
    Console.WriteLine("третьей цифры нет");
    

    



    



