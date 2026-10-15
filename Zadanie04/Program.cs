Console.WriteLine("Punkty życia: ");
int punkty = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Czy masz klucz?");
bool maKlucze = bool.Parse(Console.ReadLine());
Console.WriteLine("Czy masz hasło?");
bool maHaslo = bool.Parse(Console.ReadLine());

if (punkty <= 0)
{
    Console.WriteLine("Bohater nie może wejść - nie żyje");
}
else if (maKlucze || maHaslo)
{
    Console.WriteLine("Bohater może wejść");
}
else
{
    Console.WriteLine("Bohater nie może wejść do lochu");
}

     
 