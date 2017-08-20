using System;
using System.Collections.Generic;

public class Startup
{
    static void Main()
    {
        var firstPeople = new SortedSet<Person>(new CustomComparer());
        var secondPeople = new HashSet<Person>(new CustomEqualityComparer());
        var peopleCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < peopleCount; i++)
        {
            var tokens = Console.ReadLine().Split();
            var person = new Person(tokens[0], int.Parse(tokens[1]));

            firstPeople.Add(person);
            secondPeople.Add(person);
        }

        Console.WriteLine(firstPeople.Count);
        Console.WriteLine(secondPeople.Count);
    }
}