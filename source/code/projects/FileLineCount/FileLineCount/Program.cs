using System;
using System.IO;

class Program
{
  static void Main(string[] args)
  {
    // Creating a dummy file with a random number of lines.
    string directoryPath = AppDomain
      .CurrentDomain
      .BaseDirectory;
    string filePath = Path.Combine(
      directoryPath,
      "dummy.txt"
    );
    // Creating a generator for random numbers.
    Random gen = new Random();
    int linePopulated = gen.Next(20, 100);
    // We will store between 20 and 99 numbers in our file.
    // We first populate the file with random characters.
    try
    {
      StreamWriter sw = new StreamWriter(filePath);
      for (int i = 0; i < linePopulated; i++)
        sw.WriteLine((char)gen.Next(32, 126));
      sw.Close();
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex);
    }

    // The following count the number of lines
    // in the file we created.
    int count = 0;
    string line;
    try
    {
      StreamReader sr = new StreamReader(filePath);
      line = sr.ReadLine();
      while (line != null)
      {
        count++;
        line = sr.ReadLine();
      }
      sr.Close();
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex);
    }
    // We can do a simple check to make sure
    // we populated as many lines as we counted.
    if (count != linePopulated)
    {
      throw new Exception("Something was wrong!");
    }
    else
    {
      Console.WriteLine(
        $"The file located at {filePath} has {count} lines."
      );
    }
  }
}
