using System;
using System.Collections.Generic;

public class CDictionary<TKey, TValue>
  where TKey : IComparable<TKey>
{
  // Two enumerated types that we will be using
  // for our implementation of Dictionary.
  public enum StatusType
  {
    Empty,
    Active,
    Deleted,
  };

  public enum CollisionRes
  {
    Linear,
    Quad,
    Double,
  };

  private class Cell
  {
    public StatusType Status { get; set; }
    public TValue Value { get; set; }
    public TKey Key { get; set; }

    public Cell(
      TKey aKey = default(TKey),
      TValue aValue = default(TValue),
      StatusType aStatus = StatusType.Empty
    )
    {
      Key = aKey;
      Value = aValue;
      Status = aStatus;
    }

    public override string ToString()
    {
      return Key + ":" + Value;
    }
  }

  // The hash table is an array of Cells,
  // and a collision strategy.
  private Cell[] table;
  private readonly CollisionRes Strategy;

  public override string ToString()
  {
    string returned = "";
    int i = 0;
    foreach (Cell pos in table)
    {
      returned += $"Position {i}: {pos}\n";
      i++;
    }
    return returned;
  }

  public CDictionary(
    int size = 31,
    CollisionRes aCollisionStrategy = CollisionRes.Double
  )
  {
    table = new Cell[PrimeHelper.NextPrime(size)];
    Strategy = aCollisionStrategy;
  }

  public void Clear()
  {
    for (int i = 0; i < table.Length; i++)
      if (table[i] != null)
        table[i].Status = StatusType.Deleted; // Reuse cells by setting them to Empty
  }

  public void Add(TKey aKey, TValue aValue)
  {
    /*
     * First, we find an empty cell (e.g. cell is null, status empty or deleted)
     * - We computer a possible index:
     *      - We first use GetHashCode() to generate a hash code,
     *      - then shift it using collisionR.
     * - We check if the cell at this index is available,
     * - If it is not, we try with the next one,
     * - If all cells are occupied, we throw an error.
     */
    int count = 0;
    int index = GetIndex(aKey, count);
    // Collision resolution
    while (
      table[index] != null
      && !table[index].Status.Equals(StatusType.Deleted)
    )
    {
      count++;
      if (count == table.Length) // If table is full, throw an exception.
        throw new ApplicationException("Table is full.");
      index = GetIndex(aKey, count);
    }

    if (table[index] == null) // table slot is empty (e.g. never been used)
      table[index] = new Cell(
        aKey,
        aValue,
        StatusType.Active
      );
    else if (
      table[index].Key.Equals(aKey) == true
      && table[index].Status == StatusType.Active
    ) // duplicate key found
      throw new ArgumentException(
        "Dictionary Error: Don't add duplicate keys: "
          + aKey.ToString()
      );
    else if (table[index].Status == StatusType.Deleted) // previously used item, reuse the cell
    {
      table[index].Value = aValue;
      table[index].Key = aKey;
      table[index].Status = StatusType.Active;
    }
    else
      throw new ApplicationException(
        "Something went wrong in Add method."
      );
  }

  /// <summary>
  /// Returns the data associated with the key
  /// </summary>
  /// <param name="aKey"></param>
  /// <returns>data item</returns>
  public TValue Find(TKey aKey)
  {
    // search until found or empty
    int count = 0;
    int index = GetIndex(aKey, count);
    while (
      table[index] != null
      && table[index].Status != StatusType.Deleted
      && !table[index].Key.Equals(aKey)
    )
    {
      count++;
      if (count == table.Length) // in case table is full, kicks out of inf loop
        throw new ApplicationException("Table is full");
      index = GetIndex(aKey, count);
    }

    if (table[index] == null)
      throw new KeyNotFoundException(
        "The key " + aKey.ToString() + " was not found"
      );
    else if (
      table[index].Status == StatusType.Active
      && table[index].Key.Equals(aKey) == true
    )
      return table[index].Value;
    else
      throw new ApplicationException(
        "Something went wrong in Find method."
      );
  }

  // The following is used to compute the
  // integer hash code of the key, and shift it if needed
  // using countP.
  private int GetIndex(TKey aKey, int countP)
  {
    // countP captures the number of times we had to solve
    // a collision.
    return (
        Math.Abs(aKey.GetHashCode())
        + collisionR(countP, aKey)
      ) % table.Length;
  }

  // This is the how collision are handled.
  // It depends on the strategy picked.
  // This overall strategy is called open addressing.
  // https://en.wikibooks.org/wiki/Data_Structures/Hash_Tables#Open_addressing
  private int collisionR(int i, TKey aKey)
  {
    if (i == 0)
      return 0;
    else
    {
      if (Strategy == CollisionRes.Linear)
        return i++;
      else if (Strategy == CollisionRes.Quad)
        return i * i;
      else if (Strategy == CollisionRes.Double)
        // This is double hashing.
        return i * (31 - (aKey.GetHashCode() % 31)); // i * hash2(aKey) where hash2 is 31 - (key % 31) and will always be > 0
      else
        throw new ApplicationException(
          "Unknown collision startegy."
        );
    }
  }

  public void Remove(TKey aKey)
  {
    //int index = Search(aKey, IsDeletedOrFound);
    int count = 0;
    int index = GetIndex(aKey, count);
    while (
      table[index] != null
      && (
        table[index].Status == StatusType.Deleted
        || !table[index].Key.Equals(aKey)
      )
    )
    {
      count++;
      if (count == table.Length) // in case table is full, kicks out of inf loop
        throw new ApplicationException("Table is full");
      index = GetIndex(aKey, count);
    }
    // Search will keep looking until found or empty cell.
    if (table[index] == null)
      throw new KeyNotFoundException(
        "Cannot delete missing key: " + aKey.ToString()
      );
    else if (
      table[index].Status == StatusType.Active
      && table[index].Key.Equals(aKey)
    )
      table[index].Status = StatusType.Deleted; // Found it! Mark the cell as deleted.
    else
      throw new ApplicationException(
        "Something went wrong in the Remove method."
      );
  }

  // The following allows the use of [].
  public TValue this[TKey aKey]
  {
    get { return Find(aKey); }
    set
    {
      // find empty cell (e.g. cell is null, status empty or deleted)
      int count = 0;
      int index = GetIndex(aKey, count);
      while (
        table[index] != null
        && !table[index].Status.Equals(StatusType.Deleted)
      )
      {
        count++;
        if (count == table.Length) // in case table is full, kicks out of inf loop
          throw new ApplicationException("Table is full");
        index = GetIndex(aKey, count);
      }
      // table slot is empty
      if (table[index] == null)
        table[index] = new Cell(
          aKey,
          value,
          StatusType.Active
        );
      // duplicate key found
      else if (
        table[index].Key.Equals(aKey) == true
        && table[index].Status == StatusType.Active
      )
        table[index].Value = value;
      // previously used item, reuse it
      else if (table[index].Status == StatusType.Deleted)
      {
        table[index].Value = value;
        table[index].Key = aKey;
        table[index].Status = StatusType.Active;
      }
      else
        throw new ApplicationException(
          "Something went wrong in [] set."
        );
    }
  }
}
