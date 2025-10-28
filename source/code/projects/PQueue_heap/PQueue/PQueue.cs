using System;
using System.Collections.Generic;

public class PQueue<TPriority, TValue> where TPriority : IComparable<TPriority>
{

    class Cell
    {
        public TPriority Priority { get; set; }
        public TValue Value { get; set; }
        public Cell(TPriority priorityP, TValue valueP)
        {
            Priority = priorityP;
            Value = valueP;
        }
        public override string ToString()
        {
            return Value + " (priority: " + Priority + ")";
        }
    }

    private Cell[] mArray;
   // Number of items in queue.
    private int count = 0;

    public PQueue(int size = 100)
    {
        if (size < 10)
            size = 10;
        mArray = new Cell[size];
    }

    public bool IsEmpty()
    {
        return count == 0;
    }

    public bool IsFull()
    {
        return (count == mArray.Length - 1);
    }

    public void Clear()
    {
        count = 0;
    }

    public TValue Peek()
    {
        if (IsEmpty()) throw new ApplicationException("Queue is empty, no most urgent value.");
        return mArray[1].Value;
    }

    public void Add(TPriority priorityP, TValue valueP)
    {
        if (IsFull()) throw new ApplicationException("Queue is full, cannot add " + valueP + " with priority " + priorityP + ".");

        // Otherwise, we will be able to add an element, 
        // so count must increment.
        count++;
        // We now look for a place to insert the value.
        int hole = count;
        // As long as hole > 1 and priorityP is less than
        // the priority at hole / 2…
        while(hole > 1 && priorityP.CompareTo(mArray[hole / 2].Priority) < 0)
        {
            mArray[hole] = mArray[hole / 2];
            hole /= 2;
            // We divide hole by 2 
            // and move the data at hole / 2 at hole.
        }
        // Once this is done, we can insert the new value.
        mArray[hole] = new Cell(priorityP, valueP);
    }

    public TValue Extract()
    {
        if (IsEmpty())
            throw new ApplicationException("Queue is empty, cannot extract from it.");

        // Save the data to be returned.
        TValue cellValue = mArray[1].Value;

        // Move the "rightmost" cell from the 
        // last level to the root.
        mArray[1] = mArray[count];
        // We have one less element now.
        count--;

        // Move the lowest child up until we've found the right spot 
        // for the cell moved from the last level to the root.
        PercolateDown(1);
        return cellValue;
    }

    private void PercolateDown(int indexP)
    {
        // "PercolateDown", starting at 
        // indexP.
        int child;
        // Save the hole's cell.
        Cell cellValue = mArray[indexP];

        bool found = false;
        // Keep going down the tree until the last level
        while(indexP * 2 <= count && !found)
        {
            child = indexP * 2;   // get right child
                                  // check right and left child and put lowest one in the child variable
            if (child != count && mArray[child + 1].Priority.CompareTo(mArray[child].Priority) < 0)
            {
                child++;
            }
            // put lowest child in hole
            if (mArray[child].Priority.CompareTo(cellValue.Priority) < 0)
            {
                mArray[indexP] = mArray[child];
            }
            else
            {
                found = true;
            }
            // If we are not done, 
            // we update the value for indexP.
            if (!found) { indexP = child; }
        }
        // found right spot of hole's original value, put it back into tree
        mArray[indexP] = cellValue;
    }

    /// <summary>
    /// Assumes all but last item in array is in correct order
    /// Shifts last item in array into correct location based on priority
    /// </summary>
    public void BuildHeap()
    {
        for (int i = count / 2; i > 0; i--)
            PercolateDown(i);
    }

    public override string ToString()
    {
        string returned = "";
        for (int i = 1; i <= count; i++)
        {
            returned += mArray[i].ToString() + "; ";
        }
        return returned;
    }

    // return string with contents of array in order (e.g. left child, parent, right child)
    public string InOrder()
    {
        return InOrder(1);
    }
    private string InOrder(int position)
    {
        string returned = "";
        if (position <= count)
        {
           returned += (position * 2) + "\t";
            returned +=  mArray[position].Value.ToString() + "\n ";
            returned +=  InOrder(position * 2 + 1) + "\t";
        }
        return returned;
    }
}