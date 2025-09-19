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

    public override string ToString()
    {
      return "| " + Data.ToString() + " |";
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
  // compute the Depth of a tree.

  public int Depth()
  {
    int depth = 0;
    if (root != null)
    {
      depth = Depth(root, 0);
    }
    return depth;
  }

  private int Depth(Node nodeP, int depth)
  {
    // "Unless proven otherwise",
    // we assume that the depth of the
    // node is the depth it received
    // as argument.
    int result = depth;
    // We assume the depth of
    // its right sub-tree
    // is 0.
    int depthL = 0;
    if (nodeP.left != null)
    {
      // If its left sub-tree is not null,
      // we inquire about its depth,
      // knowing that it will be 1 more
      // than the depth of the current node.
      depthL = Depth(nodeP.left, result + 1);
    }
    // We proceed similarly for the
    // left sub-tree.
    int depthR = 0;
    if (nodeP.right != null)
    {
      depthR = Depth(nodeP.right, result + 1);
    }
    // Finally, if at least one sub-tree
    // is not null, we take their max to
    // be the depth of the tree starting
    // with our current node.
    if (nodeP.left != null || nodeP.right != null)
    {
      result = Math.Max(depthL, depthR);
    }
    return result;
  }

  // Finding is also recursive.

  public virtual bool Find(T dataP)
  {
    bool found = false;
    if (root != null)
    {
      found = Find(root, dataP);
    }
    return found;
  }

  private bool Find(Node nodeP, T dataP)
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
          Find(nodeP.left, dataP)
          || Find(nodeP.right, dataP);
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

  // The ToString method is simply here to help debug.

  public override string ToString()
  {
    string returned = "Depth: " + Depth() + "\n";
    if (root != null)
    {
      returned += Stringify(root, 0);
    }
    return returned;
  }

  private string Stringify(Node nodeP, int depth)
  {
    string returned = "";
    if (nodeP != null)
    {
      for (int i = 0; i < depth; i++)
      {
        returned += " ";
      }
      returned += nodeP + "\n"; // Calls Node's ToString method.
      if (nodeP.left != null)
      {
        returned += "L" + Stringify(nodeP.left, depth + 1);
      }
      if (nodeP.right != null)
      {
        returned += "R" + Stringify(nodeP.right, depth + 1);
      }
    }
    return returned;
  }
}
