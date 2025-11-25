using System;
using System.Collections.Generic;

public class AVLTree<T> : BSTree<T>
  where T : IComparable<T>
{
  public override void Insert(T valueP)
  {
    root = Insert(valueP, root);
  }

  private Node Insert(T valueP, Node nodeP)
  {
    if (nodeP == null)
      return new Node(valueP, null, null);
    else if (valueP.CompareTo(nodeP.Data) < 0) // valueP < nodeP.Data --> go left
    {
      nodeP.left = Insert(valueP, nodeP.left);
      int nodePLH =
        (nodeP.left == null) ? -1 : nodeP.left.Height;
      int nodePRH =
        (nodeP.right == null) ? -1 : nodeP.right.Height;

      if (nodePLH - nodePRH == 2)
      {
        if (valueP.CompareTo(nodeP.left.Data) < 0)
        {
          nodeP = RotateleftChild(nodeP);
        }
        else
        {
          nodeP = DoubleleftChild(nodeP);
        }
      }
    }
    else if (valueP.CompareTo(nodeP.Data) > 0) // valueP > nodeP.Data --> go right
    {
      nodeP.right = Insert(valueP, nodeP.right);
      int nodePLH =
        (nodeP.left == null) ? -1 : nodeP.left.Height;
      int nodePRH =
        (nodeP.right == null) ? -1 : nodeP.right.Height;
      if (nodePRH - nodePLH == 2)
      {
        if (valueP.CompareTo(nodeP.right.Data) > 0)
        {
          nodeP = RotaterightChild(nodeP);
        }
        else
        {
          nodeP = DoublerightChild(nodeP);
        }
      }
    }
    else // valueP == nodeP.Data
    {
      throw new ApplicationException(
        "Tree did not insert "
          + valueP
          + " since an item with that value is already in the tree"
      );
    }
    return nodeP;
  }

  public override bool Delete(T dataP)
  {
    return Delete(dataP, ref root);
  }

  private bool Delete(T value, ref Node nodeP)
  {
    bool found = false;
    if (nodeP != null)
    {
      if (value.CompareTo(nodeP.Data) < 0) // value < nodeP.Data, check left subtree
      {
        found = Delete(value, ref nodeP.left); // similar to BST's find and remove method
        if (SubtreeBalance(nodeP) <= -2) // negative balance means heavy on right side
        {
          if (SubtreeBalance(nodeP.right) <= 0) // children in straight line
            nodeP = RotaterightChild(nodeP); //  rotate middle up to balance
          else
            nodeP = DoublerightChild(nodeP); // children in zig patter - needs double rotate to balance
        }
      }
      else if (value.CompareTo(nodeP.Data) > 0) // value > nodeP.Data, check right subtree
      {
        found = Delete(value, ref nodeP.right);
        if (SubtreeBalance(nodeP) >= 2)
        {
          if (SubtreeBalance(nodeP.left) >= 0)
            nodeP = RotateleftChild(nodeP);
          else
            nodeP = DoubleleftChild(nodeP);
        }
      }
      else // The value was found!
      {
        found = true;
        if (nodeP.left != null && nodeP.right != null) // Two children
        {
          nodeP.Data = FindMin(nodeP.right);
          Delete(nodeP.Data, ref nodeP.right);
          if (SubtreeBalance(nodeP) == 2) // Need to rebalance
          {
            if (SubtreeBalance(nodeP.left) >= 0)
              nodeP = RotateleftChild(nodeP);
            else
              nodeP = DoubleleftChild(nodeP);
          }
        }
        else
        {
          nodeP = nodeP.left ?? nodeP.right; // replace with one or no child
          // This is equivalent to
          // if (nodeP.left == null){
          //     nodeP = nodeP.right;
          // } else { nodeP = nodeP.left;}
          // Observe that if both are null, then nodeP simply
          // becomes null, as expected.
        }
      }
    }
    return found;
  }
}
