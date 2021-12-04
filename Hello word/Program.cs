using System;
namespace ProgramString
{
    class Program 
    {
        static void Main(string[] args)
        {
            TworzenieObiektuTypuString tos = new TworzenieObiektuTypuString();
            tos.TworzenieObiektuTypuStringi();
            
        }
    }
class TworzenieObiektuTypuString
 {
    public void TworzenieObiektuTypuStringi()
    {
        // bezpośrednie przypisanie łańcucha tekstowego
        string brand, model;
        brand = "Audi";
        model = "RS6";
        // konkatenacja
        string fullName = brand + " " + model;
        Console.WriteLine("Pełna nazwa: {0}", fullName);
        // użycie konstruktora klasy String
        char[] litery = { 'W', 'i', 't', 'a', 'j' };
        string powitanie = new string(litery);
        Console.WriteLine("Powitanie: {0}", powitanie);
        // metoda zwracająca string
        string[] tablicaString = { "Witaj", "Drogi", "Użytkowniku" };
        string wiadomosc = string.Join(" ", tablicaString);
        Console.WriteLine("Wiadomość: {0}", wiadomosc);
        // metoda do konwersji na łańcuch tekstowy
        DateTime czas = DateTime.Now;
        string czasString = String.Format("Wiadomość wysłana o {0:t} w {0:D}", czas);
        Console.WriteLine("Wiadomość: {0}", czasString);
        Console.ReadLine();
        // Wynik działania programu
        //Pelna nazwa: Audi RS6
        //Powitanie: Witaj
        //Wiadomosc: Witaj Drogi Uzytkowniku
        //Wiadomosc: Wiadomosc wyslana o 17:00 w Tuesday, November 17, 2015
    }
 }
}

