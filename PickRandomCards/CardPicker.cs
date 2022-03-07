class CardPicker
{
    static Random random = new Random();
   public static string [] PickSomeCards(int numberOfCards)
   {
       string[] PickedCards = 
       new string[numberOfCards];
       for (int i =0; i < numberOfCards; i++)
       {
           PickedCards[i] = RandomValue()
           +"of" +
            RandomSuit();
       }
       return PickedCards;
   }
  private static string RandomSuit ()
   {
       int Value = random.Next(1,5);
       if (Value == 1 ) return "Pik";
       if (Value == 2 ) return "Serce";
       if (Value == 3 ) return  "żołędź";
       return "kier";
   }

   private static string RandomValue ()
   {
       int Value = random.Next(1,14);
       if (Value == 1 ) return "As";
       if (Value == 11 ) return "Jopek";
       if (Value == 12 ) return "Dama";
       if (Value == 13 ) return "Król";
       return Value.ToString();
    
   }
}


