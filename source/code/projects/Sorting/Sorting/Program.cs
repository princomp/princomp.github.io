using System;
using System.Collections.Generic;

class Program
{
  static void Main(string[] args)
  {
    Demo.Run(Sorting<int>.InsertionSort);
    Demo.Run(Sorting<char>.InsertionSort);
    Demo.Run(Sorting<int>.Heapsort);
    Demo.Run(Sorting<char>.Heapsort);

    Demo.Run(Sorting<int>.BubbleSort);
    Demo.Run(Sorting<char>.BubbleSort);

    Demo.Run(Sorting<int>.ShellSort);
    Demo.Run(Sorting<char>.ShellSort);

    Demo.Run(Sorting<int>.QuickSort);
    Demo.Run(Sorting<char>.QuickSort);
    }
}
