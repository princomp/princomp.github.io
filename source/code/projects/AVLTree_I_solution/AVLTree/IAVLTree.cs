using System;
using System.Collections.Generic;

public class IAVLTree<T> : AVLTree<T>
  where T : IComparable<T>
{
  public int Depth(T valueP)
  {
    int depth = -1;
    if (root != null)
    {
      depth = Depth(valueP, root, 0);
    }
    return depth;
  }

  private int Depth(T valueP, Node nodeP, int depthP)
  {
    int returned = -1;
    if (nodeP != null)
    {
      if (valueP.CompareTo(nodeP.Data) < 0) // valueP < nodeP.Data --> go left
        returned = Depth(valueP, nodeP.left, depthP + 1);
      else if (valueP.CompareTo(nodeP.Data) > 0) // valueP > nodeP.Data --> go right
        returned = Depth(valueP, nodeP.right, depthP + 1);
      else
        returned = depthP;
    }
    return returned;
  }

  // Bonus question, override the Insert from AVLTree
  // so that it uses SubtreeBalance (not done).

  /*
  public override void Insert(T valueP)
  {
      // To be written
  }
  */

  /*
 * Bonus question: adding a ToString method
 * to IAVLTree. Cf. program.cs for the
 * demonstration.
 */

  public override string ToString()
  {
    return Stringify(root, "", false);
  }

  private string Stringify(
    Node nodeP,
    string indentP,
    bool leftP
  )
  {
    string returned = "";
    if (nodeP != null)
    {
      returned += indentP + "+--" + nodeP.Data + "\n";
      if (leftP)
      {
        indentP += "|  ";
      }
      else
      {
        indentP += "   ";
      }
      returned += Stringify(nodeP.left, indentP, true);
      returned += Stringify(nodeP.right, indentP, false);
    }
    return returned;
  }

  /*
   * Courtesy of https://gist.github.com/GeorgeHernandez/10dcbb5fd6ca8b087d169d5a44d72cd2:
   * Branch Connector        +   U+002B: PLUS SIGN
   * Horizontal Connector    -   U+002D: HYPHEN MINUS
   * Vertical Connector      |   U+007C: VERTICAL LINE
   */
}
