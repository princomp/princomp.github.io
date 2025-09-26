using System;

class Program
{
  static void Main()
  {
    BSTree<int> btree = new BSTree<int>();
    Console.WriteLine(btree);

    /*
* The purpose of this example is to illustrate that
* the order in which values are inserted matter.
*/
    btree.Clear();
    btree.Insert(10);
    btree.Insert(6);
    btree.Insert(13);
    btree.Insert(12);
    btree.Insert(14);
    Console.WriteLine(btree);
    btree.Clear();
    btree.Insert(14);
    btree.Insert(12);
    btree.Insert(13);
    btree.Insert(6);
    btree.Insert(10);
    Console.WriteLine(btree);

    /* Second example, we begin by clearing the tree. */

    btree.Clear();
    btree.Insert(10);
    // Attempting to insert the same value
    // twice raises an exception:
    try
    {
      btree.Insert(10);
    }
    catch (Exception e)
    {
      Console.WriteLine(e.Message);
    }
    btree.Insert(11);
    btree.Insert(30);
    btree.Insert(7);
    Console.WriteLine(btree);
    btree.Insert(5);
    btree.Insert(12);
    btree.Insert(8);
    btree.Insert(15);

    Console.WriteLine(btree);
    Console.WriteLine("Inorder traversal:");
    Console.WriteLine(btree.TrasverseI());
    Console.WriteLine("Preorder traversal:");
    Console.WriteLine(btree.TrasversePr());
    Console.WriteLine("Postorder traversal:");
    Console.WriteLine(btree.TrasversePo());

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
