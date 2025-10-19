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

    // The ToString method uses String.Format
    public override string ToString()
    {
        string returned =
          "This dictionary uses the "
          + Strategy
          + " strategy.\n";
        for (int i = 0; i < table.Length; i++)
        {
            returned += String.Format("\nIndex {0, -2} |", i);
            if (table[i] != null)
            {
                returned +=
                String.Format(" {0, -10}| {1, -10} | {2, -7}|", table[i].Key, table[i].Value, table[i].Status);
            }
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
    public int GetIndex(TKey keyP, int countP)
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
        if (Find(keyP))
        {
            throw new ArgumentException(
                              "A value with key "
                                + keyP.ToString()
                                + " is already present."
                            );
        }
        int count = 0;
        int index = GetIndex(keyP, count);
        // Collision resolution
        while (
          table[index] != null
          && table[index].Status == StatusType.Active
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
        else
        {
            table[index].Value = valueP;
            table[index].Key = keyP;
            table[index].Status = StatusType.Active;
        }
    }
    // Done with adding an element

    public bool Find(TKey keyP)
    {
        bool found = FindI(keyP) != -1;
        return found;
    }

    public int FindI(TKey keyP)
    {
        bool found = false;
        int count = 0;
        int index = GetIndex(keyP, count);
        while (table[index] != null && count <= table.Length && !found)
        {
            if (table[index].Status == StatusType.Active && table[index].Key.Equals(keyP))
            {
                found = true;
            }
            else
            {
                count++;
                index = GetIndex(keyP, count);
            }
        }
        // Uncomment the following line if you'd like to get a better feel
        // for how this method works.
        // Console.WriteLine("Found " + keyP + " in " + count + ": " + found + ".");
        if (!found) { index = -1; }
        return index;
    }

    public void Remove(TKey keyP)
    {
        int index = FindI(keyP);
        if (index == -1)
        {
            throw new ApplicationException("Cannot delete missing key.");
        }
        else
        {
            table[index].Status = StatusType.Deleted;
        }
    }
}