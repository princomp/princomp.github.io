using System;
using System.IO;

class Program
{
  static void Main()
  {
    // We first create a file and
    // populate it with 100 random numbers
    // between 0 and 999.
    string filePath = Path.Combine(
      AppDomain.CurrentDomain.BaseDirectory,
      "RandomNumbers.txt"
    );
    Random gen = new Random();
    try
    {
      StreamWriter sw = new StreamWriter(filePath);
      for (int i = 1; i <= 100; i++)
        sw.WriteLine(gen.Next(1000));
      sw.Close();
    }
    catch (Exception e)
    {
      Console.WriteLine("Exception: " + e.Message);
    }

    // We now search for the highest number stored in this file.
    string line;
    int number;
    int maxSoFar;
    try
    {
      StreamReader sr = new StreamReader(filePath);
      line = sr.ReadLine();
      if (int.TryParse(line, out number))
      {
        maxSoFar = number;
      }
      else
      {
        throw new ArgumentException(
          "File contains string that is not a number."
        );
      }
      while (line != null)
      {
        if (int.TryParse(line, out number))
        {
          if (maxSoFar < number)
          {
            maxSoFar = number;
          }
        }
        else
        {
          throw new ArgumentException(
            "File contains string that is not a number."
          );
        }
        line = sr.ReadLine();
      }
      Console.WriteLine(
        "The maximum number in the file is "
          + maxSoFar
          + "."
      );
    }
    catch (Exception e)
    {
      Console.WriteLine("Exception: " + e.Message);
    }
    finally
    {
      Console.WriteLine("Thanks for using our program!");
    }
  }
}
