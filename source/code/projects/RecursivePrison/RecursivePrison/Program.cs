using System;

class Program
{
  static void Main()
  { 
    Demo.Jail();
  }
}

public static class Demo{
  // Beginning of solution.
  public static void Jail(){
    Console.WriteLine("Enter a string.");
    string uInput = Console.ReadLine();
    if(uInput != "Let me out!") Jail();
  }
  // End of solution.
}
