using System;

public class CommandInterpreter
{
    private readonly CustomList<string> myCustomList = new CustomList<string>();
    private readonly Sorter<string> sorter = new Sorter<string>();

    public void ProcessCommand(string line)
    {
        var tokens = line.Split();

        switch (tokens[0])
        {
            case "Add":
                myCustomList.Add(tokens[1]);
                break;
            case "Remove":
                myCustomList.Remove(int.Parse(tokens[1]));
                break;
            case "Contains":
                Console.WriteLine(myCustomList.Contains(tokens[1]));
                break;
            case "Swap":
                myCustomList.Swap(int.Parse(tokens[1]), int.Parse(tokens[2]));
                break;
            case "Greater":
                Console.WriteLine(myCustomList.CountGreaterThan(tokens[1]));
                break;
            case "Max":
                Console.WriteLine(myCustomList.Max());
                break;
            case "Min":
                Console.WriteLine(myCustomList.Min());
                break;
            case "Print":
                foreach (var element in myCustomList.Data)
                {
                    Console.WriteLine(element.ToString());
                }
                break;
            case "Sort":
                myCustomList.Data = Sorter<string>.Sort(myCustomList.Data);
                break;
            default:
                break;
        }
    }
}