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
     * are located.
     */
    string directoryPath = AppDomain
      .CurrentDomain
      .BaseDirectory;
    string ex0 = Path.Combine(directoryPath, "ex0.txt");
    string ex1 = Path.Combine(directoryPath, "ex1.txt");
    string ex2 = Path.Combine(directoryPath, "ex2.csv");

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
