using System;
using System.IO;

class Program
{
  static void Main()
  {
    string inputFilePath = Path.Combine(
      AppDomain.CurrentDomain.BaseDirectory,
      "inputfile.txt"
    );
    string outputFilePath = Path.Combine(
      AppDomain.CurrentDomain.BaseDirectory,
      "output.txt"
    );
    // This parts generate the file used
    // in the example, it can be skipped.
    try
    {
      StreamWriter sw = new StreamWriter(inputFilePath);
      sw.WriteLine("% This is a comment\nHere is a line.\nI'm 90% done!\n");      
      sw.Close();
    }
    catch (Exception e)
    {
      Console.WriteLine("Exception: " + e.Message);
    }

    // Beginning of solution.
    string line;
    try
    {
      StreamReader sr = new StreamReader(inputFilePath);
      StreamWriter sw = new StreamWriter(outputFilePath);
      line = sr.ReadLine();
      while (line != null)
      {
        if (line != ""){
          if (line[0] != '%')
          {
            sw.WriteLine(line);
          }
        }
        line = sr.ReadLine();
      }      
      sr.Close();
      sw.Close();
    }
    catch (Exception e)
    {
      Console.WriteLine("Exception: " + e.Message);
    }
    finally
    {
      Console.WriteLine(
        "Done copying file (without comments)."
      );
    }

    // This is simply to open the file and read it back
    // directly from the program.
    Console.WriteLine("Reading file back:");
    try
    {
      StreamReader sr = new StreamReader(outputFilePath);
      line = sr.ReadLine();
      while (line != null)
      {
        Console.WriteLine(line);
        line = sr.ReadLine();
      }
      sr.Close();
    }
    catch (Exception e)
    {
      Console.WriteLine("Exception: " + e.Message);
    }
    finally
    {
      Console.WriteLine("Done displaying the file.");
    }
  }
}
