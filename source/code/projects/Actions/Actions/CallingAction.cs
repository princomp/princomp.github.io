using System;

public static class CallingAction
{
    public static void Demo(Action actionP)
    {
        Console.WriteLine("Now calling action: ");
        actionP();
        Console.WriteLine("Done calling action.");
    }
}