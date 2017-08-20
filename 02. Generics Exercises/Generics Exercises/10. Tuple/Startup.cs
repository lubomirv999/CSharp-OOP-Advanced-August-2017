using System;

public class Startup
{
    static void Main()
    {
        var personTokens = Console.ReadLine().Split();

        var person = new Tuple<string, string, string>
        {
            Item1 = personTokens[0] + " " + personTokens[1],
            Item2 = personTokens[2],
            Item3 = personTokens[3]
        };

        Console.WriteLine(person.ToString());

        var beerTokens = Console.ReadLine().Split();

        var drunk = beerTokens[2] == "drunk";

        var beer = new Tuple<string, int, bool>
        {
            Item1 = beerTokens[0],
            Item2 = int.Parse(beerTokens[1]),
            Item3 = drunk
        };

        Console.WriteLine(beer.ToString());

        var bankTokens = Console.ReadLine().Split();

        var bank = new Tuple<string, double, string>
        {
            Item1 = bankTokens[0],
            Item2 = double.Parse(bankTokens[1]),
            Item3 = bankTokens[2]
        };

        Console.WriteLine(bank.ToString());
    }
}

    //Task 11 Tuple
    //var personTokens = Console.ReadLine().Split();

//var person = new Tuple<string, string>
//{
//    Item1 = personTokens[0] + " " + personTokens[1],
//    Item2 = personTokens[2]
//};

//Console.WriteLine(person.ToString());

//var beerTokens = Console.ReadLine().Split();

//var beer = new Tuple<string, int>
//{
//    Item1 = beerTokens[0],
//    Item2 = int.Parse(beerTokens[1])
//};

//Console.WriteLine(beer.ToString());

//var numbersTokens = Console.ReadLine().Split();

//var numbers = new Tuple<int, double>
//{
//    Item1 = int.Parse(numbersTokens[0]),
//    Item2 = double.Parse(numbersTokens[1])
//};

//Console.WriteLine(numbers.ToString());
