using System;

public class Startup
{
    static void Main()
    {
        var driversName = Console.ReadLine();
        var result = new Ferrari(driversName);

        Console.WriteLine(result.ToString());

        string ferrariName = typeof(Ferrari).Name;
        string iCarInterfaceName = typeof(ICar).Name;

        bool isCreated = typeof(ICar).IsInterface;
        if (!isCreated)
        {
            throw new Exception("No interface ICar was created");
        }
    }
}