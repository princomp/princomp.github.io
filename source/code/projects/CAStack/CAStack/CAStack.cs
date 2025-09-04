using System;

class CAStack<T>
{
  private T[] mArray;

  // Contains the number of the next empty cell.
  private int top = 0;

  // Our default stack size is 10.
  public CAStack(int sizeP = 10)
  {
    if (sizeP <= 0)
      throw new ApplicationException(
        "Stack size must be strictly greater than 0."
      );
    else
      mArray = new T[sizeP];
  }

  public void Clear()
  {
    top = 0;
  }

  public bool IsEmpty()
  {
    return top == 0;
  }

  public void Push(T value)
  {
    if (top < mArray.Length)
    {
      mArray[top] = value;
      top++;
    }
    else
    {
      throw new ApplicationException("Stack is full.");
    }
  }

  public T Pop()
  {
    if (IsEmpty())
      throw new ApplicationException(
        "An empty stack cannot be popped."
      );
    return mArray[--top];
  }

  public T Peek()
  {
    if (IsEmpty())
      throw new ApplicationException(
        "An empty stack cannot be peeked."
      );
    return mArray[top - 1];
  }

  public int Count
  {
    get { return top; }
  }

  public override string ToString()
  {
    string returned = "";
    if (!IsEmpty())
    {
      int counter = top - 1;
      while (counter >= 0)
      {
        if (returned.Length > 0)
          returned += ":";
        returned += mArray[counter];
        counter--;
      }
    }
    return returned;
  }
}
