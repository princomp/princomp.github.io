using System;
using System.IO;

class Program
{
  static void Main()
  {
        DirectoryInfo d = new DirectoryInfo(
        Directory.GetCurrentDirectory()
      );
        while (d.Parent != null) {
        d = d.Parent;
            Console.WriteLine("Going up to " + d + ".");
            }
        ListDir(d.ToString());

    }
    // Code in part inspired from 
    // https://stackoverflow.com/a/929277
    static void ListDir(string sDir)
    {
        try
        {
            Console.WriteLine(sDir);

            foreach (string f in Directory.GetFiles(sDir))
            {
                Console.WriteLine(f);
            }

            foreach (string d in Directory.GetDirectories(sDir))
            {
                ListDir(d);
            }
        }
        catch (System.Exception excpt)
        {
            Console.WriteLine(excpt.Message);
        }
    }
}
