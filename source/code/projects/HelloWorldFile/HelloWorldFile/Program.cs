using System;
using System.IO;

class Program
{
  static void Main()
  {
    // Variable used to store the user name.
    string uName;
    Console.WriteLine("Please, enter your name.");
    uName = Console.ReadLine();

    try
    {
      string filePath = Path.Combine(
        AppDomain.CurrentDomain.BaseDirectory,
        "HelloWorld.txt"
      );
      // This string contains the path for the file we create.
      StreamWriter sw = new StreamWriter(filePath);
      // We create the file
      sw.WriteLine("Hello " + uName);
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
