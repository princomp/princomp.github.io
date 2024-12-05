using System;

class Program
{
    static void Main()
    {
        // Example array1
        int[,] matrix =
        {
      { 1, 2, 3 },
      { 4, 5, 6 },
      { 7, 8, 9 },
      { 10, 11, 12 },
    };
        // End of example array1
        Display(matrix);
        Rotate(ref matrix);
        Display(matrix);
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
                  tmp.GetLength(1) - col - 1,
                  row
                ];
            }
        }
        matP = tmp;
    }
    // End of method to rotate an array 90° clockwise
}
