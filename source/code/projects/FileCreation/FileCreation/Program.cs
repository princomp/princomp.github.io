using System;
using System.IO;

class Program
{
  static void Main()
  {
    // Variable for file name and file path.
    string fName,
      filePath;
    do
    {
      Console.WriteLine("Enter a file name.");
      fName = Console.ReadLine();
      filePath = Path.Combine(
        AppDomain.CurrentDomain.BaseDirectory,
        fName
      );
    } while (
      !fName.EndsWith(".txt")
      || fName.StartsWith(".")
      || File.Exists(filePath)
    );
    try
    {
      StreamWriter sw = new StreamWriter(filePath);
      for (int i = 1; i <= 1000000; i++)
        sw.WriteLine(i);
      sw.Close();
      Console.WriteLine("Check out " + filePath + "!");
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
