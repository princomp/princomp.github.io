using System;
using System.Collections.Generic;

class Program
{
  static void Main(string[] args)
  {
    // Example of using the CDictionary class
    CDictionary<string, int> ht = new CDictionary<
      string,
      int
    >(13, CDictionary<string, int>.CollisionRes.Linear);
    // Key of type string, value of type int.
    ht.Add("one", 1);
    ht.Add("twenty", 20);
    ht.Add("fourteen", 14);
    ht.Add("two", 2);
    ht.Add("seventeen", 17);
    ht["fifteen"] = 15;
    Console.Write(ht);
    Console.WriteLine(ht["two"]);
    ht["two"] = 10;
    Console.WriteLine(ht["two"]);

    int x = ht.Find("two");
    Console.WriteLine($"Found x = {x}");
    try
    {
      int y = ht.Find("zzz");
      Console.WriteLine($"Found x = {y}");
    }
    catch (Exception)
    {
      Console.WriteLine($"Didn't find zzz");
    }

    ht.Remove("two");
    try
    {
      int y = ht.Find("two");
      Console.WriteLine($"Should not find two = {y}");
    }
    catch (Exception)
    {
      Console.WriteLine(
        $"Didn't find two since it was removed"
      );
    }
    try
    {
      ht.Remove("two");
      int y = ht.Find("two");
      Console.WriteLine($"Should not find two = {y}");
    }
    catch (Exception)
    {
      Console.WriteLine(
        $"Shoud throw when trying to remove two since it was removed"
      );
    }
  }
}
