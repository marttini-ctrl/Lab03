Console.WriteLine("Punkty życia:");
int punkty = Convert.ToInt32(Console.ReadLine());
bool żyje = punkty > 0;
bool nieŻyje = punkty <= 0;
if (żyje)
{
    Console.WriteLine("Bohater żyje");
}
else
{
    Console.WriteLine("Bohater nie żyje");
}
Console.WriteLine("Ilość złota:");
int iloscZlota = Convert.ToInt32(Console.ReadLine());
bool mozeKupic = iloscZlota >= 30;
bool nieMozeKupic = iloscZlota < 30;


Console.WriteLine("Aktualna ilość punktów zdrowia:");
int punktyZdrowia = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Obrażenia broni:");
int obrazenia = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Czy masz miksturę:");
bool maMiksture = bool.Parse(Console.ReadLine());
Console.WriteLine("1 - atak");
Console.WriteLine("2 - leczenie");
Console.WriteLine("3 - ucieczka");
Console.WriteLine("Wybierz opcję:");
int opcja = Convert.ToInt32(Console.ReadLine());
if (punktyZdrowia <= 0)
{
    Console.WriteLine("Game over");
}

switch (opcja)
{
    case 1:
        Console.WriteLine($"Obrażenia: {obrazenia}");
        break;
    case 2:
        if (maMiksture)
        {
            Console.WriteLine("Lecznie miksturą");
      


