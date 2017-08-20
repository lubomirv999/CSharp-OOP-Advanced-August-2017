using System;
using System.Linq;

public class Startup
{
    static void Main()
    {
        var inputStones = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

        Lake lake = new Lake(inputStones);
        Console.WriteLine(string.Join(", ", lake));
    }
}