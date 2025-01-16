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
        // Accessing the "explanation" attribute through
        // its property
        // 1. using the getter
        Console.WriteLine(Circle.Explanation);
        // 2. using the setter
        Circle.Explanation += " We use the value " + Circle.PI + " as an approximation of π.";
        // We make sure the "explanation" attribute was correctly edited:
        Console.Write(Circle.Explanation);

    }
}
