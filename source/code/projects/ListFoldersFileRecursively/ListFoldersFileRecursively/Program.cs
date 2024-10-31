using System;
using System.IO;

class Program
{
  static void Main()
  {
        string root = AppDomain.CurrentDomain.BaseDirectory;
        Console.Write(root);
        DirSearch_ex3("c:\\aaa");
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
