using System;
using System.Collections.Generic;

public class BSTree<T> : BTree<T>
  where T : IComparable<T>
{
  // Inserting into a BSTree
  public override void Insert(T dataP)
  {
    root = Insert(dataP, root);
  }

  private Node Insert(T dataP, Node nodeP)
  {
    if (nodeP == null)
    {
      return new Node(dataP, null, null);
    }
    else if (dataP.CompareTo(nodeP.Data) < 0) // dataP < nodeP.Data
    {
      nodeP.left = Insert(dataP, nodeP.left);
    }
    else if (dataP.CompareTo(nodeP.Data) > 0) // dataP > nodeP.Data
    {
      nodeP.right = Insert(dataP, nodeP.right);
    }
    else
    {
      throw new ApplicationException(
        "Value " + dataP + " already in tree."
      );
    }
    return nodeP;
  }

  // Finding into a BSTree

  public override bool Find(T dataP)
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
        if (dataP.CompareTo(nodeP.Data) < 0) // dataP < nodeP.Data
        {
          found = Find(dataP, nodeP.left);
        }
        else if (dataP.CompareTo(nodeP.Data) > 0) // dataP > nodeP.Data
        {
          found = Find(dataP, nodeP.right);
        }
      }
    }
    return found;
  }

  public T FindMin()
  {
    if (root == null)
    {
      throw new ApplicationException(
        "Cannot find a value in an empty tree!"
      );
    }
    else
    {
      return FindMin(root);
    }
  }

  protected T FindMin(Node nodeP)
  {
    T minValue;
    if (nodeP.left == null)
    {
      minValue = nodeP.Data;
    }
    else
    {
      minValue = FindMin(nodeP.left);
    }
    return minValue;
  }

  // Deleting from a BSTree

  public override bool Delete(T dataP)
  {
    return Delete(dataP, ref root);
  }

  private bool Delete(T dataP, ref Node nodeP)
  {
    bool found = false;
    if (nodeP != null)
    {
      if (dataP.CompareTo(nodeP.Data) < 0) // dataP < nodeP.Data
      {
        found = Delete(dataP, ref nodeP.left);
      }
      else if (dataP.CompareTo(nodeP.Data) > 0) // dataP > nodeP.Data
      {
        found = Delete(dataP, ref nodeP.right);
      }
      else // We found the value!
      {
        found = true;
        if (nodeP.left != null && nodeP.right != null)
        {
          nodeP.Data = FindMin(nodeP.right);
          Delete(nodeP.Data, ref nodeP.right);
          // Or we could replace with the largest
          // value in the left subtree.
        }
        else
        {
          if (nodeP.left != null)
          {
            nodeP = nodeP.left;
          }
          else
          {
            nodeP = nodeP.right;
          }
        }
      }
    }
    return found;
  }

  // Done with deletion.
}
