using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    static void Main()
    {
        var numberOfPeople = int.Parse(Console.ReadLine());
        var inputLines = Console.ReadLine();
        var buyers = new List<Buyer>();

        for (int i = 0; i < numberOfPeople; i++)
        {
            var cmdArgs = inputLines.Split();
            Buyer buyer;

            var name = cmdArgs[0];
            var age = int.Parse(cmdArgs[1]);

            if (cmdArgs.Length == 4)
            {
                buyer = new Citizen(name, age, cmdArgs[2], cmdArgs[3]);
            }
            else
            {
                buyer = new Rebel(name, age, cmdArgs[2]);
            }

            buyers.Add(buyer);
            inputLines = Console.ReadLine();
        }

        while (inputLines != "End")
        {
            var buyer = buyers.FirstOrDefault(b => b.Name == inputLines);
            buyer?.BuyFood();

            inputLines = Console.ReadLine();
        }

        Console.WriteLine(buyers.Sum(b => b.Food));

        //Task 6
        //var beings = new List<IBirthable>();

        //string input;

        //while ((input = Console.ReadLine()) != "End")
        //{
        //    var cmdArgs = input.Split(' ');
        //    IBirthable being = null;

        //    switch (cmdArgs[0])
        //    {
        //        case "Citizen":
        //            being = new Citizen(cmdArgs[1], int.Parse(cmdArgs[2]), cmdArgs[3], cmdArgs[4]);
        //            break;
        //        case "Pet":
        //            being = new Pet(cmdArgs[1], cmdArgs[2]);
        //            break;
        //    }

        //    if (being != null)
        //    {
        //        beings.Add(being);
        //    }
        //}

        //var year = Console.ReadLine();

        //foreach (var b in beings.Where(b => b.Birthdate.EndsWith(year)))
        //{
        //    Console.WriteLine(b.Birthdate);
        //}
    }
}