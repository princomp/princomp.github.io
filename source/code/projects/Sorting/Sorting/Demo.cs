using System;
using System.Collections.Generic;

static class Demo
{
    private const int LIST_SIZE = 30;

    public static void Run(Action<List<int>> sortingAlgo)
    {
        List<int> test = new List<int>();
        Random gen = new Random();
        for (int i = 0; i < LIST_SIZE; i++)
        {
            test.Add(gen.Next(50));
        }
        Displaying<int>.List(test);
        sortingAlgo(test);
        Displaying<int>.After(test);
    }

    public static void Run(Action<List<char>> sortingAlgo)
    {
        List<char> test = new List<char>();
        Random gen = new Random();

        for (int i = 0; i < LIST_SIZE; i++)
        {
            test.Add((char)(gen.Next(33, 127)));
        }
        Displaying<char>.List(test);
        sortingAlgo(test);
        Displaying<char>.After(test);
    }


}
