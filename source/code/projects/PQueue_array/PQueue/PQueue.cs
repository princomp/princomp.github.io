using System; // This is required for the exception.

class PQueue<TPriority, TValue> where TPriority : IComparable<TPriority>
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
    public PQueue(int sizeP = 10)
    {
        mArray = new Cell[sizeP];
    }
    public void Add(TPriority priorityP, TValue valueP)
    {
        // slot is the index where we will add the element
        int slot = -1;
        // index is where we are currently looking for
        // a slot in the arry.
        int index = 0;
        while (index < mArray.Length && slot == -1)
        {
            if (mArray[index] == null)
            {
                slot = index;
            }
            else
            {
                index++;
            }
        }
        if (slot == -1)
        {
            throw new ApplicationException("Queue is full, cannot add " + valueP + " with priority " + priorityP + ".");
        }
        else
        {
            mArray[slot] = new Cell(priorityP, valueP);
        }
    }

    public int MinPriority()
    {
        int index = 0;
        // We begin by looking for a value 
        // in mArray that is not null.
        bool notNull = false;
        while (index < mArray.Length && !notNull)
        {
            if (mArray[index] != null)
            {
                // We found a value that is not null.
                notNull = true;
            }
            else
            {
                index++;
            }
        }
        // If we exit and notNull is still false,
        // it means there is no non-null cell in
        // the array.
        if (!notNull)
        {
            throw new ApplicationException("Queue is empty, no index with minimal priority.");
        }
        // Minimal priority found "so far".
        TPriority minP = mArray[index].Priority;
        // Index of the minimal priority found "so far".
        int minI = index;
        while (index < mArray.Length)
        {
            // The following if is crucial: there may 
            // be null values in the array, and we should
            // not try to access the Priority property
            // if mArray[index] is null.
            if (mArray[index] != null)
            {
                // If we found a lower priority, 
                // we update the minP and minI 
                // values.
                if (mArray[index].Priority.CompareTo(minP) < 0)
                {
                    minP = mArray[index].Priority;
                    minI = index;
                }
            }
            index++;
        }
        return minI;
    }

    public TValue Peek()
    {
        // Looking at the most urgent Cell
        // uses MinPriority.
        return mArray[MinPriority()].Value;
    }

    public string Extract()
    {
        // Removing the most urgent Cell
        // relies also on MinPriority().
        int minE = MinPriority();
        Cell cellE = mArray[minE];
        mArray[minE] = null;
        return cellE.ToString();
    }

    public override string ToString()
    {
        string ret = "";
        for (int i = 0; i < mArray.Length; i++)
        {
            if (mArray[i] != null)
            {
                ret += mArray[i].ToString();
            }
            else
            {
                ret += "(empty)";
            }
            ret += "\n";
        }
        return ret;
    }
}
