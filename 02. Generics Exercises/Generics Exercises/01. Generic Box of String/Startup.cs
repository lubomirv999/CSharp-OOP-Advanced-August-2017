using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    static void Main()
    {
        var numOfStrings = int.Parse(Console.ReadLine());
        List<Box<string>> listOfBoxes = new List<Box<string>>();

        for (int i = 0; i < numOfStrings; i++)
        {
            Box<string> box = new Box<string>(Console.ReadLine());
            listOfBoxes.Add(box);
        }

        var element = Console.ReadLine();
        var result = GetGreaterElementCount(listOfBoxes, element);

        Console.WriteLine(result);

        //Task with double just replace everywhere string with double

        //var indexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        //SwapElements<string>(listOfBoxes, indexes[0], indexes[1]);

        //foreach (var box in listOfBoxes)
        //{
        //    Console.WriteLine(box.ToString());
        //}
    }

    public static int GetGreaterElementCount<T>(List<Box<T>> listOfBoxes, T element)
        where T : IComparable<T>
    {
        return listOfBoxes.Count(b => b.Value.CompareTo(element) > 0);
    }

    //Task Swap
    //private static void SwapElements<T>(List<Box<T>> listOfBoxes, int index1, int index2)
    //{
    //    Box<T> tempBox = listOfBoxes[index1];
    //    listOfBoxes[index1] = listOfBoxes[index2];
    //    listOfBoxes[index2] = tempBox;
    //}
}