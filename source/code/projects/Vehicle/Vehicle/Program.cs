using System;

class Program
{
  static void Main()
  {
    Vehicle test1 = new Vehicle("Blue", 4);
    Console.WriteLine(test1);

    Bike test2 = new Bike();
    Console.WriteLine(test2);
    test2.Color = "Green";
    Console.WriteLine(test2);

    Bike test3 = new Bike("Green", 17.3);
    Console.WriteLine(test3);

    Bicycle test4 = new Bicycle("Yellow", 20, "Cutout");
    Console.WriteLine(test4);
  }
}
