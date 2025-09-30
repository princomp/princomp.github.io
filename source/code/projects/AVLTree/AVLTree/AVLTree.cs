using System;
using System.Collections.Generic;

public class AVLTree<T> where T : IComparable<T>
{
    private class Node
    {
        public T Data { get; set; }
        public Node left;
        public Node right;
        private int height;
        public int Height
        {
            get { return height; }
            set
            {
                if (value >= 0)
                    height = value;
                else
                    throw new ApplicationException("TreeNode height can't be < 0");
            }
        }

        public Node(T d = default(T), Node leftP = null, Node rightP = null, int heightP = 0)
        {
            Data = d;
            left = leftP;
            right = rightP;
            Height = heightP;
        }


        public override string ToString()
        {
            return Data.ToString();
        }
    }
    
    private Node root;
    
    public AVLTree()
    {
        root = null;
    }
    public void Clear()
    {
        root = null;
    }
    private int GetHeight(Node nodeP)
    {
        if (nodeP == null)
            return -1;
        else
            return nodeP.Height;
    }
    
    public void Insert(T valueP)
    {
        root = Insert(valueP, root);
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
    private Node RotateleftChild(Node nodeTop) // Aka left-left rotation
    {
        Node nodeLeft = nodeTop.left;
        nodeTop.left = nodeLeft.right;
        nodeLeft.right = nodeTop;
        
        // update heights
        nodeTop.Height = Math.Max(GetHeight(nodeTop.left), GetHeight(nodeTop.right)) + 1;
        nodeLeft.Height = Math.Max(GetHeight(nodeLeft.left), GetHeight(nodeTop)) + 1;
        
        return nodeLeft;  // attached to caller as the new top of this subtree
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
    private Node RotaterightChild(Node nodeTop) // Aka right-right rotation
    {
        Node nodeRight = nodeTop.right;
        nodeTop.right = nodeRight.left;
        nodeRight.left = nodeTop;
        
        // update heights
        nodeTop.Height = Math.Max(GetHeight(nodeTop.left), GetHeight(nodeTop.right)) + 1;
        nodeRight.Height = Math.Max(GetHeight(nodeRight.left), GetHeight(nodeTop)) + 1;
        
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

    private Node DoubleleftChild(Node nodeP)
    {
        nodeP.left = RotaterightChild(nodeP.left);
        return RotateleftChild(nodeP);
    }


    private Node DoublerightChild(Node nodeP)
    {
        nodeP.right = RotateleftChild(nodeP.right);
        return RotaterightChild(nodeP);
    }


    private Node Insert(T valueP, Node nodeP)
    {
        if (nodeP == null)
            return new Node(valueP, null, null, 0);
        else if (valueP.CompareTo(nodeP.Data) < 0) // valueP < nodeP.Data --> go left
        {
            nodeP.left = Insert(valueP, nodeP.left);
            if ((GetHeight(nodeP.left) - GetHeight(nodeP.right)) == 2)
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
            if ((GetHeight(nodeP.right) - GetHeight(nodeP.left)) == 2)
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
        else   // valueP == nodeP.Data
        {
            throw new ApplicationException("Tree did not insert " + valueP + " since an item with that value is already in the tree");
        }

        nodeP.Height = Math.Max(GetHeight(nodeP.left), GetHeight(nodeP.right)) + 1;
        return nodeP;
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
        // is not null, we take the max of their
        // depths to be the depth of the tree
        // starting with our current node.
        if (nodeP.left != null || nodeP.right != null)
        {
            result = Math.Max(depthL, depthR);
        }
        return result;
    }

    // The ToString method is simply here to help us debug.
    // It is not really pretty, but using pre-order and spaces
    // to make it easier to understand how the tree is
    // constructed. It also displays the depth of the tree
    // and the height of the nodes.

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
            returned += nodeP + " (depth: " + depth + ")\n"; // Calls Node's ToString method.
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
