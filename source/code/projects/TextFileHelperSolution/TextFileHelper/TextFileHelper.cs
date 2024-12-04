using System;
using System.Collections.Generic;
using System.IO;

static class TextFileHelper
{
  // This method creates three files at the paths
  // ex0P, ex1P and ex2P
  // that will serve for our tests.
  public static void Init(
    string ex0P,
    string ex1P,
    string ex2P,
    bool over = false
  )
  {
    if (
      !over
      && (
        File.Exists(ex0P)
        || File.Exists(ex1P)
        || File.Exists(ex0P)
      )
    )
    {
      Console.WriteLine(
        "One of the path already contains a file."
          + "\nCall the method with an additional parameter"
          + "\nset to \"true\" to override the existing file."
      );
    }
    else
    {
      try
      {
        StreamWriter ex0 = new StreamWriter(ex0P);
        ex0.Write(
          "This is the first demo file\n# This line starts with an \"#\").\n(An isolated parenthesis"
        );
        ex0.Close();
      }
      catch
      {
        Console.WriteLine(
          "There was an error creating ex0"
        );
      }
      try
      {
        StreamWriter ex1 = new StreamWriter(ex1P);
        ex1.Write(
          "(This is the second demo file"
            + "\n)There are parenthesis in it, but no pound (\"#\") character on the first line."
        );
        ex1.Close();
      }
      catch
      {
        Console.WriteLine(
          "There was an error creating ex1"
        );
      }
      try
      {
        StreamWriter ex2 = new StreamWriter(ex2P);
        ex2.Write(
          "# Just a comment )"
            + "\nand unbalanced parentheses ("
        );
        ex2.Close();
      }
      catch
      {
        Console.WriteLine(
          "There was an error creating ex2"
        );
      }
    }
  }

  public static void Display(string ex0P)
  {
    if (!File.Exists(ex0P))
    {
      Console.WriteLine(
        "Nothing to display: the file does not exists."
      );
    }
    else
    {
      try
      {
        StreamReader sw = new StreamReader(ex0P);
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

  public static void DisplayNoComment(string ex0P)
  {
    if (!File.Exists(ex0P))
    {
      Console.WriteLine(
        "Nothing to display: the file does not exists."
      );
    }
    else
    {
      try
      {
        StreamReader sw = new StreamReader(ex0P);
        string cLine = sw.ReadLine();
        while (cLine != null)
        {
          if (!cLine.StartsWith("#"))
          {
            Console.WriteLine(cLine);
          }
          cLine = sw.ReadLine();
        }
      }
      catch
      {
        Console.WriteLine(
          "An error was thrown from DisplayNoComment method."
        );
      }
    }
  }

  public static void Reverse(
    string ex0P,
    string ex1P,
    bool over = false
  )
  {
    if (!File.Exists(ex0P))
    {
      Console.WriteLine(
        "There is a problem: the source file does not exist."
      );
    }
    else if (File.Exists(ex1P) && !over)
    {
      Console.WriteLine(
        "There is a problem: the target file already exists."
          + "\nCall the method with an additional parameter"
          + "\nset to \"true\" to override the existing file."
      );
    }
    else
    {
      List<string> contentex0P = new List<string>();
      try
      {
        StreamReader sw0 = new StreamReader(ex0P);
        string cLine = sw0.ReadLine();
        while (cLine != null)
        {
          contentex0P.Add(cLine);
          cLine = sw0.ReadLine();
        }
        sw0.Close();

        StreamWriter sr1 = new StreamWriter(ex1P);
        for (int i = contentex0P.Count - 1; i >= 0; i--)
        {
          sr1.WriteLine(contentex0P[i]);
        }
        sr1.Close();
      }
      catch
      {
        Console.WriteLine(
          "An error was thrown from the Reverse method."
        );
      }
    }
  }

  public static void Concat(
    string ex0P,
    string ex1P,
    string ex2P,
    bool over = false
  )
  {
    if (!File.Exists(ex0P) || !File.Exists(ex1P))
    {
      Console.WriteLine(
        "There is a problem: one of the source file does not exist."
      );
    }
    else if (File.Exists(ex2P) && !over)
    {
      Console.WriteLine(
        "There is a problem: the target file already exists."
          + "\nCall the method with an additional parameter"
          + "\nset to \"true\" to override the existing file."
      );
    }
    else
    {
      List<string> contentex0P = new List<string>();
      try
      {
        StreamReader sw0 = new StreamReader(ex0P);
        string cLine = sw0.ReadLine();
        while (cLine != null)
        {
          contentex0P.Add(cLine);
          cLine = sw0.ReadLine();
        }
        sw0.Close();

        StreamReader sw1 = new StreamReader(ex1P);
        cLine = sw1.ReadLine();
        while (cLine != null)
        {
          contentex0P.Add(cLine);
          cLine = sw1.ReadLine();
        }
        sw1.Close();

        StreamWriter sr1 = new StreamWriter(ex2P);
        for (int i = 0; i < contentex0P.Count; i++)
        {
          sr1.WriteLine(contentex0P[i]);
        }
        sr1.Close();
      }
      catch
      {
        Console.WriteLine(
          "An error was thrown from the Concat method."
        );
      }
    }
  }

  public static bool Balanced(string ex0P)
  {
    int count = -1;
    if (!File.Exists(ex0P))
    {
      Console.WriteLine(
        "There is a problem: the source file does not exist."
      );
    }
    else
    {
      try
      {
        StreamReader sw0 = new StreamReader(ex0P);
        count = 0;
        char[] cLineChar;
        string cLine = sw0.ReadLine();
        while (cLine != null)
        {
          cLineChar = cLine.ToCharArray();
          for (int i = 0; i < cLineChar.Length; i++)
          {
            if (cLineChar[i] == '(')
            {
              count++;
            }
            if (cLineChar[i] == ')')
            {
              if (count <= 0)
              {
                return false;
              }
              else
              {
                count--;
              }
            }
          }
          cLine = sw0.ReadLine();
        }
        sw0.Close();
      }
      catch
      {
        Console.WriteLine(
          "An error was thrown from the Concat method."
        );
      }
    }
    return count == 0;
  }
}
