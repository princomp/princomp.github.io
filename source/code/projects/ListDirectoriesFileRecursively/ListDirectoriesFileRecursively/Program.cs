using System;
using System.IO;

class Program
{
    static void Main()
    {
        // We first locate where we currently are.
        DirectoryInfo currentDir = new DirectoryInfo(
        Directory.GetCurrentDirectory()
      );
        Console.WriteLine("Starting from " + currentDir + ".");
        int count = 5;
        // We go up 5 folders or until we reach the 
        // root folder, whichever comes first.
        while (currentDir.Parent != null && count > 0)
        {
            currentDir = currentDir.Parent;
            count--;
            Console.WriteLine("Going up to " + currentDir + ".");
        }
        Console.WriteLine("Now listing files and folders from here:");
        ListDir(currentDir.ToString());
    }
    // Code in part inspired from 
    // https://stackoverflow.com/a/929277
    static void ListDir(string sourceDir)
    {
        try
        {
            Console.WriteLine(sourceDir);

            foreach (string file in Directory.GetFiles(sourceDir))
                Console.WriteLine(file);

            foreach (string directory in Directory.GetDirectories(sourceDir))
                ListDir(directory);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
