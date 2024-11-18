using System;

class Program
{
  static void Main(string[] args)
  {
    // Example for AddRev
    int x0 = 4,
      y0 = 3;
    AddRev(ref x0, ref y0);
    Console.WriteLine($"x0 is {x0}, y0 is {y0}.");
    // Solution for AddRev
    void AddRev(ref int xP0, ref int yP0)
    {
      int temp = xP0;
      xP0 = xP0 + yP0;
      yP0 = temp - yP0;
    }
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
    // Example for AddReset
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
    // Done!
  }
}
