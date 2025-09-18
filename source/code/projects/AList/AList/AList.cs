using System;
using System.Collections;
using System.Collections.Generic;

public class AList<T> : ICollection<T>
{
  // Our implementation of list is so that
  // the alist array is always of the "right
  // size", so we don't need to keep track
  // of a separate counter for the size of the
  // list. This is more memory-
  // intensive (because arrays get created
  // frequently), but lighter to implement.
  private T[] alist;

  public AList()
  {
    alist = new T[0];
  }

  public bool IsEmpty()
  {
    return alist.Length == 0;
  }

  public void Clear()
  {
    alist = new T[0];
  }

  // Attribute and property for the
  // isReadOnly required by ICollection.
  public bool isReadonly = false;
  public bool IsReadOnly
  {
    get { return isReadonly; }
    set { isReadonly = value; }
  }

  // Add is adding "to the left".
  public void Add(T value)
  {
    if (isReadonly)
    {
      throw new InvalidOperationException(
        "List is read-only, you cannot add to it."
      );
    }
    else
    {
      // We create a larger array
      // using the length of the existing
      // array.
      T[] newlist = new T[alist.Length + 1];
      // We insert the new value "to the left".
      newlist[0] = value;
      // We copy the remaining values,
      // shifting them by one.
      for (int i = 0; i < alist.Length; i++)
        newlist[i + 1] = alist[i];
      // Finally, our new array becomes our
      // alist attribute.
      alist = newlist;
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
        "List is read-only, you cannot remove from it."
      );
    }
    bool removed = false;
    if (!IsEmpty())
    {
      int i = 0;
      while (i < alist.Length && !removed)
      {
        if (alist[i].Equals(value))
        {
          removed = true;

          // We create the array that will replace
          // the current one.

          T[] newList = new T[alist.Length - 1];
          // We first copy the values
          // before the value we found:
          for (int j = 0; j < i; j++)
            newList[j] = alist[j];
          // We now copy the values *after*
          // the value we found.
          for (int j = i; j < newList.Length; j++)
            newList[j] = alist[j + 1];
          alist = newList;
        }
        i++;
      }
    }
    return removed;
  }

  public bool Contains(T value)
  {
    // We start by assuming we did not find
    // the target value.
    bool found = false;
    // We go through the array.
    for (int i = 0; i < alist.Length; i++)
    {
      if (alist[i].Equals(value))
        found = true;
    }
    return found;
  }

  // Adding "to the right" (as the last value).
  public void AddR(T value)
  {
    if (isReadonly)
    {
      throw new InvalidOperationException(
        "List is read-only, you cannot add to it."
      );
    }
    else
    {
      // We resize the array using
      // built-in method.
      Array.Resize(ref alist, alist.Length + 1);
      // We insert the new value "at the end".
      alist[alist.Length - 1] = value;
    }
  }

  // Count property simply returns
  // the length of the alist array
  // if it is not null.
  public int Count
  {
    get { return alist.Length; }
  }

  // Copies the elements of the ICollection to an Array, starting at a particular Array index.
  public void CopyTo(T[] array, int arrayIndex)
  {
    if (array == null)
      // The array into which we copy
      // cannot be null.
      throw new ArgumentNullException();
    if (arrayIndex < 0)
      // The index must be strictly positive.
      throw new ArgumentOutOfRangeException();
    if (Count > array.Length - arrayIndex)
      // If there is not enough room in the
      // array given as argument to copy
      // our list, we throw an exception.
      throw new ArgumentException(
        $"The destination array does not have enough space ({array.Length}) to copy the list ({Count}) starting at the given index ({arrayIndex})."
      );
    // If none of the exceptions were triggered,
    // we can copy the values at the right index.
    for (int i = 0; i < alist.Length; i++)
    {
      array[i + arrayIndex] = alist[i];
    }
  }

  /* The following is "bureaucracy" to realize the
   * ICollection interface. */

  public IEnumerator<T> GetEnumerator()
  {
    if (!IsEmpty())
    {
      for (int i = 0; i < alist.Length; i++)
      {
        yield return alist[i];
      }
    }
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return this.GetEnumerator(); // call the generic version of the method
  }

  /* We are done realizing the ICollection interface. */
}
