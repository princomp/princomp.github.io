using System;

class Program
{
  // This method computes the product of two matrices.
  static int[,] MatrixMultiplication(
    int[,] matrix1,
    int[,] matrix2
  )
  {
    int row1 = matrix1.GetLength(0);
    int column1 = matrix1.GetLength(1);
    int row2 = matrix2.GetLength(0);
    int column2 = matrix2.GetLength(1);

    if (column1 != row2)
    {
      throw new ArgumentException(
        "Those matrixes cannot be multiplied!!"
      );
    }
    else
    {
      int temp = 0;
      int[,] matrixproduct = new int[row1, column2];

      for (int i = 0; i < row1; i++)
      {
        for (int j = 0; j < column2; j++)
        {
          temp = 0;
          for (int k = 0; k < column1; k++)
          {
            temp += matrix1[i, k] * matrix2[k, j];
          }
          matrixproduct[i, j] = temp;
        }
      }

      return matrixproduct;
    }
  }

  // Useful to display matrices.
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

  static void Main()
  {
    int[,] A =
    {
      { 12, 10, 3 },
      { 11, 9, 7 },
    };
    int[,] B =
    {
      { 2, 3 },
      { 4, 5 },
      { 6, 8 },
    };
    int[,] AxB = MatrixMultiplication(A, B);

    Display(A);
    Console.WriteLine("times");
    Display(B);
    Console.WriteLine(" is ");
    Display(AxB);
  }
}
