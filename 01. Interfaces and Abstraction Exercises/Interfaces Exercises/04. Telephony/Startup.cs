using System;

public class Startup
{
    public static void Main()
    {
        var phone = new Smartphone("Smartphone");
        CheckPhone(phone);
    }

    private static void CheckPhone(ISmartphone phone)
    {
        var numbers = Console.ReadLine().Split();
        var sites = Console.ReadLine().Split();

        foreach (var number in numbers)
        {
            Console.WriteLine(phone.Call(number));
        }       

        foreach (var site in sites)
        {
            Console.WriteLine(phone.Browse(site));
        }
    }
}