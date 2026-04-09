using System;
using System.IO;

class Program
{
  static void Main()
  {
    // We first create a file and write
    // in it:
    // - A line of text,
    // - 5 random numbers between 0.0 and 9.9.
    string fPath = Path.Combine(
      AppDomain.CurrentDomain.BaseDirectory,
      "RandomNumbers.txt"
    );
    Random gen = new Random();
    try
    {
      StreamWriter sw = new StreamWriter(fPath);
      sw.WriteLine("This is 1 test.");
      for (int i = 1; i <= 5; i++)
        sw.WriteLine(gen.Next(100) / 10.0);
      sw.Close();
    }
    catch (Exception e)
    {
      Console.WriteLine("Exception: " + e.Message);
    }
    
    // Beginning of solution.
    string line;
    double number;
    double sum = 0;
    try
    {
      StreamReader sr = new StreamReader(fPath);
      line = sr.ReadLine();
      while (line != null)
      {
        // The following adds to sum only if the line
        // read contains only a double.
        if (double.TryParse(line, out number))
        {
          sum += number;
        }
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
      Console.WriteLine("Done summing the numbers in the file.");
    }
    
    try
    {
      // The "true" in the following constructor allows 
      // us to directly append at the end of the file.
      StreamWriter sw = new StreamWriter(fPath, true);
      sw.WriteLine($"Total: {sum}");
      sw.Close();
    }
    catch (Exception e)
    {
      Console.WriteLine("Exception: " + e.Message);
    }
    finally{
      Console.WriteLine("Done writing in the file.");
    }
    
    // This is simply to open the file and read it back
    // directly from the program.
    try{
      StreamReader sr = new StreamReader(fPath);
      line = sr.ReadLine();
      while(line != null){
        Console.WriteLine(line);
        line = sr.ReadLine();
      }
      sr.Close();
    }
        catch (Exception e)
    {
      Console.WriteLine("Exception: " + e.Message);
    }
    finally{
      Console.WriteLine("Done displaying the file.");
    }
      
  }
}
