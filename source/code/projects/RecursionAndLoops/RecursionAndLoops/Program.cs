using System;

class Program
{
  static void Main(string[] args)
  {
    /*
     * Display count-down from i to 0
     * (supposing i is positive)
     */
    // Count-down using while loop
    int i = 10;
    while (i > 0)
    {
      Console.Write($"{i} ");
      i--;
    }

    // Count-down using recursion
    void CountDown(int iP)
    {
      if (iP > 0)
      {
        Console.Write($"{iP} ");
        CountDown(iP - 1);
      }
    }
    CountDown(10);

    /*
     * Compute 0 + 1 + 2 + … + n
     * (supposing n is positive)
     */

    // Sum using do while
    int n = 10;
    int sum = 0;
    do
    {
      sum += n;
      n--;
    } while (n > 0);
    Console.WriteLine($"Sum: {sum}");

    // Sum using recursion
    int Sum(int nP)
    {
      if (nP > 0)
      {
        return nP + Sum(nP - 1);
      }
      else
      {
        return 0;
      }
    }
    Console.WriteLine($"Sum: {Sum(10)}");

    /*
     * Display odd numbers in an array
     */

    // Display odd values using for loop
    int[] test = { 1, 5, 2, 10, 11, -12, -11 };
    for (int l = 0; l < test.Length; l++)
    {
      if (test[l] % 2 != 0)
      {
        Console.Write($"{test[l]} ");
      }
    }

    // Display odd values using recursion
    void OddInArray(int[] arP, int cIndex)
    {
      if (cIndex < arP.Length)
      {
        if (arP[cIndex] % 2 != 0)
        {
          Console.Write($"{arP[cIndex]} ");
        }
        OddInArray(arP, cIndex + 1);
      }
    }
    OddInArray(test, 0);
  }
}
