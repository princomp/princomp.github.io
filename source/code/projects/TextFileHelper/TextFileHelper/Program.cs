using System;
using System.Collections.Generic;
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
        string ex0 = Path.Combine(
      directoryPath,
      "ex0.txt"
    );
        string ex1 = Path.Combine(
directoryPath,
"ex1.txt"
);
        string ex2 = Path.Combine(
directoryPath,
"ex2.txt"
);
        // We now call the "Init" method to create those files.
        TextFileHelper.Init(ex0, ex1, ex2);

        /* 
         * The following is for demo purpose.
         * Feel free edit it as you see fit.
         */
        // WARNING This code cannot be compiled unless the following is commented out.
        // START commenting here
        Console.WriteLine("*****\n* Testing Display\n*****");
        TextFileHelper.Display(ex0);
        Console.WriteLine("*****\n* Testing DisplayNoComment\n*****");
        TextFileHelper.DisplayNoComment(ex0);
        Console.WriteLine("*****\n* Testing Reverse\n*****");
        string ex3 = Path.Combine(
directoryPath,
"ex3.txt"
);
        TextFileHelper.Reverse(ex0, ex3);
        TextFileHelper.Display(ex3);
        Console.WriteLine("*****\n* Testing Concat\n*****");
        string ex4 = Path.Combine(
directoryPath,
"ex4.txt"
);
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

static class TextFileHelper
{
    // This method creates three files at the paths
    // ex0P, ex1P and ex2P
    // that will serve for our tests.
    public static void Init(string ex0P, string ex1P, string ex2P, bool over = false)
    {
        if (!over && (File.Exists(ex0P) || File.Exists(ex1P) || File.Exists(ex0P)))
        {
            Console.WriteLine(
            "One of the path already contains a file." +
            "\nCall the method with an additional parameter" +
            "\nset to \"true\" to override the existing file.");
        }
        else
        {
            try
            {
                StreamWriter ex0 = new StreamWriter(ex0P);
                ex0.Write("This is the first demo file\n# This line starts with an \"#\").\n(An isolated parenthesis");
                ex0.Close();
            }
            catch
            {
                Console.WriteLine("There was an error creating ex0.");
            }
            try
            {
                StreamWriter ex1 = new StreamWriter(ex1P);
                ex1.Write("(This is the second demo file" +
                "\n)There are parenthesis in it, but no pound (\"#\") character on the first line.");
                ex1.Close();
            }
            catch
            {
                Console.WriteLine("There was an error creating ex1.");
            }
            try
            {
                StreamWriter ex2 = new StreamWriter(ex2P);
                ex2.Write("# Just a comment )" + "\nand unbalanced parentheses (");
                ex2.Close();
            }
            catch
            {
                Console.WriteLine("There was an error creating ex2.");
            }
        }
    }
}
