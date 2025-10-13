using System;
using System.Collections.Generic;

public abstract class BTree<T>
  where T : IComparable<T>
{
  // We begin by defining a node class.
  protected class Node
  {
    public T Data { get; set; }
    public Node left;
    public Node right;

    public Node(
      T dataP = default(T),
      Node leftP = null,
      Node rightP = null
    )
    {
      Data = dataP;
      left = leftP;
      right = rightP;
    }

    // Displaying a Node is only
    // displaying its data.
    public override string ToString()
    {
      return Data.ToString();
    }

    public int Height
    {
      get
      {
        int height = 0;
        if (left != null && right != null)
        {
          height = Math.Max(left.Height, right.Height) + 1;
        }
        else if (left != null)
        {
          height = left.Height + 1;
        }
        else if (right != null)
        {
          height = right.Height + 1;
        }
        // The last case is if both children
        // are null, in which case the height
        // remains 0.
        return height;
      }
    }
  }

  // We can now define the BTree class
  // using this notion of nodes.

  // Constructor, Clear and IsEmpty
  // are relying on the root Node.
  protected Node root;

  public BTree()
  {
    root = null;
  }

  public void Clear()
  {
    root = null;
  }

  public bool IsEmpty()
  {
    return root == null;
  }

  // We now look at how to
  // compute the height of a tree.
  // Remember that the height
  // of a tree is the height of
  // its root node.
  public int Height()
  {
    int height = 0;
    if (root != null)
    {
      height = root.Height;
    }
    return height;
  }

  // Finding is also recursive.

  public virtual bool Find(T dataP)
  {
    bool found = false;
    if (root != null)
    {
      found = Find(dataP, root);
    }
    return found;
  }

  private bool Find(T dataP, Node nodeP)
  {
    bool found = false;
    if (nodeP != null)
    {
      if (nodeP.Data.Equals(dataP))
      {
        found = true;
      }
      else
      {
        found =
          Find(dataP, nodeP.left)
          || Find(dataP, nodeP.right);
      }
    }
    return found;
  }

  // Done with finding.

  /* Traversal methods. */
  // Inorder traversal
  // "Left, data, right"
  public string TrasverseI()
  {
    string returned = "";
    if (root != null)
    {
      returned += TraverseI(root);
    }
    return returned;
  }

  private string TraverseI(Node nodeP)
  {
    string returned = "";
    if (nodeP != null)
    {
      returned += TraverseI(nodeP.left);
      returned += nodeP.Data + " ";
      returned += TraverseI(nodeP.right);
    }
    return returned;
  }

  // Preorder traversal
  // "Data, left, right"
  public string TrasversePr()
  {
    string returned = "";
    if (root != null)
    {
      returned += TraversePr(root);
    }
    return returned;
  }

  private string TraversePr(Node nodeP)
  {
    string returned = "";
    if (nodeP != null)
    {
      returned += nodeP.Data + " ";
      returned += TraversePr(nodeP.left);
      returned += TraversePr(nodeP.right);
    }
    return returned;
  }

  // Postorder traversal
  // "Left, right, data"
  public string TrasversePo()
  {
    string returned = "";
    if (root != null)
    {
      returned += TraversePo(root);
    }
    return returned;
  }

  private string TraversePo(Node nodeP)
  {
    string returned = "";
    if (nodeP != null)
    {
      returned += TraversePo(nodeP.left);
      returned += TraversePo(nodeP.right);
      returned += nodeP.Data + " ";
    }
    return returned;
  }

  /* Done with traversal methods. */

  public abstract void Insert(T dataP);
  public abstract bool Delete(T dataP);

  // The ToString method is simply here to help us debug.
  // It is not really pretty, but using pre-order and spaces
  // to make it easier to understand how the tree is
  // constructed. It also displays the height of the tree.

  public override string ToString()
  {
    string returned = "Tree height: " + Height() + "\n";
    int tBalance = SubtreeBalance(root);
    returned += "Tree balance: " + tBalance;
    if (tBalance <= -2)
    {
      returned += " (Right-heavy)";
    }
    else if (tBalance >= 2)
    {
      returned += " (Left-heavy)";
    }
    returned += "\n";

    if (root != null)
    {
      returned += Stringify(root, 0);
    }
    return returned;
  }

  private string Stringify(Node nodeP, int height)
  {
    string returned = "";
    if (nodeP != null)
    {
      for (int i = 0; i < height; i++)
      {
        returned += " ";
      }
      returned += nodeP + "\n"; // Calls Node's ToString method.
      if (nodeP.left != null)
      {
        returned +=
          "L"
          + " (h: "
          + nodeP.left.Height
          + ")"
          + Stringify(nodeP.left, height + 1);
      }
      if (nodeP.right != null)
      {
        returned +=
          "R"
          + " (h: "
          + nodeP.right.Height
          + ")"
          + Stringify(nodeP.right, height + 1);
      }
    }
    return returned;
  }

  protected int SubtreeBalance(Node nodeP)
  {
    // Will return
    // a negative number if subtree is right-heavy
    // a positive number if subtree is left-heavy
    // 0 if the subtree is perfectly balanced.
    // The AVL tree will need to be re-balanced if the value
    // returned is greater than or equal to 2, or
    // less than or equal to -2.
    // Stated differently, if the value returned is
    // -1, 0 or 1, then no re-balancing will take place.
    int balance;
    if (nodeP == null)
    {
      balance = 0;
    }
    else if (nodeP.left == null && nodeP.right == null)
    {
      balance = 0;
    }
    else if (nodeP.left == null)
    {
      balance = -(nodeP.right.Height + 1);
    }
    else if (nodeP.right == null)
    {
      balance = nodeP.left.Height + 1;
    }
    else
    {
      balance = nodeP.left.Height - nodeP.right.Height;
    }
    return balance;
  }

  /*
   * Before
   *   nodeTop --> A
   *              / \
   * nodeLeft--> B   C
   *            / \
   *           D   E <-- nodeLeft.right
   *
   * After
   *             B
   *            / \
   *           D   A
   *              / \
   *             E   C
   */
  protected Node RotateleftChild(Node nodeTop) // Aka left-left rotation
  {
    Node nodeLeft = nodeTop.left;
    nodeTop.left = nodeLeft.right;
    nodeLeft.right = nodeTop;
    return nodeLeft; // attached to caller as the new top of this subtree
  }

  /*
  * Before
  *     nodeTop --> A
  *                / \
  *               B   C <-- nodeRight
  *                  / \
  *                 D   E
  *
  * After
  *           C
  *          / \
  *         A   E
  *        / \
  *       B   D
  */
  protected Node RotaterightChild(Node nodeTop) // Aka right-right rotation
  {
    Node nodeRight = nodeTop.right;
    nodeTop.right = nodeRight.left;
    nodeRight.left = nodeTop;
    return nodeRight; // attached to caller as the new top of this subtree
  }

  /*
* Before
*     nodeP -->  A
*              /   \
*             B     C
*            / \   / \
*           D   E F   G
*
* After RotaterightChild
*           A
*          / \
*         E   C
*        /   / \
*       B   F   G
*      /
*     D
*
* After
*           E
*          / \
*         B   A
*        /     \
*       D       C
*              / \
*             F   G
*/

  protected Node DoubleleftChild(Node nodeP)
  {
    nodeP.left = RotaterightChild(nodeP.left);
    return RotateleftChild(nodeP);
  }

  protected Node DoublerightChild(Node nodeP)
  {
    nodeP.right = RotateleftChild(nodeP.right);
    return RotaterightChild(nodeP);
  }

  // Helper methods, to demonstrate
  // tree rotations.
  public void Doubleleft()
  {
    if (root != null)
    {
      root = DoubleleftChild(root);
    }
  }

  public void Doubleright()
  {
    if (root != null)
    {
      root = DoublerightChild(root);
    }
  }

  public void Rotateright()
  {
    if (root != null)
    {
      root = RotaterightChild(root);
    }
  }

  public void Rotateleft()
  {
    if (root != null)
    {
      root = RotateleftChild(root);
    }
  }
}
