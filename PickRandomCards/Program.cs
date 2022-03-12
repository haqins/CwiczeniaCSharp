namespace PickRandomCards
{
    
}
class Program 
{
static void Main(string[] args)
{
    Console.Write("Wybierz ilość kart do wylosowania:");
    string line = Console.ReadLine();
    if (int.TryParse(line, out int  numberOfCards))
    {
        foreach( string card in 
        CardPicker.PickSomeCards(numberOfCards))
        {
            Console.Write("\n");
            Console.Write(card);
        }
    }
    else
    {
        Console.Write("Podaj jakąś liczbe od 1 do 14 :)");
    }
}

}

