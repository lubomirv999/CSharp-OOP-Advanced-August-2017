using System;

public class Startup
{
    static void Main()
    {
        var inputLines = Console.ReadLine();
        var command = new CommandInterpreter();

        while (inputLines != "END")
        {
            command.ProcessCommand(inputLines);
            inputLines = Console.ReadLine();
        }
    }
}