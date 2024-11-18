using System;

class Program
{
    static void Main(){
        Rectangle test = new Rectangle(5, 3, "blue", false);
        Console.Write(test);
        test.Talk();
        test.FlipRight();
        Console.Write(test);
        test.Talk();

    }
}
