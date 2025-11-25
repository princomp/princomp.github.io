using System;

class Program
{
  static void Main()
  {
    /*
     * First question, illustrating
     * Rotateright and Doubleright.
     */

    Console.WriteLine(
      "****************\n* Question 1   *\n****************\n"
    );

    Console.WriteLine(
      "This is the tree we will be using in our examples:"
    );
    BSTree<int> bstree1 = new BSTree<int>();
    bstree1.Insert(10);
    bstree1.Insert(15);
    Console.WriteLine(bstree1);
    /*
     *  10
     *   \
     *    15
     */

    Console.WriteLine(
      "If we insert 20, it becomes right-heavy \"in a straight-line\":"
    );
    bstree1.Insert(20);

    Console.WriteLine(bstree1);

    /*
     *   10
     *    \
     *    15
     *      \
     *      20
     */
    Console.WriteLine(
      "Applying Rotateright to the root gives:"
    );
    bstree1.Rotateright();
    Console.WriteLine(bstree1);

    /*
     *     15
     *    /  \
     *   10   20
     */

    bstree1.Clear();

    Console.Write("Going back to our original example,");
    bstree1.Insert(10);
    bstree1.Insert(15);
    Console.WriteLine(
      "if we insert 13, it becomes right-heavy \"in a zig-zag line\":"
    );
    bstree1.Insert(13);
    Console.WriteLine(bstree1);
    /*
     *  10
     *    \
     *    15
     *    /
     *  13
     */
    Console.WriteLine(
      "Applying Doubleright to the root gives:"
    );
    bstree1.Doubleright();
    Console.WriteLine(bstree1);
    /*
     *    13
     *   /  \
     * 10   15
     */

    /*
     * Second question, creating a BSTree tree object that is "overall” balanced,
     * but that has sub-tree(s) with a balance greater than or equal to 2 or less
     * than or equal to -2.
     */
    Console.WriteLine(
      "****************\n* Question 2   *\n****************\n"
    );

    BSTree<int> bstree2 = new BSTree<int>();
    bstree2.Insert(1);
    bstree2.Insert(2);
    bstree2.Insert(3);
    /*
     * 1
     *  \
     *   2
     *    \
     *     3
     */
    Console.WriteLine(bstree2);
    // This tree has balance -2.
    bstree2.Clear();
    bstree2.Insert(-1);
    bstree2.Insert(-2);
    bstree2.Insert(-3);
    /*
     *      -1
     *      /
     *     -2
     *    /
     *   -3
     */
    Console.WriteLine(bstree2);
    // This tree has balance 2.
    bstree2.Clear();
    bstree2.Insert(0);
    bstree2.Insert(1);
    bstree2.Insert(2);
    bstree2.Insert(3);
    bstree2.Insert(-1);
    bstree2.Insert(-2);
    bstree2.Insert(-3);
    /*
     *        0
     *       / \
     *     -1   1
     *     /     \
     *   -2       2
     *   /         \
     * -3           3
     *
     */
    Console.WriteLine(bstree2);
    // This tree has balance 0,
    // but it contains two sub-trees
    // (at node -1 and 1) that have
    // balance 2 and -2.

    /*
* Third question, IAVLTree class
* with Depth method.
* The Depth method is in the IAVLTree.cs file,
* we demonstrate it below.
*/
    Console.WriteLine(
      "****************\n* Question 3   *\n****************\n"
    );

    IAVLTree<int> avlt1 = new IAVLTree<int>();
    Random seed = new Random();
    int rnumber; // Used to store random number generate.
    int inserted = 0; // Number of values inserted so far.
    while (inserted < 10)
    {
      rnumber = seed.Next(0, 50);
      Console.Write("Inserting " + rnumber + ".\n");
      try
      {
        avlt1.Insert(rnumber);
        inserted++; // Insertion successful.
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
    Console.WriteLine("This is the tree obtained:");
    /*
     * Bonus question: adding a ToString method
     * to IAVLTree. Cf. IAVLtree.cs for the code,
     * we demonstrate it below.
     */
    Console.WriteLine(avlt1);

    bool valid = false;
    int nentered;
    do
    {
      Console.WriteLine(
        "Enter a value whose depth you'd like to know."
      );
      valid = int.TryParse(
        Console.ReadLine(),
        out nentered
      );
    } while (!valid);

    Console.WriteLine(
      "The value you entered has this depth:"
    );
    Console.WriteLine(avlt1.Depth(nentered));
  }
}
