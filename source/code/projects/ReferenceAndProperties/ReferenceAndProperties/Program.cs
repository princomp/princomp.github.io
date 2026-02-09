using System;

class Program
{
  static void Main(string[] args)
  {
    int[] values = { 1, 2, 3 };
    int value = 0;
    Demo test = new Demo(values, value);

    Console.WriteLine(test.Value);
    for (int i = 0; i < test.Values.Length; i++)
    {
      Console.WriteLine(test.Values[i]);
    }

    // test.Value = 10;
    // error CS0200: Property or indexer 'Demo.Value' cannot be assigned to -- it is read only
    Console.WriteLine(test.Value);
    // still displays "0"
    test.Values[0] = 10;
    // This works!
    for (int i = 0; i < test.Values.Length; i++)
    {
      Console.WriteLine(test.Values[i]);
    }
    // Now displays
    // 10
    // 2
    // 3
  }
}
