using System;
using System.Collections.Generic;

public abstract class IBTree<T> : BTree<T>
  where T : IComparable<T>
{
  protected int SubtreeBalance(Node nodeP)
  {
    // Will return
    // a negative number if subtree is right-heavy
    // a positive number if subtree is left-heavy
    // 0 if the subtree is perfectly balanced.
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
}
