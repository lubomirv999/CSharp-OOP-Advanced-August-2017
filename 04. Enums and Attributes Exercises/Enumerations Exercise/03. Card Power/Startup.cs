using System;

public class Startup
{
    static void Main()
    {
        var input = Console.ReadLine();
        Type type = null;

        switch (input)
        {
            case "Rank":
                type = typeof(CardRank);
                break;
            case "Suit":
                type = typeof(CardSuit);
                break;
        }

        var attributes = type.GetCustomAttributes(false);
        foreach (TypeAttribute attribute in attributes)
        {
            Console.WriteLine("Type = {0}, Description = {1}", attribute.Type, attribute.Description);
        }

        //Task 5
        //var rank1 = Console.ReadLine();
        //var suit1 = Console.ReadLine();
        //var rank2 = Console.ReadLine();
        //var suit2 = Console.ReadLine();

        //var card1 = new Card(rank1, suit1);
        //var card2 = new Card(rank2, suit2);

        //if (card2.CompareTo(card1) <= 0)
        //{
        //    Console.WriteLine(card1.ToString());
        //}
        //else
        //{
        //    Console.WriteLine(card2.ToString());
        //}
    }
}