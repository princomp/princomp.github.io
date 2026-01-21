using System;

class Program
{
  static void Main()
  {
    string answer;
    int value = 0; // We *have* to give this a value.
    bool valid = false;

    Console.WriteLine(
      "Test with"
        + "\n\t- nothing (ctrl + d on linux, ctrl + z on windows), "
        + "\n\t- \"No\","
        + "\n\t-  "
        + int.MaxValue
        + "+ 1 = 2147483648."
    );
    // Illustrating the exceptions int.Parse can throw.
    answer = Console.ReadLine();

    try
    {
      value = int.Parse(answer);
      valid = true;
    }
    catch (ArgumentNullException)
    {
      Console.WriteLine("No argument provided.");
    }
    catch (FormatException)
    {
      Console.WriteLine(
        "The string does not contain only number characters."
      );
    }
    catch (OverflowException)
    {
      Console.WriteLine(
        "The number is greater than what an integer can store."
      );
    }
    finally
    {
      Console.WriteLine("You entered \"" + answer + "\".");

      if (valid)
      {
        Console.WriteLine(
          "I can convert this to the following numerical value:"
            + value
        );
      }
      else
      {
        Console.WriteLine(
          "I cannot convert this to a numerical value."
        );
        Console.WriteLine(value);
      }
    }
  }
}
