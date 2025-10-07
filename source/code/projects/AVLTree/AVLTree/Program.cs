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

        Console.WriteLine("Is 7 in tree: " + test.Remove(7));
        Console.WriteLine("Is 7 in tree: " + test.Remove(7));
        Console.WriteLine(test);

    }
}
