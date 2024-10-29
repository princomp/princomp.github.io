using System;
using System.IO;

/*
 * Code heavily inspired from
 * https://learn.microsoft.com/en-us/troubleshoot/developer/visualstudio/csharp/language-compilers/read-write-text-file
 */
class Program
{
    static void Main(string[] args)
    {
        // Write
        string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Hello.txt");

        try
        {
            //Pass the filepath and filename to the StreamWriter Constructor
            StreamWriter sw = new StreamWriter(filePath);
            //Write a line of text
            sw.WriteLine("Hello World!!");
            //Write a second line of text
            sw.WriteLine("From the StreamWriter class");
            //Write out the numbers 1 to 10 on the same line.
            for (int x = 0; x < 10; x++)
            {
                sw.Write(x);
            }
            //Close the file
            sw.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }

        string line;
        try
        {
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader(filePath);
            //Read the first line of text
            line = sr.ReadLine();
            string[] words;
            int wordcount = 0;
            //Continue to read until you reach end of file
            while (line != null)
            {
               words = line.Split(' ');
                wordcount += words.Length;
                //write the line to console window
                Console.WriteLine(line);
                //Read the next line
                line = sr.ReadLine();
            }
            //close the file
            sr.Close();
            Console.WriteLine("Total number of words: " + wordcount + ".");
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }
    }
}
