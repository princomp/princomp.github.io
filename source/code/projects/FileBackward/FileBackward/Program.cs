using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Setting the directory path to the current 
        // folder, where the binary is located.
        string directoryPath = AppDomain
      .CurrentDomain
      .BaseDirectory;
        // Asking the user for file name.
        Console.WriteLine("Please, enter a file name (hit \"enter\" to use \"test.txt\").");
        string fileName = Console.ReadLine();
        if (fileName == null || fileName == "") fileName = "test.txt";
         string filePath = Path.Combine(
      directoryPath,
      fileName
    );
        // Creating a generator for random numbers.
        Random gen = new Random();
        int numNum = gen.Next(20, 100);
        // We will store between 20 and 99 numbers in our file.
        // We first populate the file with random numbers.
        try
        {
            Console.WriteLine("Now storing " + numNum + " random numbers into " + filePath + ".");
            StreamWriter sw = new StreamWriter(filePath);
            // Further references to sw *have to be* on the same try block.
            for (int i = 0; i < numNum; i++) sw.WriteLine(gen.Next(i + 2));
            sw.Close();
        }
        catch (Exception ex) { Console.WriteLine(ex); }

        // Reading the file and storing its values in a
        // partially filled array, cf.
        // https://princomp.github.io/lectures/collections/default_resizing#partially-filled-arrays
        int aSize = 5;
        int cLine = 0;
        string line;
        string[] text = new string[aSize];
        try
        {
            StreamReader sr = new StreamReader(filePath);
            line = sr.ReadLine();
            while (line != null)
            {
                // Uncomment if you would like to test / see the file displayed forward first.
                // Console.WriteLine(line);

                if (cLine + 1 > aSize)
                {
                    aSize *= 2;
                    Array.Resize(ref text, aSize);
                }
                text[cLine] = line;
                cLine++;
                line = sr.ReadLine();
            }
            sr.Close();

            Console.WriteLine("Displaying the file starting from the end:");
            for (int i = cLine - 1; i >= 0; i--)
            {
                Console.WriteLine(text[i]);
            }
        }
        catch (Exception ex) { Console.WriteLine(ex); }
    }
}