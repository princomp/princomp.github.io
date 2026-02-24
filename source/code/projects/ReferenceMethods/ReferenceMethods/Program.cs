using System;

class Program
{
  static void Main(string[] args)
  {
    // Example for AddR
    static void AddR(ref int a, ref int b)
    {
      int tmp = a;
      a = a + b;
      b = tmp - b;
    }

    int x = 4,
      y = 3;
    Console.WriteLine($"x is {x}, y is {y}.");
    AddR(ref x, ref y);
    Console.WriteLine($"x is {x}, y is {y}.");
    // End of AddR example

    /*
    // This Test1 method would not compile
    static void Test1(int a, out int b){
      if (a > 0) { b = 12; }
    }
    // Uncomment Test1 to see for yourself.
    */

    /*
     // This Test2 method would not compile
     static void Test2(int a, out int b){
                 if (b < 0) { b = a; }
                 else { b = 10;}
     }
      // Uncomment Test2 to see for yourself.
      */

    // Example for NameChange
    static void NameChange(
      ref string nameP,
      string newnameP,
      out string oldnameP
    )
    {
      oldnameP = nameP;
      nameP = newnameP;
    }
    // End of NameChange example

    string name = "Smith";
    // This previous string is assumed given.
    string oldname;
    Console.WriteLine("Enter new name.");
    NameChange(ref name, Console.ReadLine(), out oldname);
    Console.WriteLine(
      $"New name: {name}\nOld name: {oldname}"
    );
    // End of NameChange usage example

    // Example for AddLog
    string log;
    int x1 = 4,
      y1 = 3;
    int result = AddLog(x1, y1, out log);
    Console.WriteLine(log + "\n" + result);

    // Solution for AddLog
    int AddLog(int xP1, int yP1, out string logP)
    {
      logP = xP1 + " + " + yP1 + " = " + (xP1 + yP1) + ".";
      return xP1 + yP1;
    }

    // AddReset example
    int x2 = 2,
      y2 = 3,
      z2;
    AddReset(ref x2, ref y2, out z2);
    Console.WriteLine($"x2 = {x2}, y2 = {y2}, z2 = {z2}.");
    // Solution for AddReset
    void AddReset(ref int xP2, ref int yP2, out int zP2)
    {
      zP2 = xP2 + yP2;
      xP2 = 0;
      yP2 = 0;
    }
    // Done with AddReset
  }
}
