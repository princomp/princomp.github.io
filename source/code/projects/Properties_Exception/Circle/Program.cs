using System;

class Program
{
    static void Main(string[] args)
    {
        Circle circle1 = new Circle(1); 
        try
        {
            circle1 = new Circle(-10);
            Console.WriteLine("circle1: " + circle1);
        }
        catch (ArgumentOutOfRangeException)
        {
            WriteLine($"Error: value was out of range.");
        }
        try
        {
            circle1.Diameter = -10;
            Console.WriteLine("circle1: " + circle1);
        }
        catch (ArgumentOutOfRangeException)
        {
            WriteLine($"Error: value was out of range.");
        }
    }
}
