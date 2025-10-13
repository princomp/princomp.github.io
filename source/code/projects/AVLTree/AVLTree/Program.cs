using System;

class Program
{
  static void Main()
  {
    AVLTree<int> avltree1 = new AVLTree<int>();

        avltree1.Insert(10);
        avltree1.Insert(5);
        avltree1.Insert(4);
        avltree1.Insert(6);
        avltree1.Insert(20);
        Console.WriteLine(avltree1);
        avltree1.Insert(2);
        Console.WriteLine(avltree1);
        avltree1.Remove(5);
        Console.WriteLine(avltree1);
    }
}
