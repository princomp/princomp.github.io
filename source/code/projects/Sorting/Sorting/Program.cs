using System;
using System.Collections.Generic;

class Program
{
  static void Main(string[] args)
  {
        List<int> test = new List<int>();
        Random gen = new Random();
        for (int i = 0; i < 20; i++)
        {
            test.Add(gen.Next(50));
        }
        Displaying<int>.DisplayHeader(test, 0, test.Count);
        Displaying<int>.Display(test);
        Sorting<int>.InsertionSort(test);

        test.Clear();
        for (int i = 0; i < 20; i++)
        {
            test.Add(gen.Next(50));
        }
        Sorting<int>.Heapsort(test);
    }
}
