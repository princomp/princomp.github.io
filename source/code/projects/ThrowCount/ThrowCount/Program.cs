using System;

class Program
{
  static void Main()
  {
    /* Variable declarations. */
    int dicesides; // Number of sides on dice
    string uInput; // User input.
    bool valid; // Flag to save whether the last choice is valid.
    int nThrow; // Number of throws
    int[] results; // Array to store the throws
    int count = 0; // Counter we will use to know how many throws have been entered.
    int cThrow; // Value of current throw.

    /* Asking the number of sides on the dice.*/
    do
    {
      Console.WriteLine(
        "How many sides does your dice have?\nValid choices are 4, 6, 8, 10, 12 or 20."
      );
      uInput = Console.ReadLine();
      valid =
        int.TryParse(uInput, out dicesides)
        && (
          dicesides == 4
          || dicesides == 6
          || dicesides == 8
          || dicesides == 10
          || dicesides == 12
          || dicesides == 20
        );
    } while (!valid);
    Console.WriteLine(
      "You picked a " + dicesides + " sided dice."
    );

    /* Asking how many times the dice will be thrown. */
    do
    {
      Console.WriteLine(
        "How many times will you throw it?"
      );
      uInput = Console.ReadLine();
      valid =
        int.TryParse(uInput, out nThrow) && nThrow > 0;
    } while (!valid);

    /* Collecting the results of the throws. */
    results = new int[nThrow]; // Declaring an array of the right size.
    Console.WriteLine(
      "Enter the "
        + nThrow
        + " throws, one by one, separated by new lines."
    );
    do
    {
      Console.Write("Enter throw #" + (count + 1) + ". ");
      uInput = Console.ReadLine();
      valid =
        int.TryParse(uInput, out cThrow)
        && 0 < cThrow
        && cThrow <= dicesides;
      if (valid)
      {
        results[count] = cThrow;
        count++;
      }
    } while (count < nThrow);

    /* Displaying statistics. */
    Console.WriteLine("You made the following throws:");
    Console.WriteLine("| Value | Number of throws | ");
    for (int i = 1; i <= dicesides; i++)
    {
      count = 0;
      for (int j = 0; j < results.Length; j++)
      {
        if (results[j] == i)
          count++;
      }
      Console.WriteLine($"|   {i}   | {count}");
    }

    // Computing and displaying average.
    count = 0;
    for (int j = 0; j < results.Length; j++)
    {
      count += results[j];
    }
    Console.WriteLine(
      $"Your average is {(double)count / nThrow}."
    );
  }
}
