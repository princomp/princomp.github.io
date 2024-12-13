using System;
using System.IO;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Enter a path");
    string path = Console.ReadLine();
    if (File.Exists(path))
    {
      Console.WriteLine(
        "Now displaying file at " + path + "."
      );
      try
      {
        StreamReader sr = new StreamReader(path);
        string cLine = sr.ReadLine();
        while (cLine != null)
        {
          Console.WriteLine(cLine);
          cLine = sr.ReadLine();
        }
        sr.Close();
        Console.WriteLine("Done displaying file.");
      }
      catch
      {
        Console.WriteLine(
          "There was an error opening your file."
        );
      }
    }
    else
    {
      Console.WriteLine(
        "Now creating a file at "
          + path
          + ".\n Enter your text, one line at a time. When done, type \"!DONE!\" (without the quotes), then enter."
      );
      try
      {
        StreamWriter sw = new StreamWriter(path);
        string uInput = Console.ReadLine();
        while (uInput != "!DONE!")
        {
          sw.WriteLine(uInput);
          uInput = Console.ReadLine();
        }
        sw.Close();
        Console.WriteLine("File correctly written.");
      }
      catch
      {
        Console.WriteLine(
          "There was an error creating your file."
        );
      }
    }
  }
}
