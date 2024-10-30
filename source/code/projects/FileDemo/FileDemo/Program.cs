using System;
using System.IO;

/*
 * Code inspired from
 * https://learn.microsoft.com/en-us/troubleshoot/developer/visualstudio/csharp/language-compilers/read-write-text-file
 */
class Program
{
  static void Main()
  {
    // Display directory path where files will be stored.
    string directoryPath = AppDomain
      .CurrentDomain
      .BaseDirectory;
    Console.WriteLine(
      "Directory path is " + directoryPath + "."
    );
    // On a unix system:
    // ~/source/code/projects/FileDemo/FileDemo/bin/Debug/

    // We append to the base folder the selected file name:
    string filePath = Path.Combine(
      directoryPath,
      "Hello.txt"
    );
    Console.WriteLine("File path is " + filePath + ".");
    // On a unix system:
    // ~/source/code/projects/FileDemo/FileDemo/bin/Debug/Hello.txt

    try
    {
      // We create the StreamWriter object,
      // Write "Hellow World!", a new line,
      // "From the StreamWriter class", the numbers
      // from 0 to 10 in it before closing it.
      StreamWriter sw = new StreamWriter(filePath);
      sw.WriteLine("Hello World!!");
      sw.Write("From the StreamWriter class");
      for (int x = 0; x < 10; x++)
      {
        sw.Write(x);
      }
      sw.Close();
      // Go see FileDemo/bin/Debug/Hello.txt for yourself!
    }
    catch (Exception e)
    {
      Console.WriteLine("Exception: " + e.Message);
    }
    finally
    {
      Console.WriteLine(
        "Executing finally block: was the write operation successful?"
      );
    }

    try
    {
      // We first make sure the file exists.
      if (!File.Exists(filePath))
      {
        Console.WriteLine("File does not exist.");
      }
      // If the file exists, we proceed.
      else
      {
        // We create the StreamReader object,
        // read the first line of text, and then
        // loop as long as the line read is not null.
        // We display the line one after the other,
        // and close the file when we are done.
        string line;
        StreamReader sr = new StreamReader(filePath);
        line = sr.ReadLine();
        while (line != null)
        {
          Console.WriteLine(line);
          line = sr.ReadLine();
        }
        sr.Close();
        // We could also call the Dispose() method.
      }
    }
    catch (Exception e)
    {
      Console.WriteLine("Exception: " + e.Message);
    }
    finally
    {
      Console.WriteLine(
        "Executing finally block: was the read operation successful?"
      );
    }
  }
}
