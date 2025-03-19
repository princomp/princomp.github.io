using System;

class Program
{
  static void Main(string[] args)
  {
    // Rectangular Arrays
    int[,] testR1 =
    {
      { 1, 2, 3 },
      { 4, 5, 6 },
    };
    int[,] testR2 =
    {
      { 1, 2, 3 },
      { 4, 5, 6 },
      { 0, 2, 10 },
    };

    // Code for DisplayR and RankedR is below, in their own methods.
    DisplayR(testR1);
    DisplayR(testR2);
    Console.WriteLine("Ranked:" + RankedR(testR2));

    // Jagged Arrays
    int[][] testJ1 = new int[2][];
    testJ1[0] = new int[4] { 1, 2, 3, 4 };
    testJ1[1] = new int[2] { 5, 6 };

    int[][] testJ2 = new int[3][];
    testJ2[0] = new int[4] { 1, 2, 3, 4 };
    testJ2[1] = new int[2] { 5, 6 };
    testJ2[2] = new int[3] { 0, 2, 10 };

    // Code for DisplayJ and RankedJ is below, in their own methods.
    DisplayJ(testJ1);
    DisplayJ(testJ2);

    Console.WriteLine("Ranked:" + RankedJ(testJ2));
  }

  /* Rectangular arrays */
  static void DisplayR(int[,] a)
  {
    for (int row = 0; row < a.GetLength(0); row++)
    {
      for (int col = 0; col < a.GetLength(1); col++)
      {
        Console.Write(a[row, col] + " ");
      }
      Console.WriteLine();
    }
  }

  static bool RankedR(int[,] a)
  {
    bool rsf = true;
    int countp = 0;
    int count = 0;
    for (int row = 0; row < a.GetLength(0); row++)
    {
      for (int col = 0; col < a.GetLength(1); col++)
      {
        count += a[row, col];
      }
      // Helper line:
      Console.WriteLine(
        $"Previous: {countp} Current: {count}"
      );
      if (row == 0)
      {
        countp = count;
      }
      else if (countp >= count)
        rsf = false;
      countp = count;
      count = 0;
    }
    return rsf;
  }

  /* Jagged Arrays */
  static void DisplayJ(int[][] a)
  {
    for (int row = 0; row < a.Length; row++)
    {
      for (int col = 0; col < a[row].Length; col++)
      {
        Console.Write(a[row][col] + " ");
      }
      Console.WriteLine();
    }
  }

  static bool RankedJ(int[][] a)
  {
    bool rsf = true;
    int countp = 0;
    int count = 0;
    for (int row = 0; row < a.Length; row++)
    {
      for (int col = 0; col < a[row].Length; col++)
      {
        count += a[row][col];
      }
      // Helper line:
      Console.WriteLine(
        $"Previous: {countp} Current: {count}"
      );
      if (row == 0)
      {
        countp = count;
      }
      else if (countp >= count)
        rsf = false;
      countp = count;
      count = 0;
    }
    return rsf;
  }
}
