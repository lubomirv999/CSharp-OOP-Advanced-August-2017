using System;

public class Startup
{
    static void Main()
    {
        var cardDeck = new CardDeck();
        var input = Console.ReadLine();

        if (input == "Card Deck")
        {
            foreach (var card in cardDeck)
            {
                Console.WriteLine(card.ToString());
            }
        }
    }
}