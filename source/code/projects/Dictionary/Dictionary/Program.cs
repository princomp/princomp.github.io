using System;
using System.Collections.Generic;

class Program
{
  /*
   * Demonstrating how to use
   * enum type, cf.
   * https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum
   */
  public enum Level
  {
    Low,
    Medium,
    High,
  }

  static void Main(string[] args)
  {
    // Demonstrating enum type.
    Level lvl1 = Level.Medium; // To access the value, we prefix with Level.
    Level lvl2 = (Level)0; // We can cast an int into a Level.
    Console.WriteLine(lvl1 + " " + lvl2);
    // Will display "Medium Low"

    // Demonstrating PrimeHelper class:
    for (int i = 0; i < 10; i++)
    {
      Console.WriteLine(
        "The smallest prime greater than or equal to "
          + i
          + " is "
          + PrimeHelper.NextPrime(i)
          + "."
      );
    }

    // Demonstrating GetHashCode:
    Console.WriteLine(
      "The hash code of an empty array of 12 int is: "
        + (new int[12]).GetHashCode()
        + "."
    );
    Console.WriteLine(
      "The hash code of an empty array of 14 string is: "
        + (new string[14]).GetHashCode()
        + "."
    );
    Console.WriteLine(
      "The hash code of \"test string\" is: "
        + "test string".GetHashCode()
        + "."
    );
    Console.WriteLine(
      "The hash code of 12 is: " + 12.GetHashCode() + "."
    );

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
