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
    // We illustrate another way of computing the 
    // height of the tree, as the depth of the 
    // deepest node.

    public int HeightAlt()
    {
        int height = 0;
        if (root != null)
        {
            height = Depth(root);
        }
        return height;
    }

    private int Depth(Node nodeP)
    {
        // We first assume that the Depth of
        // nodeP is 0.
        int result = 0;
        // Then, we compute the depth of
        // its left subtree, if it is not null.
        int depthL = 0;
        if (nodeP.left != null)
        {
            depthL = 1 + Depth(nodeP.left);
        }
        // We proceed similarly for the
        // left sub-tree.
        int depthR = 0;
        if (nodeP.right != null)
        {
            depthR = 1 + Depth(nodeP.right);
        }
        // Finally, if at least one sub-tree
        // is not null, we take the max of their
        // depths to be the depth of nodeP.
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
  // constructed.

  public override string ToString()
  {
    string returned = "Height of the tree:" + Height() + " (computed alternatively: " + HeightAlt() + ")\n";
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
