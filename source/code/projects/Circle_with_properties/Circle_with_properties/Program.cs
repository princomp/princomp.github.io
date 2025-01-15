using System;

class Program
{
  static void Main()
  {
    Circle test = new Circle(12.3M);
        Console.WriteLine(test);
        Console.WriteLine(Circle.PI);
        test.Diameter = 14; // OK
        // test.Radius = 7; // Not ok!
  }
}
