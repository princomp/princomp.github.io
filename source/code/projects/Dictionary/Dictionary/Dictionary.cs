using System;
using System.Collections.Generic;

// A Dictionary requires two generic types parameter.
public class CDictionary<TKey, TValue>
  where TKey : IComparable<TKey>
// We only need to assume that Keys can be compared.
{
  // Two enumerated types that we will be using
  // for our implementation of Dictionary.

  // We will use open addressing
  // to resolve conflict,
  // and must pick one of the following
  // probe sequence strategy type.
  public enum PSSType
  {
    Linear,
    Quad,
    Double
  };

  // Status Type will be used to mark
  // the status of a cell.
  public enum StatusType
  {
    Empty,
    Active,
    Deleted
  };

  private class Cell
  {
    public StatusType Status { get; set; }
    public TValue Value { get; set; }
    public TKey Key { get; set; }

    public Cell(
      TKey keyP = default(TKey),
      TValue valueP = default(TValue),
      StatusType statusP = StatusType.Empty
    )
    {
      Key = keyP;
      Value = valueP;
      Status = statusP;
    }

    public override string ToString()
    {
      return Key + ":" + Value;
    }
  }

  // A dictionary is
  // - an array of Cells,
  // - and a probe sequence strategy.
  private Cell[] table;
  private readonly PSSType Strategy;

  public CDictionary(
    int size = 31,
    PSSType probesequenceP = PSSType.Double
  )
  {
    table = new Cell[PrimeHelper.NextPrime(size)];
    Strategy = probesequenceP;
  }

  // The ToString method is immediate
  public override string ToString()
  {
    string returned =
      "This dictionary uses the "
      + Strategy
      + " strategy.\n";
    int i = 0;
    foreach (Cell pos in table)
    {
      returned += $"\nPosition {i}: {pos}";
      if (pos != null)
      {
        returned += $"(Status: {pos.Status}).";
      }

      i++;
    }
    return returned;
  }

  public void Clear()
  {
    for (int i = 0; i < table.Length; i++)
      if (table[i] != null)
        table[i].Status = StatusType.Empty;
        // Reuse cells by setting them to Empty
  }

    // The following is used to compute the
    // integer hash code of the key, accounting for
    // how many collisions we met so far.
    private int GetIndex(TKey keyP, int countP)
    {
        // countP captures the number of times we had to solve
        // a collision.
        return (
            Math.Abs(keyP.GetHashCode())
            + CollisionResolution(keyP, countP)
          ) % table.Length;
    }

    // This is the how collision are handled.
    // It depends on the strategy picked,
    // the key, and the number of time we had
    // to handle a collision.
    private int CollisionResolution(TKey keyP, int countP)
    {
        if (countP == 0)
            return 0;
        else
        {
            if (Strategy == PSSType.Linear)
                return countP++;
            else if (Strategy == PSSType.Quad)
                return countP * countP;
            else if (Strategy == PSSType.Double)
                // This is double hashing.
                return countP * (31 - (keyP.GetHashCode() % 31));
                // countP * hash2(keyP) where hash2 is 31 - (key % 31) and will always be > 0
            else
                throw new ApplicationException(
                  "Unknown collision startegy."
                );
        }
    }
    // Done with GetIndex and CollisionResolution.

        // Adding an element
    public void Add(TKey keyP, TValue valueP)
  {

    int count = 0;
    int index = GetIndex(keyP, count);
    // Collision resolution
    while (
      table[index] != null
      && !table[index].Status.Equals(StatusType.Deleted)
      && !table[index].Status.Equals(StatusType.Empty)
    )
        {
      count++;
            if (count == table.Length) // If table is full, throw an exception.
            {
                throw new ApplicationException("Table is full.");
            }
            else // there is still room, generate the next index.
            {
                index = GetIndex(keyP, count);
            }
    }

    if (table[index] == null) // table slot is empty (e.g. never been used)
      table[index] = new Cell(
        keyP,
        valueP,
        StatusType.Active
      );
    else if (
      table[index].Key.Equals(keyP)
      && table[index].Status == StatusType.Active
    ) // duplicate key found
      throw new ArgumentException(
        "Dictionary Error: Don't add duplicate keys: "
          + keyP.ToString()
      );
    else if (table[index].Status == StatusType.Deleted || table[index].Status.Equals(StatusType.Empty)) // previously used item, reuse the cell
    {
      table[index].Value = valueP;
      table[index].Key = keyP;
      table[index].Status = StatusType.Active;
    }
    else
      throw new ApplicationException(
        "Something went wrong in Add method."
      );
  }
    // Done with adding an element

    public TValue Find(TKey keyP)
  {
    // search until found or empty
    int count = 0;
    int index = GetIndex(keyP, count);
    while (
      table[index] != null
      && table[index].Status != StatusType.Deleted
      && !table[index].Key.Equals(keyP)
    )
    {
      count++;
      if (count == table.Length) // in case table is full, kicks out of loop
        throw new ApplicationException("Table is full");
      index = GetIndex(keyP, count);
    }

    if (table[index] == null)
      throw new KeyNotFoundException(
        "The key " + keyP.ToString() + " was not found"
      );
    else if (
      table[index].Status == StatusType.Active
      && table[index].Key.Equals(keyP)
    )
      return table[index].Value;
    else
      throw new ApplicationException(
        "Something went wrong in Find method."
      );
  }



  public void Remove(TKey keyP)
  {
    //int index = Search(keyP, IsDeletedOrFound);
    int count = 0;
    int index = GetIndex(keyP, count);
    while (
      table[index] != null
      && (
        table[index].Status == StatusType.Deleted
        || !table[index].Key.Equals(keyP)
      )
    )
    {
      count++;
      if (count == table.Length) // in case table is full, kicks out of inf loop
        throw new ApplicationException("Table is full");
      index = GetIndex(keyP, count);
    }
    // Search will keep looking until found or empty cell.
    if (table[index] == null)
      throw new KeyNotFoundException(
        "Cannot delete missing key: " + keyP.ToString()
      );
    else if (
      table[index].Status == StatusType.Active
      && table[index].Key.Equals(keyP)
    )
      table[index].Status = StatusType.Deleted; // Found it! Mark the cell as deleted.
    else
      throw new ApplicationException(
        "Something went wrong in the Remove method."
      );
  }

  // The following allows the use of [].
  public TValue this[TKey keyP]
  {
    get { return Find(keyP); }
    set
    {
      // find empty cell (e.g. cell is null, status empty or deleted)
      int count = 0;
      int index = GetIndex(keyP, count);
      while (
        table[index] != null
        && !table[index].Status.Equals(StatusType.Deleted)
      )
      {
        count++;
        if (count == table.Length) // in case table is full, kicks out of inf loop
          throw new ApplicationException("Table is full");
        index = GetIndex(keyP, count);
      }
      // table slot is empty
      if (table[index] == null)
        table[index] = new Cell(
          keyP,
          value,
          StatusType.Active
        );
      // duplicate key found
      else if (
        table[index].Key.Equals(keyP)
        && table[index].Status == StatusType.Active
      )
        table[index].Value = value;
      // previously used item, reuse it
      else if (table[index].Status == StatusType.Deleted)
      {
        table[index].Value = value;
        table[index].Key = keyP;
        table[index].Status = StatusType.Active;
      }
      else
        throw new ApplicationException(
          "Something went wrong in [] set."
        );
    }
  }
}
