using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Calling displayAll(5):");
    displayAll(5);
    Console.WriteLine("\nCalling displayRAll(5):");
    displayRAll(5);
    Console.WriteLine("\nCalling mult(2, 10):");
    Console.WriteLine(mult(2, 10));
    Console.WriteLine("Calling factorial(5):");
    Console.WriteLine(factorial(5));
  }

  // Displays numbers from n to 1
  static void displayAll(int n)
  {
    if (n > 0)
    {
      Console.Write($"{n} ");
      displayAll(n - 1);
    }
  }

  // Displays numbers from 1 to n
  static void displayRAll(int n)
  {
    if (n > 0)
    {
      displayRAll(n - 1);
      Console.Write($"{n} ");
    }
  }

  // Recursive multiplication
  static int mult(int x, int y)
  {
    if (x == 0)
    {
      return 0;
    }
    else if (x == 1)
    {
      return y;
    }
    else
    {
      return y + mult(x - 1, y);
    }
  }

  // Recursive factorial
  static int factorial(int n)
  {
    if (n == 0)
      return 1;
    else
      return (factorial(n - 1) * n);
  }
  // An improvment would be to replace
  // (n == 0)
  // with
  // (n == 0 || n == 1)
  // Can you see why?
}
