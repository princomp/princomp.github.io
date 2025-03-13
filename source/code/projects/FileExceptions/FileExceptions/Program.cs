using System;
using System.IO;


class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine(@"
        ***************************************
        * Streamreader constructor exceptions *
        ***************************************");     
        try
        {
            string filePath = null;
            StreamReader sr = new StreamReader(filePath);
        }
        catch(Exception e)
        {
            Console.WriteLine(e); // System.ArgumentNullException: Value cannot be null.
        }

        try
        {
            string filePath = "/not/a/proper/path/Test.txt";
            StreamReader sr = new StreamReader(filePath);
        }
        catch(Exception e)
        {
            Console.WriteLine(e); // System.IO.DirectoryNotFoundException: Could not find a part of the path "/not/a/proper/path/Test.txt".
        }

        Console.WriteLine(@"
        ***************************************
        * Streamwriter constructor exceptions *
        ***************************************");
        try
        {
            string filePath = null;
            StreamWriter sr = new StreamWriter(filePath);
        }
        catch (Exception e)
        {
            Console.WriteLine(e); // System.ArgumentNullException: Value cannot be null.
        }
        try
        {
            string filePath = "/not/a/proper/path/Test.txt";
            StreamWriter sr = new StreamWriter(filePath);
        }
        catch (Exception e)
        {
            Console.WriteLine(e); // System.IO.DirectoryNotFoundException: Could not find a part of the path "/not/a/proper/path/Test.txt".
        }




        string directoryPath = AppDomain
   .CurrentDomain
   .BaseDirectory;


    }



}
