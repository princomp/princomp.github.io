using System;
class Program
{
    static void Main()
    {
        int a = 10;
        int b = 20;
        Console.WriteLine($"Before swap: a holds {a}, b holds {b}.");   
        Swap(ref a, ref b);
        Console.WriteLine($"After swap:  a holds {a}, b holds {b}.");
    }
    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine($"Inside swap: a holds {a}, b holds {b}.");
    }
}

