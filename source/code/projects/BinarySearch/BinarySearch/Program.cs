using System;

class Program
{
  public static void Main()
  {
    // Example value
    int[] arrayEx =
    {
      10,
      15,
      30,
      45,
      60,
      75,
      90,
      105,
      120,
      135,
      150,
      165,
      180,
    };
    // Algorithm (silent)
    bool fsf = false;
    int tar = 105;
    int sta = 0;
    int end = arrayEx.Length - 1;
    int mid,
      cur;
    while (sta <= end && !fsf)
    {
      mid = (sta + end) / 2;
      cur = arrayEx[mid];
      if (tar == cur)
      {
        fsf = true;
      }
      else if (tar > cur)
      {
        sta = mid + 1;
      }
      else
      {
        end = mid - 1;
      }
    }

    // Algorithm (verbose)
    fsf = false;
    tar = 105;
    sta = 0;
    end = arrayEx.Length - 1;
    string sep = new String('-', 72); // Simple separating string, for formatting purpose.
    Console.WriteLine("Before loop:\n" + sep);
    Console.WriteLine(
      "| {0, 5} | {1, 5} | {2, 5} | {3, 5} | {4, 5} |",
      $"sta = {sta}",
      $"end = {end}",
      $"mid = undefined",
      $"fsf = {fsf}",
      $"cur = undefined"
    );
    Console.WriteLine(sep);
    sep = new String('-', 57); // Shortening the separating string.
    int counter = 0; // To display loop count.
    while (sta <= end && !fsf)
    {
      counter++;
      mid = (sta + end) / 2;
      cur = arrayEx[mid];
      if (tar == cur)
      {
        fsf = true;
      }
      else if (tar > cur)
      {
        sta = mid + 1;
      }
      else
      {
        end = mid - 1;
      }
      Console.WriteLine(
        $"After {counter} iteration(s):\n" + sep
      );
      Console.WriteLine(
        "| {0, 5} | {1, 5} | {2, 5} | {3, 5} | {4, 5} |",
        $"sta = {sta}",
        $"end = {end}",
        $"mid = {mid}",
        $"fsf = {fsf}",
        $"cur = {cur}"
      );
      Console.WriteLine(sep);
    }
    // Test with different values!
  }
}
