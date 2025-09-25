using System;
using System.Collections;
using System.Collections.Generic;

public class CList<T> : ICollection<T>
{
  /*
   * https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1?view=net-9.0
   * A class realizing the ICollection interface must have the following properties:
   * - A `Count` property that gets the number of elements contained in the ICollection<T>.
   * - A `IsReadOnly` property that gets a value indicating whether the ICollection<T> is read-only.
   * and the following methods:
   * - Add(T): Adds an item to the ICollection<T>.
   * - Clear(): Removes all items from the ICollection<T>.
   * Contains(T): Determines whether the ICollection<T> contains a specific value.
   * CopyTo(T[], Int32): Copies the elements of the ICollection<T> to an Array, starting at a particular Array index.
   * GetEnumerator(): Returns an enumerator that iterates through a collection. (Inherited from IEnumerable)
   * Remove(T): Removes the first occurrence of a specific object from the ICollection<T>.
   */

  /* Same implementation of Cell as usual.*/
  private Cell first;

  public CList()
  {
    first = null;
  }

  private class Cell
  {
    public T Data { get; set; }
    public Cell Next { get; set; }

    public Cell(T dataP = default(T), Cell nextP = null) // We provide default values
    {
      Data = dataP;
      Next = nextP;
    }
  }

  /* Done with Cell.*/

  // Empty
  public bool IsEmpty()
  {
    return first == null;
  }

  // Add is simply "AddF", slightly revisited.
  public void Add(T value)
  {
    if (isReadonly)
    {
      throw new InvalidOperationException(
        "List is read-only."
      );
    }
    first = new Cell(value, first);
  }

  public void Clear()
  {
    first = null;
  }

  public bool Contains(T value)
  {
    bool found = false;
    Cell cCell = first;
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

    Cell cCell = first;
    int i = 0; // keeping track of how many elements were copied.
    while (cCell != null)
    {
      array[i + arrayIndex] = cCell.Data;
      i++;
      cCell = cCell.Next;
    }
  }

  // Remove the first node containing the value
  // if it exists and returns true,
  // returns false otherwise.
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
      if (first.Data.Equals(value))
      {
        first = first.Next;
        removed = true;
      }
      else
      {
        Cell cCell = first;
        while (cCell.Next != null && !removed)
        {
          if (cCell.Next.Data.Equals(value))
          {
            cCell.Next = cCell.Next.Next;
            removed = true;
          }
          else
          {
            cCell = cCell.Next;
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
      Cell cCell = first;
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
    Cell cCell = first;
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

  // One last method, to remove the last cell and
  // returns its value.
  public T RemoveL()
  {
    if (isReadonly)
    {
      throw new InvalidOperationException(
        "List is read-only"
      );
    }
    if (IsEmpty())
    {
      throw new InvalidOperationException(
        "Cannot remove last cell from an empty list!."
      );
    }
    T data;

    Cell cCell = first;
    while (cCell.Next != null && cCell.Next.Next != null)
    {
      cCell = cCell.Next;
    }
    data = cCell.Next.Data;
    cCell.Next = null;
    return data;
  }
}
