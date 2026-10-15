Console.WriteLine("Wybierz kierunek podróży: ");
string kierunek = Console.ReadLine();

switch (kierunek)
{
    case "północ":
        Console.WriteLine("Wyruszasz w stronę gór");
        break;
    case "południe":
        Console.WriteLine("Wyruszasz w stronę pustyni");
        break;
    case "wschód":
        Console.WriteLine("Wyruszas w stronę lasu");
        break;
    case "zachód":
        Console.WriteLine("Wyruszasz w strone morza");
        break;
    default:
        Console.WriteLine("Nieznany kierunek");
        break;
}

