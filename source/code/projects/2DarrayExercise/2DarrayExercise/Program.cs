using System;

class Program
{
  static void Main()
  {
    // Example array1
    int[,] matrix1 =
    {
      { 1, 2, 3 },
      { 4, 5, 6 },
      { 7, 8, 9 },
      { 10, 11, 12 },
    };
    // End of example array1
    Console.WriteLine("Example 1:");
    Display(matrix1);
    Console.WriteLine("We now rotate the array.");
    Rotate(ref matrix1);
    Display(matrix1);

    // Example array2
    int[,] matrix2 =
    {
      { 1, 2, 3, 4 },
      { 5, 6, 7, 8 },
      { 9, 10, 11, 12 },
    };
    // End of example array2
    Console.WriteLine("Example 2:");
    Display(matrix2);
    Console.WriteLine("We now rotate the array.");
    Rotate(ref matrix2);
    Display(matrix2);
  }

  // Method to display 2-d arrays
  static void Display(int[,] matP)
  {
    for (int row = 0; row < matP.GetLength(0); row++)
    {
      for (int col = 0; col < matP.GetLength(1); col++)
      {
        Console.Write(
          String.Format("|{0,4} ", matP[row, col])
        );
      }
      Console.WriteLine(" |");
    }
  }

  // End of method to display 2-d arrays

  // Method to rotate an array 90° clockwise
  static void Rotate(ref int[,] matP)
  {
    int[,] tmp = new int[
      matP.GetLength(1),
      matP.GetLength(0)
    ];
    for (int row = 0; row < tmp.GetLength(0); row++)
    {
      for (int col = 0; col < tmp.GetLength(1); col++)
      {
        tmp[row, col] = matP[
          // This would be incorrect:
          // tmp.GetLength(0) - col, row
          // can you figure out why?
          tmp.GetLength(1)
            - col
            - 1,
          row
        ];
      }
    }
    matP = tmp;
  }
  // End of method to rotate an array 90° clockwise
}
