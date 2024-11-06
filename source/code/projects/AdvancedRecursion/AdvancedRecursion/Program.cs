using System;
using System.Collections.Generic;

class Program
{
  static void Main(string[] args)
  {
    // Simplest possible example of a recursive function:
    // Warning: dangerous function!
    void R()
    {
      R();
    }
    // Uncomment at your own risk!
    // R();

    // Recursive CountDown method
    void CountDown(int n)
    {
      if (n == 0)
      {
        Console.WriteLine($"{n}: Blast off!");
      }
      else
      {
        Console.Write($"{n}…");
        CountDown(n - 1);
      }
    }
    // Usage example
    CountDown(10);

    // Recursive CountUp method
    void CountUp(int n)
    {
      if (n == 0)
      {
        Console.WriteLine($"{n}: Blast off!");
      }
      else
      {
        Console.Write($"{n}…");
        CountUp(n + 1); // <- Only change.
      }
    }
    void Count(int n)
    {
      if (n < 0)
        CountUp(n);
      else
        CountDown(n);
    }
    Count(10);
    Count(-10);

    // Mutually recursive methods
    void MyTurn(int n)
    {
      if (n < 0)
      {
        Console.WriteLine("The Game is over.");
      }
      else
      {
        Console.WriteLine("It's my turn");
        n--;
        if (n < 0)
        {
          Console.WriteLine("The Game is over.");
        }
        else
        {
          YourTurn(n);
        }
      }
    }
    void YourTurn(int n)
    {
      Console.WriteLine("It's your turn.");
      MyTurn(n);
    }
    // Usage example
    MyTurn(4);

    // Sorted method helper
    bool SortedH(int[] aP, int currentIndex)
    {
      if (aP.Length == currentIndex + 1)
        return true;
      else if (aP[currentIndex] > aP[currentIndex + 1])
        return false;
      else
        return SortedH(aP, currentIndex + 1);
    }
    // Actual sorted method
    bool Sorted(int[] aP)
    {
      if (aP == null)
        return false;
      else
        return SortedH(aP, 0);
    }
    // Examples

    int[] arrayS = { 1, 2, 4, 10, 13, 17 };
    int[] arrayNS = { 12, 98, 120, 15 };
    int[] arrayExample =
    {
      1,
      10,
      12,
      129,
      190,
      220,
      230,
      310,
      320,
      340,
      400,
      460,
    };

    Console.WriteLine("Array sorted: " + Sorted(arrayS));
    Console.WriteLine("Array sorted: " + Sorted(arrayNS));
    Console.WriteLine(
      "Array sorted: " + Sorted(arrayExample)
    );

    // Binary Search helper
    bool BinFindH(int[] aP, int start, int end, int target)
    {
      int mid = (start + end) / 2;
      if (start > end)
      {
        return false;
      }
      else
      {
        if (target == aP[mid])
        {
          return true;
        }
        else if (target > aP[mid])
        {
          return BinFindH(aP, mid + 1, end, target);
        }
        else
        {
          return BinFindH(aP, start, mid - 1, target);
        }
      }
    }
    // Binary search
    bool BinFind(int[] aP, int target)
    {
      return BinFindH(aP, 0, aP.Length - 1, target);
    }

    // Examples
    Console.Write(
      "BinFind: " + BinFind(arrayExample, 10) + "\n"
    );
    Console.Write(
      "BinFind: " + BinFind(arrayExample, 460) + "\n"
    );
    Console.Write(
      "BinFind: " + BinFind(arrayExample, 440) + "\n"
    );
    Console.Write(
      "BinFind: " + BinFind(arrayExample, 480) + "\n"
    );

    // Recursive way of displaying lists
    string DisplayH(
      string retString,
      List<string> listP,
      int indexP
    )
    {
      if (listP.Count == indexP + 1)
      {
        return retString + listP[indexP] + ".\n";
      }
      else
      {
        retString += listP[indexP] + " -> ";
        return DisplayH(retString, listP, indexP + 1);
      }
    }

    string Display(List<string> ListP)
    {
      string retString = "";
      return DisplayH(retString, ListP, 0);
    }
    // Examples
    List<string> operatingSystems = new List<string>
    {
      "Unix",
      "Windows",
      "iOS",
      "OS X",
      "Android",
    };
    Console.WriteLine(Display(operatingSystems));

    // Using reference and recursion to display lists
    void DisplayRef(ref string descP, List<string> listP)
    {
      if (listP == null || listP.Count == 0)
      {
        descP += ".\n";
      }
      else if (listP.Count == 1)
      {
        descP += listP[0] + ".\n";
      }
      else
      {
        descP += listP[0] + " -> ";
        listP.RemoveAt(0);
        DisplayRef(ref descP, listP);
      }
    }
    // Example.
    string desc = "";
    // Note that we create a copy of the list.
    List<string> listCopy = new List<string>(
      operatingSystems
    );
    // We now call the method with the copy of the list.
    DisplayRef(ref desc, listCopy);
    Console.WriteLine(desc);
  }
}