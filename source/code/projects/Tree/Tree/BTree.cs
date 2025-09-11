using System;
using System.Collections.Generic;

public class BTree<T> where T : IComparable<T>
{
    protected class Node
    {
        public T Data { get; set; }
        public Node left;
        public Node right;
        public Node(T dataP = default(T), Node leftP = null, Node rightP = null)
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
        int result = depth;
        int depthL = 0;
        if (nodeP.left != null)
        {
            depthL = Depth(nodeP.left, result + 1);
        }
        int depthR = 0;
        if (nodeP.right != null)
        {
            depthR = Depth(nodeP.right, result + 1);
        }
        if (nodeP.left != null || nodeP.right != null)
        {
            result = Math.Max(depthL, depthR);
        }
        return result;

    }
}
