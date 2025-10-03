using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Test");
        AVLTree<int> test = new AVLTree<int>();
        for (int i = 1; i <= 100; i++)
        {
            test.Insert(i);
        }
        Console.WriteLine(test);

    }
}
