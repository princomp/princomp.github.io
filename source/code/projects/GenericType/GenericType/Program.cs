using System;

class Program
{
  static void Main()
  {
    // Using Reverse:
    int[] array1 = { 0, 2, 3, 6 };
    int[] array1reversed = Helper.Reverse<int>(array1);

    char[] array2 = { 'a', 'b', 'c' };
    char[] array2reversed = Helper.Reverse<char>(array2);

    // Using Description:
    Console.WriteLine("Array 1:");
    Console.WriteLine(Helper.Description<int>(array1));
    Console.WriteLine("Array 1 reversed:");
    Console.WriteLine(
      Helper.Description<int>(array1reversed)
    );
    // Done.
  }
}
