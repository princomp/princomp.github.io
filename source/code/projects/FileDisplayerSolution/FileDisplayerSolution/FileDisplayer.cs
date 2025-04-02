using System;
using System.IO;

static class FileDisplayer
{
  public static void Display(string exP)
  {
    if (!File.Exists(exP))
    {
      Console.WriteLine(
        "Nothing to display: the file does not exists."
      );
    }
    else
    {
      try
      {
        StreamReader sw = new StreamReader(exP);
        string cLine = sw.ReadLine();
        while (cLine != null)
        {
          Console.WriteLine(cLine);
          cLine = sw.ReadLine();
        }
      }
      catch
      {
        Console.WriteLine(
          "An error was thrown from Display method."
        );
      }
    }
  }

  public static void DisplayN(string exP, int lineN)
  {
    if (!File.Exists(exP))
    {
      Console.WriteLine(
        "Nothing to display: the file does not exists."
      );
    }
    else if (lineN <= 0)
    {
      Console.WriteLine(
        "The line number should be strictly greater than 0."
      );
    }
    else
    {
      try
      {
        int currentLine = 1; // Counter for current line
        StreamReader sw = new StreamReader(exP);
        string cLine = sw.ReadLine();
        while (cLine != null && currentLine < lineN)
        {
          cLine = sw.ReadLine();
          currentLine++;
        }
        if (currentLine == lineN)
        { // This will be true if we reached the lineN
          Console.WriteLine(
            "Line " + lineN + ": \"" + cLine + "\""
          );
        }
        else
        { // This will be true if we reached the end of the file.
          Console.WriteLine(
            "End of file was reached before reaching line number "
              + lineN
              + "."
          );
        }
      }
      catch
      {
        Console.WriteLine(
          "An error was thrown from Display method."
        );
      }
    }
  }

  public static void DisplayT(string exP, int charLimit)
  {
    if (!File.Exists(exP))
    {
      Console.WriteLine(
        "Nothing to display: the file does not exists."
      );
    }
    else if (charLimit <= 0)
    {
      Console.WriteLine(
        "The character limit should be strictly greater than 0"
      );
    }
    else
    {
      try
      {
        StreamReader sw = new StreamReader(exP);
        string cLine = sw.ReadLine();
        while (cLine != null)
        {
          // As long as the current line is longer than the charLimit...
          while (cLine.Length > charLimit)
          {
            // ...we enter this loops, display the first
            // charLimit characters...
            Console.WriteLine(
              cLine.Substring(0, charLimit)
            );
            // and update cLine to contains only the remaining
            // characters (that is, starting at charLimit).
            cLine = cLine.Substring(charLimit);
          }
          Console.WriteLine(cLine); // We display (what is left of) the current line.
          cLine = sw.ReadLine();
        }
        sw.Close();
      }
      catch
      {
        Console.WriteLine(
          "An error was thrown from DisplayT method."
        );
      }
    }
  }

  public static void DisplayW(string exP, string wordP)
  {
    if (!File.Exists(exP))
    {
      Console.WriteLine(
        "Nothing to display: the file does not exists."
      );
    }
    else
    {
      try
      {
        StreamReader sw = new StreamReader(exP);
        string cLine = sw.ReadLine();
        string[] cLineSplit;
        while (cLine != null)
        {
          cLineSplit = cLine.Split(' ');
          for (int i = 0; i < cLineSplit.Length; i++)
          {
            if (cLineSplit[i] == wordP)
            {
              if (i > 0)
              {
                Console.Write(cLineSplit[i - 1] + " ");
              }
              Console.Write(cLineSplit[i]);
              if (i < cLineSplit.Length - 1)
              {
                Console.Write(" " + cLineSplit[i + 1]);
              }
              Console.WriteLine();
            }
          }
          cLine = sw.ReadLine();
        }
        sw.Close();
      }
      catch
      {
        Console.WriteLine(
          "An error was thrown from DisplayW method."
        );
      }
    }
  }

  public static void DisplayWinnerCSV(string exP)
  {
    if (!File.Exists(exP))
    {
      Console.WriteLine(
        "Nothing to display: the file does not exists."
      );
    }
    if (!exP.EndsWith(".csv"))
    {
      Console.WriteLine(
        "Your file should have the .csv extension."
      );
    }
    else
    {
      try
      {
        StreamReader sw = new StreamReader(exP);
        sw.ReadLine(); // Skipping the first line

        string cLine = sw.ReadLine();
        string[] cLineSplit = cLine.Split(',');
        string winnerSoFar =
          cLineSplit[1] + " " + cLineSplit[2];

        int bestTimeSoFar =
          int.Parse(cLineSplit[3])
          + int.Parse(cLineSplit[4])
          + int.Parse(cLineSplit[5]);

        while (cLine != null)
        {
          cLineSplit = cLine.Split(',');
          if (
            bestTimeSoFar
            > int.Parse(cLineSplit[3])
              + int.Parse(cLineSplit[4])
              + int.Parse(cLineSplit[5])
          )
          {
            winnerSoFar =
              cLineSplit[1] + " " + cLineSplit[2];
          }

          cLine = sw.ReadLine();
        }
        sw.Close();
        Console.WriteLine(
          "The winner is " + winnerSoFar + "."
        );
      }
      catch
      {
        Console.WriteLine(
          "An error was thrown from DisplayWinnerCSV method."
        );
      }
    }
  }
}
