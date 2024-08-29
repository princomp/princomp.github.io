using System;

class Program
{
    static void Main(string[] args)
    {
        Circle circle1 = new Circle(1);
        Console.WriteLine(circle1);

        try
        {
            circle1 = new Circle(-10);
            Console.WriteLine("circle1: " + circle1);
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine($"Error: value was out of range.");
        }
        Console.WriteLine(circle1);

        bool circle_modified = false;
        do
        {
            try
            {
                Console.WriteLine("Enter the circle new diameter.");
                int uInput = int.Parse(Console.ReadLine());
                circle1.Diameter = uInput;
                Console.WriteLine(circle1);
                circle_modified = true;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine($"Error: value was out of range.");
            }
            catch
            {
                Console.WriteLine("Something went wrong.");
                throw;
            }
        } while (!circle_modified);
    }
}
