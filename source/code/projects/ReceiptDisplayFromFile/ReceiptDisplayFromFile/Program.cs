using System;
/* The following is to make sure that decimals will be read
 * according to the en-US standard.
 */
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;

public class Program
{
  public static void Main(string[] args)
  {
    /* The following is to make sure that decimals will be read
    * according to the en-US standard.
    */
    CultureInfo culture = CultureInfo.CreateSpecificCulture(
      "en-US"
    );
    Thread.CurrentThread.CurrentCulture = culture;
    Thread.CurrentThread.CurrentUICulture = culture;

    // This is simply to load the example file more easily.
    string directoryPath = AppDomain
      .CurrentDomain
      .BaseDirectory;
    string filePath = Path.Combine(
      directoryPath,
      "test.txt"
    );

    // Begining of the actual answer.
    try
    {
      StreamReader sw = new StreamReader(filePath);
      string cLine = sw.ReadLine();
      decimal amount;
      while (cLine != null)
      {
        if (cLine[0] != '%')
        {
          if (decimal.TryParse(cLine, out amount))
          {
            Console.WriteLine($"{amount:C}");
          }
          else
          {
            Console.WriteLine(cLine);
          }
        }
        cLine = sw.ReadLine();
      }
    }
    catch
    {
      Console.WriteLine("An error was thrown.");
    }
    // End of the actual answer.
  }
}
