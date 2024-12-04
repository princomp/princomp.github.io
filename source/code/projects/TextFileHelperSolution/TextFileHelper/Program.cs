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
     * will be created.
     */
    string directoryPath = AppDomain
      .CurrentDomain
      .BaseDirectory;
    string ex0 = Path.Combine(directoryPath, "ex0.txt");
    string ex1 = Path.Combine(directoryPath, "ex1.txt");
    string ex2 = Path.Combine(directoryPath, "ex2.txt");
    // We now call the "Init" method to create those files.
    TextFileHelper.Init(ex0, ex1, ex2);

    /*
     * The following is for demo purpose.
     */
    Console.WriteLine("*****\n* Testing Display\n*****");
    TextFileHelper.Display(ex0);
    Console.WriteLine(
      "*****\n* Testing DisplayNoComment\n*****"
    );
    TextFileHelper.DisplayNoComment(ex0);
    Console.WriteLine("*****\n* Testing Reverse\n*****");
    string ex3 = Path.Combine(directoryPath, "ex3.txt");
    TextFileHelper.Reverse(ex0, ex3);
    TextFileHelper.Display(ex3);
    Console.WriteLine("*****\n* Testing Concat\n*****");
    string ex4 = Path.Combine(directoryPath, "ex4.txt");
    TextFileHelper.Concat(ex0, ex1, ex4);
    TextFileHelper.Display(ex4);

    Console.WriteLine("*****\n* Testing Balanced\n*****");
    bool wb0 = TextFileHelper.Balanced(ex0);
    bool wb1 = TextFileHelper.Balanced(ex1);
    bool wb2 = TextFileHelper.Balanced(ex2);
    bool wb3 = TextFileHelper.Balanced(ex3);

    Console.WriteLine("ex0 is balanced: " + wb0);
    Console.WriteLine("ex1 is balanced: " + wb1);
    Console.WriteLine("ex2 is balanced: " + wb2);
    Console.WriteLine("ex3 is balanced: " + wb3);
  }
}
