using System;
using System.IO;

class Program
{
  static void Main()
  {
    // Begin solution
    string filePath = Path.Combine(
      AppDomain.CurrentDomain.BaseDirectory,
      "TextTruncate.txt"
    );
    Console.WriteLine("Enter a string.");
    string uString = Console.ReadLine();

    const int MAXWIDTH = 40;

    try
    {
      StreamWriter sw = new StreamWriter(filePath);
      while (uString.Length > MAXWIDTH)
      {
        sw.WriteLine(uString.Substring(0, MAXWIDTH));
        uString = uString.Substring(MAXWIDTH);
      }
      sw.WriteLine(uString);
      sw.Close();
    }
    catch (Exception e)
    {
      Console.WriteLine("Exception: " + e.Message);
    }
    // End solution
  }
}
