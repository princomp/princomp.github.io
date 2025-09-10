using System; // This is required for the exception.

class CQueue<T>
{
  private int front,
    end,
    size;

  private T[] mArray;

  public CQueue(int capacity = 10)
  {
    mArray = new T[capacity];
    // Note that front, end and size
    // are set to 0.
  }

  public void Clear()
  {
    front = 0;
    end = 0;
    size = 0;
  }

  public bool IsEmpty()
  {
    return size == 0;
  }

  public bool IsFull()
  {
    return size == mArray.Length;
  }

  public void Enqueue(T dataP)
  {
    if (!IsFull())
    {
      mArray[end] = dataP;
      Increment(ref end);
      size++;
    }
    else
      Resize();
  }

  public T Dequeue()
  {
    size--;
    T data = mArray[front];
    Increment(ref front);
    return data;
  }

  public void Resize()
  {
    throw new NotImplementedException(
      "Queue Resize is not implemented."
    );
  }

  // Increment must be done carefully:
  // what if we reached the "end of mArray"
  // but there is room available at the
  // beginning of the queue? Then the value
  // needs to become 0.
  private void Increment(ref int value)
  {
    value++;
    if (value == mArray.Length)
    {
      value = 0;
    }
    // This if statement could be replaced
    // with
    // value %= mArray.Length;
  }

  public int Capacity
  {
    get { return mArray.Length - size; }
  }

  public override string ToString()
  {
    string returned = "";
    returned +=
      $"Front : {front}, end : {end}, size : {size}, capacity: {Capacity}\n";
    // Note how the for is constructed:
    for (int i = front; i < size + front; i++)
    {
      returned += mArray[i % mArray.Length] + ":";
    }
    return returned;
  }
}
