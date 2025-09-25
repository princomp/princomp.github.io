using System;

class Program
{
    static void Main()
    {
        RBTree<int> btree = new RBTree<int>();
        btree.Insert(1);
        btree.Insert(2);
        btree.Insert(3);
        btree.Insert(4);
    }
}
