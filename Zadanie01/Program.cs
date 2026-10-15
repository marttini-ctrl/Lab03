using System.ComponentModel.Design;

Console.WriteLine("Podaj liczbę: ");
int liczba = int.Parse(Console.ReadLine());
if (liczba % 2 == 0) 
{
    Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Liczba jest parzysta");
}
else 
{
    Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Liczba nie jest nieparzysta");
}