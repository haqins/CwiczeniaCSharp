class CardPicker
{
   public static string [] PickSomeCards(int numberOfCards)
   {
       string[] PickedCards = 
       new string[numberOfCards];
       for (int i =0; i < numberOfCards; i++;)
       {
           PickedCards[i] = RandomValue()+
           "of" + RandomSuit();
       }
       return PickedCards;
   }
   public static RandomSuit ()
   {

   }

   public static RandomValue ()
   {

   }
}


