using System;
using System.Collections.Generic;

class Program
{
  static void Main(string[] args)
  {
    // DisplayH question
    string DisplayH(int[] aP, int currentIndex)
    {
      string ret = "";
      if (aP.Length == currentIndex + 1)
        ret += " || " + aP[currentIndex].ToString();
      else ret+= DisplayH(aP, currentIndex+1) + ", " + aP[currentIndex].ToString();
      if (currentIndex == 0){ret += " ** "; }
      return ret; 
    }
    string Display(int[] aP)
    {
      if (aP == null)
        return "";
      else
        return DisplayH(aP, 0);
    }
    // Examples
    int[] array0 = { 1, 2, 4};
    int[] array1 = { 1, 2, 4, 10, 13, 17 };
    int[] array2 = { 12, 98, 120, 15 };
    int[] array3 =
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
    Console.WriteLine("Example 0: " + Display(array0));
    Console.WriteLine("Example 1: " + Display(array1));
    Console.WriteLine("Example 2: " + Display(array2));
    Console.WriteLine(
      "Example 3: " + Display(array3)
    );

  }
}
