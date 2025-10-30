using System;
using System.Collections.Generic;

public class PQueue<TPriority, TValue>
  where TPriority : IComparable<TPriority>
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
        if (IsEmpty())
            throw new ApplicationException(
              "Queue is empty, no most urgent value."
            );
        return mArray[1].Value;
    }

    public void Add(TPriority priorityP, TValue valueP)
    {
        if (IsFull())
            throw new ApplicationException(
              "Queue is full, cannot add "
                + valueP
                + " with priority "
                + priorityP
                + "."
            );

        // Otherwise, we will be able to add an element,
        // so count must increment.
        count++;
        // We now look for a place to insert the value,
        // we call it (empty) "slot".
        int slot = count;
        // As long as slot > 1 and priorityP is less than
        // the priority at slot / 2…
        while (
          slot > 1
          && priorityP.CompareTo(mArray[slot / 2].Priority) < 0
        )
        {
            mArray[slot] = mArray[slot / 2];
            slot /= 2;
            // We divide slot by 2
            // and move the data at slot / 2 at slot.
        }
        // Once this is done, we can insert the 
        // new value in the slot.
        mArray[slot] = new Cell(priorityP, valueP);
    }

    public TValue Extract()
    {
        if (IsEmpty())
            throw new ApplicationException(
              "Queue is empty, cannot extract from it."
            );

        // Save the data to be returned.
        TValue cellValue = mArray[1].Value;

        // Replace the root with the last element
        // on the last level.
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
        // Save the slot's cell.
        Cell travellingCell = mArray[indexP];

        bool found = false;
        // Keep going down the tree until the last level
        // or until we found the place where it belongs.
        while (indexP * 2 <= count && !found)
        {
            // Get the right child.
            child = indexP * 2;
            // Now, we check right and left child 
            // and put lowest one in the child variable
            if (child != count)
            { // If there is a left child…
                if (mArray[child + 1]
                        .Priority.CompareTo(mArray[child].Priority) < 0)
                {
                    // … and it has a lowest priority, use it.
                    child++;
                }
            }

            // At this point, we know that child
            // refers the child with the lowest
            // priority.

            // Now, we put the lowest child in slot
            // if its priority
            // is less than the priority of the cell
            // currently in the slot.
            if (
              mArray[child].Priority.CompareTo(travellingCell.Priority)
              < 0
            )
            {
                mArray[indexP] = mArray[child];
            }
            else
            {
                // Otherwise we are done.
                found = true;
            }
            // If we are not done,
            // we update the value for indexP.
            if (!found)
            {
                indexP = child;
            }
        }
        // found right spot of slot's original value, put it back into tree
        mArray[indexP] = travellingCell;
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
}
