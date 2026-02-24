using System;

public class Program
{
  public static void Main()
  {
    Computer test1 = new Computer("Framework");
    Console.WriteLine(test1);
    Laptop test2 = new Laptop(12, "ThinkPenguin");
    Console.WriteLine(test2);
  }
}
