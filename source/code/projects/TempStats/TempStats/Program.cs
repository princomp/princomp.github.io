using System;

class Program
{
  static void Main()
  {
    double[] data = { 12.8, 39, 47, 91.7 };
    TempStats test = new TempStats(
      data,
      "Temperatures recorded in Augusta, GA"
    );
    test.Description += " between 2024/02 and 2024/03";
    Console.WriteLine("Description: " + test.Description);
    Console.WriteLine("Median: " + test.Median);
    Console.WriteLine("Average: " + test.Average);
    try
    {
      double[] hottest = { 1000000 };
      TempStats tooHot = new TempStats(hottest, "Too hot");
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.Message);
    }

    try
    {
      double[] coldest = { -1000000 };
      TempStats tooCold = new TempStats(
        coldest,
        "Too cold"
      );
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.Message);
    }

    try
    {
      double[] improper = { 10, -5, 100 }; // This data is not sorted.
      TempStats notSorted = new TempStats(
        improper,
        "Not Sorted"
      );
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.Message);
    }

    try
    {
      double[] empty = null;
      TempStats emptyTemperatures = new TempStats(
        empty,
        "Empty"
      );
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.Message);
    }

    try
    {
      Console.WriteLine("Mode: " + test.Mode);
    }
    catch (NotImplementedException ex)
    {
      Console.WriteLine(ex.Message);
    }
  }
}
