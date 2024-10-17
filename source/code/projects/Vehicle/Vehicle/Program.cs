using System;

class Program
{
    static void Main()
    {

        Vehicle test1 = new Vehicle("Blue", 2M);
        Console.WriteLine(test1);

        Bike test2 = new Bike();
        Console.WriteLine(test2);
        test2.Color = "Green";
        Console.WriteLine(test2);
       
        Bike test3 = new Bike("Green", 0.20M, 17.3);
        Console.WriteLine(test3);

        Bicycle test4 = new Bicycle("Yellow", 0.05M, 20, "Cutout");
        Console.WriteLine(test4);
    }
} 
