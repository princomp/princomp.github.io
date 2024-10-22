using System;
class Program
{
    static void Main()
    {
        int a;
        SetToRandom(out a);
        Console.WriteLine(a);
    }
    static void SetToRandom(out int a)
    {
        Random gen = new Random();
        a = gen.Next(10);
    }
}

