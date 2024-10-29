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

        string fName;
        do
        {
            Console.WriteLine("Enter a file name that ends with .txt");
            fName = Console.ReadLine();
        } while (!fName.EndsWith(".txt") || fName.StartsWith("."));

        // Write
        string baseFolder = AppDomain.CurrentDomain.BaseDirectory;
        Console.WriteLine("baseFolder is " + baseFolder);
        //  /home/caubert/travail/git/princomp.github.io/source/code/projects/FileDemo/FileDemo/bin/Debug/

        // Directory.GetCurrentDirectory()
        string filePath = Path.Combine(baseFolder, "Hello.txt");

        try
        {
            StreamWriter sw;
            if (File.Exists(filePath))
            {
                Console.WriteLine("The file " + filePath + " already exists, so we append to it.");
                sw = new StreamWriter(filePath, true);

            }
            else
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                sw = new StreamWriter(filePath);
            }
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
        if (!File.Exists(filePath))
            {
                Console.WriteLine("File does not exist.");
            }
            else
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(filePath);
                //Read the first line of text
                line = sr.ReadLine();
                string[] words;
                int wordcount = 0;
                //Continue to read until you reach end of file
                string[] sepChars = { "-", ".", " " };
                while (line != null)
                {
                    words = line.Split(' ');
                    wordcount += words.Length;
                    //write the line to console window
                    Console.WriteLine(line);
                    //Read the next line

                    string[] wordArray = line.Split(sepChars, StringSplitOptions.RemoveEmptyEntries);
                        // Omit array elements that contain an empty string from the result.
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close(); // or sr.Dispose();
                Console.WriteLine("Total number of words: " + wordcount + ".");
            }
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
