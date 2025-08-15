using System;
using System.IO;

class Program
{
  // We implement our own factorial function:
  static int factorial(int n)
  {
    if (n == 0)
      return 1;
    else
      return checked(factorial(n - 1) * n);
  }

  static void Main()
  {
    // As a reminder, this is the "biggest" integer
    // value C# can handle:
    Console.WriteLine(int.MaxValue);
    // 2,147,483,647

    // Remember that it's easy to trick C# into
    // overflowing:
    int x = int.MaxValue;
    int y = x + 1;
    Console.WriteLine(y);

    // Hence, we use the "checked" keyword
    // to force C# to check that no overflow
    // occurs:
    try
    {
      y = checked(x + 1);
    }
    catch (System.OverflowException)
    {
      Console.WriteLine(
        "An overflow exception was thrown."
      );
    }

    // Now we illustrate various growth
    // magnitude. Each "function" will have its
    // input grow linearly, and we will count
    // which input size makes the function
    // outputs something that is bigger than
    // the "biggest" integer value.

    // Factorial
    int inputfact = 0;
    int outputfact;
    try
    {
      while (true)
      {
        inputfact++;
        outputfact = checked(factorial(inputfact));
      }
    }
    catch (System.OverflowException)
    {
      Console.WriteLine(
        "Factorial: an overflow exception was thrown once input reached "
          + inputfact
          + "."
      );
      // Factorial: an overflow exception was thrown once input reached 13.
      // 13! = 6,227,020,800
    }

    // Exponential
    int inputexp = 0;
    int outputexp;
    try
    {
      while (true)
      {
        inputexp++;
        checked
        {
          outputexp = (int)Math.Pow(2, inputexp);
        }
      }
    }
    catch (System.OverflowException)
    {
      Console.WriteLine(
        "Exponential: an overflow exception was thrown once input reached "
          + inputexp
          + "."
      );
      // Exponential: an overflow exception was thrown once input reached 31.
      // 2^31 = 2,147,483,648
    }

    // Cubic
    int inputcubic = 0;
    int outputcubic;
    try
    {
      while (true)
      {
        inputcubic++;
        checked
        {
          outputcubic = (int)Math.Pow(inputcubic, 3);
        }
      }
    }
    catch (System.OverflowException)
    {
      Console.WriteLine(
        "Cubic: an overflow exception was thrown once input reached "
          + inputcubic
          + "."
      );
      // Cubic: an overflow exception was thrown once input reached 1291.
      // 1,291^3 = 2,151,685,171
    }

    // Quadratic
    int inputquad = 0;
    int outputquad;
    try
    {
      while (true)
      {
        inputquad++;
        checked
        {
          outputquad = (int)Math.Pow(inputquad, 2);
        }
      }
    }
    catch (System.OverflowException)
    {
      Console.WriteLine(
        "Quadratic: an overflow exception was thrown once input reached "
          + inputquad
          + "."
      );
      // Quadratic: an overflow exception was thrown once input reached 46341.
      // 46,341^2 = 2,147,488,281
    }

    // Linearithmic
    int inputlinearith = 81703000; // We do not start at 0 to save some time
    int outputlinearith;
    try
    {
      while (true)
      {
        inputlinearith++;
        checked
        {
          outputlinearith = (int)(
            inputlinearith * Math.Log(inputlinearith, 2)
          );
        }
      }
    }
    catch (System.OverflowException)
    {
      Console.WriteLine(
        "Linearithmic: an overflow exception was thrown once input reached "
          + inputlinearith
          + "."
      );
      // Linearithmic: an overflow exception was thrown once input reached 81703409.
      // 81,703,409 * (log(81,703,409)) = 81,703,409 * 26.2838929389692 = 2,147,483,654.90481
    }

    // Linear
    int inputlinear = 2147483640; // We do not start at 0 to save some time
    int outputlinear;
    try
    {
      while (true)
      {
        checked
        {
          inputlinear++;
          outputlinear = inputlinear;
        }
      }
    }
    catch (System.OverflowException)
    {
      Console.WriteLine(
        "Linear: an overflow exception was thrown once input reached "
          + inputlinear
          + "."
      );
      // Linear: an overflow exception was thrown once input reached 2147483647.
      // 2,147,483,647 is Max.IntValue
    }

    // Logarithmic
    double inputlog = Double.MaxValue - 1;
    // This is 1.7976931348623157E+308;
    double outputlog = Math.Log(inputlog, 2);
    Console.WriteLine(
      "Logarithmic: log of "
        + inputlog
        + " is "
        + outputlog
        + "."
    );
    // Logarithmic: log of 1.79769313486232E+308 is 1024.
  }
}
