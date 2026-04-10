using System;
using System.IO;

class Program
{
  static void Main()
  {
    /*
     * We first create three
     * string variables where
     * our three demo files
     * are located, and created.
     */
    string directoryPath = AppDomain
      .CurrentDomain
      .BaseDirectory;
    string ex0 = Path.Combine(directoryPath, "ex0.txt");
    try
    {
      StreamWriter sr = new StreamWriter(ex0);
      sr.WriteLine(
        @"This is the first demo file. It contains a long first line that will not wrap nicely on some display.
It also contains another line that contains the word line also.
It will be used to test our methods.
"
      );
      sr.Close();
    }
    catch (Exception ex)
    {
      Console.WriteLine(
        "Something went wrong setting up the project.\nPlease, contact your instructor, sharing the following message:\n"
          + ex.Message
      );
    }
    string ex1 = Path.Combine(directoryPath, "ex1.txt");
    try
    {
      StreamWriter sr = new StreamWriter(ex1);
      sr.WriteLine(
        @"A very short
demo file.
"
      );
      sr.Close();
    }
    catch (Exception ex)
    {
      Console.WriteLine(
        "Something went wrong setting up the project.\nPlease, contact your instructor, sharing the following message:\n"
          + ex.Message
      );
    }
    string ex2 = Path.Combine(directoryPath, "ex2.csv");
    try
    {
      StreamWriter sr = new StreamWriter(ex2);
      sr.WriteLine(
        @"Index,First Name,Last Name,Lap 1, Lap 2, Lap 3
1,Shelby,Terrell,78,80,82
2,Phillip,Summers,76,82,91
3,Kristine,Travis,78,82,83
4,Marty,Gave,67,73,72
5,Harley,Test,78,91,72"
      );
      sr.Close();
    }
    catch (Exception ex)
    {
      Console.WriteLine(
        "Something went wrong setting up the project.\nPlease, contact your instructor, sharing the following message:\n"
          + ex.Message
      );
    }

    // Testing the "Display" Method:
    Console.WriteLine("*****\n* Testing Display\n*****");
    FileDisplayer.Display(ex0);
    // Testing the "DisplayN" method
    Console.WriteLine("*****\n* Testing DisplayN\n*****");
    FileDisplayer.DisplayN(ex0, 1);
    FileDisplayer.DisplayN(ex0, 3);
    FileDisplayer.DisplayN(ex0, 10);
    FileDisplayer.DisplayN(ex0, 0);
    FileDisplayer.DisplayN(ex0, -10);
    // Testing the "DisplayT" method
    Console.WriteLine(
      "*****\n* Testing DisplayT (1/2)\n*****"
    );
    FileDisplayer.DisplayT(ex0, 20);
    Console.WriteLine(
      "*****\n* Testing DisplayT (2/2)\n*****"
    );

    FileDisplayer.DisplayT(ex1, 5);
    // Testing the "DisplayW" method
    Console.WriteLine(
      "*****\n* Testing DisplayW (1/2)\n*****"
    );
    FileDisplayer.DisplayW(ex0, "line");

    Console.WriteLine(
      "*****\n* Testing DisplayW (2/2)\n*****"
    );
    FileDisplayer.DisplayW(ex1, "short");
    // Testing the "DisplayWinnerCSV" method

    Console.WriteLine(
      "*****\n* Testing DisplayWinnerCSV (Optional)\n*****"
    );
    FileDisplayer.DisplayWinnerCSV(ex2);
  }
}
