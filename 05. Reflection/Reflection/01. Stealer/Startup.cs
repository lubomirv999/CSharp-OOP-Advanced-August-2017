using System;

public class Startup
{
    static void Main()
    {
        Spy spy = new Spy();
        string result = spy.CollectGettersAndSetters("Hacker");
        //Task 3
        //string result = spy.RevealPrivateMethods("Hacker");
        //Task 2
        //string result = spy.AnalyzeAcessModifiers("Hacker");
        //Task 1
        //string result = spy.StealFieldInfo("Hacker", "username", "password");
        Console.WriteLine(result);
    }
}