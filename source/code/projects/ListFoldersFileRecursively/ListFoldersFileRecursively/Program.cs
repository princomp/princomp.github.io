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

    }
    static void DirSearch_ex3(string sDir)
    {
        //Console.WriteLine("DirSearch..(" + sDir + ")");
        try
        {
            Console.WriteLine(sDir);

            foreach (string f in Directory.GetFiles(sDir))
            {
                Console.WriteLine(f);
            }

            foreach (string d in Directory.GetDirectories(sDir))
            {
                DirSearch_ex3(d);
            }
        }
        catch (System.Exception excpt)
        {
            Console.WriteLine(excpt.Message);
        }
    }
}
