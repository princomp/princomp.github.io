using System;
using System.IO;

class Program
{
  static void Main()
  {
    string directoryPath = AppDomain
      .CurrentDomain
      .BaseDirectory;

    // Setting up test files.
    string str0 =
      @"12.48
This is a test
-2.48
2
STOP
13";
    StreamWriter sw0 = new StreamWriter(
      Path.Combine(directoryPath, "test0.txt")
    );
    sw0.WriteLine(str0);
    sw0.Close();

    string str1 =
      @"My file contains
STOP but
averages
15
    and
5";

    StreamWriter sw1 = new StreamWriter(
      Path.Combine(directoryPath, "test1.txt")
    );
    sw1.WriteLine(str1);
    sw1.Close();

    string str2 =
      @"This 12 will be 
igored
but not 
11
    nor
4";
    StreamWriter sw2 = new StreamWriter(
      Path.Combine(directoryPath, "test2.txt")
    );
    sw2.WriteLine(str2);

    sw2.Close();

    string[] testStrings = { str0, str1, str2 };

    for (int i = 0; i < 3; i++)
    {
      string filePath = Path.Combine(
        directoryPath,
        $"test{i}.txt"
      );
      Console.WriteLine(
        $"For the file test{i}.txt containing:"
      );
      Console.WriteLine("--------------");
      Console.WriteLine(testStrings[i]);
      Console.WriteLine("--------------");
      Console.WriteLine(
        "The average is: "
          + AverageFromFile(filePath)
          + ".\n\n"
      );
    }

    double AverageFromFile(string filePathP)
    {
      // Variables for the number read,
      // the sum so far, the number of numbers
      // read, and the average.
      double number;
      double sum = 0;
      int counter = 0;
      double average;
      try
      {
        // Opening file
        StreamReader sr = new StreamReader(filePathP);
        // Reading first line
        string line = sr.ReadLine();

        // Looping through the file until we
        // reach the end, or read the word
        // "STOP" on its own line.
        while (line != null && line != "STOP")
        {
          // We test if the line contains a double.
          if (double.TryParse(line, out number))
          {
            sum += number;
            counter++;
          }
          // We read the next line.
          line = sr.ReadLine();
        }
      }
      catch { }
      average = sum / counter;
      // We return the average.
      return average;
    }
  }
}
