using System;

public class Startup
{
    static void Main()
    {
        string inputLines;

        while ((inputLines = Console.ReadLine()) != "End")
        {
            var tokens = inputLines.Split();
            var citizen = new Citizen(tokens[0], tokens[1], int.Parse(tokens[2]));

            var person = (IPerson)citizen;
            Console.WriteLine(person.GetName());

            var resident = (IResident)citizen;
            Console.WriteLine(resident.GetName());
        }
    }
}