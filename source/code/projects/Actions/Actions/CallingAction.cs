using System;

public static class CallingAction
{
    public static void Demo(Action actionP)
    {
        Console.WriteLine("Now calling action: ");
        actionP();
        Console.WriteLine("Done calling action.");
    }

    public static void DemoT(Action<int> actionP)
    {
        Console.WriteLine("Now calling action with arguments ranging from 0 to 9:");
        for (int i = 0; i < 10; i++)
        {
            actionP(i);
        }
        Console.WriteLine("Done calling action.");
    }
}