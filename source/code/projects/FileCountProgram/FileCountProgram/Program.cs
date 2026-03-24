using System;
using System.IO;

class Program
{
  static void Main()
  {
    string filePath = Path.Combine(
      new DirectoryInfo(
        Directory.GetCurrentDirectory()
      ).ToString(),
      "Program.cs"
    );

    /*
     * On older versions, you may need to use the following instead,
     * as the program is executed in /bin/Debug, we need to go
     * two folders up, where Program.cs is located: note the ".Parent"
     * bits in the code that follows.
     */

    /*
    
    string filePath = Path.Combine(
      new DirectoryInfo(
        Directory.GetCurrentDirectory()
      ).Parent.Parent.ToString(),
      "Program.cs"
    );
    
    */

    if (!File.Exists(filePath))
    {
      Console.WriteLine(
        "There seems to be an issue. Impossible to locate Program.cs"
      );
    }
    else
    {
      Console.WriteLine("Program.cs located, processing.");
      string line;
      string[] words;
      int wCount = 0;
      try
      {
        StreamReader sr = new StreamReader(filePath);
        line = sr.ReadLine();
        while (line != null)
        {
          words = line.Split(
            new string[] { " " },
            StringSplitOptions.RemoveEmptyEntries
          );
          wCount += words.Length;
          line = sr.ReadLine();
        }
        sr.Close();
        Console.WriteLine(
          "Your program contains " + wCount + " words!"
        );
        // Should display "Your program contains 121 words!"
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception: " + e.Message);
      }
    }
  }
}
