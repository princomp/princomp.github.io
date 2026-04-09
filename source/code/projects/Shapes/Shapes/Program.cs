using System;

class Program
{
  static void Main()
  {
    Circle test = new Circle();
    test.Radius = 6;
    Console.WriteLine(test);
    
    Rectangle test0 = new Rectangle();
    test0.Width = 12;
    test0.Length = 10;
    Console.Write(test0);
    
    Rectangle test1 = new Rectangle();
    test1.Width = 10;
    test1.Length = 12;
    Console.Write(test1);
    
    Console.WriteLine("The two rectangles are identical (up to rotation): " + test1.Equals(test0));

    Rectangle test2 = new Rectangle();
    test2.Width = 8;
    test2.Length = 12;
    Console.Write(test2);
    Console.WriteLine("The two rectangles are identical (up to rotation): " + test2.Equals(test0));
  }
}
