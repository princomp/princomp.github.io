using System;

public class Program
{
  public static void Main(string[] args)
  {
    // We decide that the maximum number of input is 10.
    const int MAXSIZE = 10;

    int[] inputs = new int[MAXSIZE];

    // The following variable will contain the number of input actually given.
    int numberOfInputs = 0;

    // The following variable will hold the user input.
    string uInput;

    do
    {
      Console.WriteLine(
        "What is your input #"
          + (numberOfInputs + 1)
          + "? Enter \"done\" when you are done."
      );
      uInput = Console.ReadLine();
      if (uInput != "done")
      {
        inputs[numberOfInputs] = int.Parse(uInput);
        numberOfInputs++; // We increment the number of items in the list.
      }
      if (numberOfInputs == MAXSIZE)
      {
        Console.WriteLine(
          "You have reached the maximum number of inputs."
        );
      }
    } while (uInput != "done" && numberOfInputs < MAXSIZE);
    /*
     * When the user enters "done", or if the user reached the maximum number of inputs, we exit this loop.
     */
  }
}
