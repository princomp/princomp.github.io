using System;

class Program
{
  static void Main()
  {
    Console.WriteLine(
      "This is the tree we will be using in our examples:"
    );
    BSTree<int> bstree1 = new BSTree<int>();
    bstree1.Insert(10);
    bstree1.Insert(5);
    bstree1.Insert(4);
    bstree1.Insert(6);
    bstree1.Insert(20);

    Console.WriteLine(bstree1);

    Console.WriteLine(
      "If we insert 2, it becomes left-heavy \"in a straight-line\":"
    );
    bstree1.Insert(2);
    Console.WriteLine(bstree1);

    Console.WriteLine(
      "Applying RotateleftChild to the root gives:"
    );
    bstree1.Rotateleft();
    Console.WriteLine(bstree1);

    bstree1.Clear();

    Console.Write("Going back to our original example,");
    bstree1.Insert(10);
    bstree1.Insert(5);
    bstree1.Insert(4);
    bstree1.Insert(6);
    bstree1.Insert(20);
    Console.WriteLine(
      "if we insert 7, it becomes left-heavy \"in a zig-zag line\":"
    );
    bstree1.Insert(7);
    Console.WriteLine(bstree1);

    Console.WriteLine(
      "Applying DoubleleftChild to the root gives:"
    );
    bstree1.Doubleleft();
    Console.WriteLine(bstree1);
  }
}
