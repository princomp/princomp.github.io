using System;
using System.Collections.Generic;

public class AVLTree<T> : BTree<T> where T : IComparable<T>
{


    public override void Insert(T valueP)
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
            return new Node(valueP, null, null);
        else if (valueP.CompareTo(nodeP.Data) < 0) // valueP < nodeP.Data --> go left
        {
            nodeP.left = Insert(valueP, nodeP.left);
            int nodePLH = (nodeP.left == null) ? -1 : nodeP.left.Height;
            int nodePRH = (nodeP.right == null) ? -1 : nodeP.right.Height;

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
            int nodePLH = (nodeP.left == null) ? -1 : nodeP.left.Height;
            int nodePRH = (nodeP.right == null) ? -1 : nodeP.right.Height;
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
        else   // valueP == nodeP.Data
        {
            throw new ApplicationException("Tree did not insert " + valueP + " since an item with that value is already in the tree");
        }
        return nodeP;
    }

    public override bool Delete(T dataP)
    {
        throw new NotImplementedException();
    }

}
