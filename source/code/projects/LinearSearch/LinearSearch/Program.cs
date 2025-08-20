using System;

class Program
{
  public static void Main()
  {
    // Example value
    int[] arrayExample =
    {
      1,
      8,
      -12,
      9,
      10,
      1,
      30,
      1,
      32,
      3,
    };

    bool foundTarget = false;
    int target = 8;

    for (int i = 0; i < arrayExample.Length; i++)
    {
      if (arrayExample[i] == target)
        foundTarget = true;
    }
    Console.WriteLine(
      target + " is in the array: " + foundTarget + "."
    );

    // We can optimize this algorithm
    // by exiting when the target is found.

    bool foundYet = false;
    target = 30;
    int index = 0;

    do
    {
      if (arrayExample[index] == target)
        foundYet = true;
      index++;
    } while (index < arrayExample.Length && !foundYet);
    Console.WriteLine(
      target
        + " is in the array: "
        + foundYet
        + "\nNumber of elements inspected: "
        + (index)
        + "."
    );

    // This would display:
    // 30 is in the array: True
    // Number of elements inspected: 7.
  }
}
