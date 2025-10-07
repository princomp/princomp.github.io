using System;
using System.Collections.Generic;

public class RBTree<T>
{
  private class Node
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
  }

  private Node root;

  public RBTree()
  {
    root = null;
  }

  public void Insert(T dataP)
  {
    root = Insert(dataP, root);
  }

  private Node Insert(T dataP, Node nodeP)
  {
    if (nodeP == null)
    {
      return new Node(dataP, null, null);
    }
    else
    {
      Random gen = new Random();
      if (gen.NextDouble() > 0.5)
      {
        nodeP.left = Insert(dataP, nodeP.left);
      }
      else
      {
        nodeP.right = Insert(dataP, nodeP.right);
      }
    }
    return nodeP;
  }
}
