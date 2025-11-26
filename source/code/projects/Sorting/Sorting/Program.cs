using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insertion sort:");
        Demo.Run(Sorting<int>.InsertionSort);
        Demo.Run(Sorting<char>.InsertionSort);

        Console.WriteLine("Heap sort:");
        Demo.Run(Sorting<int>.Heapsort);
        Demo.Run(Sorting<char>.Heapsort);

        Console.WriteLine("Bubble sort:");
        Demo.Run(Sorting<int>.BubbleSort);
        Demo.Run(Sorting<char>.BubbleSort);

        Console.WriteLine("Shell sort:");
        Demo.Run(Sorting<int>.ShellSort);
        Demo.Run(Sorting<char>.ShellSort);

        Console.WriteLine("Quick sort:");
        Demo.Run(Sorting<int>.QuickSort);
        Demo.Run(Sorting<char>.QuickSort);

        Console.WriteLine("Selection sort:");
        Demo.Run(Sorting<int>.SelectionSort);
        Demo.Run(Sorting<char>.SelectionSort);
    }
}
