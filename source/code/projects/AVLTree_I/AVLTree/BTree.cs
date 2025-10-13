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
}
