using System;

public class Program
{
  public static void Main()
  {
    // Computer test0 = new Computer();

    Computer test1 = new Computer("Framework");
    Console.WriteLine(test1);

    Computer test2 = new Laptop(.6, 12, "ThinkPenguin");
    Console.WriteLine(test2);
    
    // Laptop test3 = new Computer("Dell");
    
    Laptop test4 = new Laptop(.6, 12, "ThinkPenguin");
    
    // Computer test5 = new Computer(.6, 12, "ThinkPenguin");
    
  }
}
