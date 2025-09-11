using System;

class Program
{
  static void Main()
  {

        BSTree<int> btree = new BSTree<int>();
        Console.WriteLine(btree);

        btree.Insert(10);
        btree.Insert(11);
        btree.Insert(30);
        btree.Insert(7);
        Console.WriteLine(btree);
        btree.Insert(5);
        btree.Insert(12);
        btree.Insert(8);
        btree.Insert(15);

        Console.WriteLine(btree);
        Console.WriteLine("Smallest value: " + btree.FindMin());

        btree.Delete(btree.FindMin());
        Console.WriteLine(btree);
        Console.WriteLine("Smallest value: " + btree.FindMin());

        btree.Delete(btree.FindMin());
        Console.WriteLine(btree);
        Console.WriteLine("Smallest value: " + btree.FindMin());

        btree.Insert(-1);
        btree.Insert(-8);
        btree.Insert(-7);
        btree.Insert(-12);
        btree.Insert(-15);
        btree.Insert(-3);
        Console.WriteLine(btree);
        Console.WriteLine("Smallest value: " + btree.FindMin());

                for (int i = -10; i <= 10; i++)
        {
            Console.WriteLine(i + " occurs: " + btree.Find(i));
        }



    }
}
