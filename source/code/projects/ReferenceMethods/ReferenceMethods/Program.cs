using System;

class Program
{
    static void Main(string[] args)
    {
        // Example for RevAdd
        int x = 4, y = 3;
        Console.WriteLine($"x is {x}, y is {y}.");
        RevAdd(ref x, ref y);
        Console.WriteLine($"x is {x}, y is {y}.");
        // Solution for RevAdd
        void RevAdd(ref int xP, ref int yP)
        {
            int temp = xP;
            xP = xP + yP;
            yP = temp - yP;
        }
        // Example for AddLog
        
        string log;
        int x2 = 4, y2 = 3;
        int result = AddLog(x2, y2, out log);
        Console.WriteLine(log + "\n" + result);
        
        
        
        int AddLog(int xP2, int yP2, out string logP)
        {
            logP = xP2 + " + " + yP2 + " = " + (xP2 + yP2) + ".";
            return xP2 + yP2;
        }

        
        int a = 2, b = 3, c;
        AddReset(ref a, ref b, out c);
        Console.WriteLine($"a = {a}, b = {b}, c = {c}.");
        
        
        void AddReset(ref int xP3, ref int xP4, out int zP4)
        {
            zP4 = xP3 + xP4;
            xP3 = 0;
            xP4 = 0;
        }
        
        
    }
    
    
}
