using System;
using System.Collections;
using System.Collections.Generic;

public class DLList<T> : ICollection<T>
{
  private Cell head;
  private Cell tail;

  public DLList()
  {
    head = null;
    tail = null;
  }

  private class Cell
  {
    public T Data { get; set; }
    public Cell Next { get; set; }
    public Cell Previous { get; set; }

    public Cell(
      T dataP = default(T),
      Cell previousP = null,
      Cell nextP = null
    ) // We provide default values
    {
      Data = dataP;
      Previous = previousP;
      Next = nextP;
    }
  }

  // Empty
  public bool IsEmpty()
  {
    return head == null;
  }

  // Add "to the right",
  // at the end of the list.
  public void Add(T value)
  {
    if (isReadonly)
    {
      throw new InvalidOperationException(
        "List is read-only."
      );
    }
    Cell cCell = head;
    if (cCell != null)
    {
      while (cCell.Next != null)
      // As long as the cCell Cell has a neighbour…
      {
        cCell = cCell.Next;
        // We move the cCell cell to this neighbour.
      }
      Cell newNode = new Cell(value, cCell, null);
      cCell.Next = newNode;
      tail = newNode;
    }
    else
    {
      head = new Cell(value, null);
      tail = head;
    }
  }

  public void Clear()
  {
    head = null;
    tail = null;
  }

  public bool Contains(T value)
  {
    bool found = false;
    Cell cCell = head;
    while (cCell != null && !found)
    {
      if (cCell.Data.Equals(value))
      {
        found = true;
      }
      cCell = cCell.Next;
    }
    return found;
  }

  // Copies the elements of the ICollection to an Array, starting at a particular Array index.
  public void CopyTo(T[] array, int arrayIndex)
  {
    if (array == null)
      throw new ArgumentNullException(
        "The array cannot be null."
      );
    if (arrayIndex < 0)
      throw new ArgumentOutOfRangeException(
        "The starting array index cannot be negative."
      );
    if (Count > array.Length - arrayIndex)
      throw new ArgumentException(
        "The destination array has fewer elements than the collection."
      );

    Cell cCell = head;
    int i = 0; // keeping track of how many elements were copied.
    while (cCell != null)
    {
      array[i + arrayIndex] = cCell.Data;
      i++;
      cCell = cCell.Next;
    }
  }

  public bool Remove(T value)
  {
    if (isReadonly)
    {
      throw new InvalidOperationException(
        "List is read-only"
      );
    }
    bool removed = false;
    if (!IsEmpty())
    {
      if (head.Data.Equals(value))
      {
        head = head.Next;
        if (head != null)
        {
          head.Previous = null;
        }
        removed = true;
      }
      else
      {
        Cell cCell = head;
        while (cCell.Next != null)
        {
          if (cCell.Next.Data.Equals(value))
          {
            cCell.Next.Previous = cCell.Previous;

            cCell.Next = cCell.Next.Next;
            removed = true;
          }
        }
      }
    }
    return removed;
  }

  public int Count
  {
    get
    {
      int size = 0;
      Cell cCell = head;
      while (cCell != null)
      {
        cCell = cCell.Next;
        size++;
      }
      return size;
    }
  }

  public bool isReadonly = false;
  public bool IsReadOnly
  {
    get { return isReadonly; }
    set { isReadonly = value; }
  }

  public IEnumerator<T> GetEnumerator()
  {
    Cell cCell = head;
    while (cCell != null)
    {
      yield return cCell.Data;
      cCell = cCell.Next;
    }
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return this.GetEnumerator(); // call the generic version of the method
  }

  /* We are done realizing the ICollection class. */

  public override string ToString()
  {
    string returned = "———";
    // Line above the table
    for (int i = 0; i < Count; i++)
    {
      returned += "————";
    }
    returned += "\n| ";
    // Content of the CList
    Cell cCell = head;
    while (cCell != null)
    {
      returned += $"{cCell.Data} | ";
      cCell = cCell.Next;
    }
    returned += "\n———";
    // Line below the table
    for (int i = 0; i < Count; i++)
    {
      returned += "————";
    }
    if (Count > 0)
    {
      returned += $"\nHead: {head.Data}\n";
      returned += $"Tail: {tail.Data}\n";
    }
    return returned;
  }
}
