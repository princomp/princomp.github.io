using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CStack<T>
{

    private class Cell
    {
        public T Data { get; set; }
        public Cell Next { get; set; }
        public Cell(T data = default(T), Cell node = null)
        {
            Data = data;
            Next = node;
        }
    }

    private Cell top;
    
    public CStack()
    {
        top = null;
    }
    
    public void Clear()
    {
        top = null;
    }
    public bool IsEmpty()
    {
        return top == null;
    }
    
    public void Push(T value)
    {
        top = new Cell(value, top);
    }
    
    public T Pop()
    {
        if (IsEmpty())
            throw new ApplicationException("An empty stack cannot be popped.");
        T removedData = top.Data;
        top = top.Next;
        return removedData;
    }
    
    public T Peek()
    {
        if (IsEmpty())
            throw new ApplicationException("An empty stack cannot be peeked.");
        return top.Data;
    }
    public int Count
    {
        get
        {
            int count = 0;
            Cell cCell = top;
            while (cCell != null)
            {
                count++;
                cCell = cCell.Next;
            }
            return count;
        }
    }

    public override string ToString()
    {
        string returned = "";
        if (!IsEmpty())
        {
            Cell cCell = top;
            while (cCell != null)
            {
                if (returned.Length > 0)
                    returned += ":";
                returned += cCell.Data;
                cCell = cCell.Next;
            }
        }
        return returned;
    }
}
