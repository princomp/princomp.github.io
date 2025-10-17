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
        Deleted
    };

    // We will use open addressing 
    // to resolve conflict, 
    // and must pick one of the following
    // probe sequence
    public enum PS
    {
        Linear,
        Quad,
        Double
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

    // The hash table is 
    // - an array of Cells,
    // - and a probe sequence.
    private Cell[] table;
    private readonly PS Strategy;

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
      PS probesequenceP = PS.Double
    )
    {
        table = new Cell[PrimeHelper.NextPrime(size)];
        Strategy = probesequenceP;
    }

    public void Clear()
    {
        for (int i = 0; i < table.Length; i++)
            if (table[i] != null)
                table[i].Status = StatusType.Deleted; // Reuse cells by setting them to Empty
    }

    public void Add(TKey keyP, TValue valueP)
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
        int index = GetIndex(keyP, count);
        // Collision resolution
        while (
          table[index] != null 
          && !table[index].Status.Equals(StatusType.Deleted)
        )
        {
            count++;
            if (count == table.Length) // If table is full, throw an exception.
                throw new ApplicationException("Table is full.");
            index = GetIndex(keyP, count);
        }

        if (table[index] == null) // table slot is empty (e.g. never been used)
            table[index] = new Cell(
              keyP,
              valueP,
              StatusType.Active
            );
        else if (
          table[index].Key.Equals(keyP) == true
          && table[index].Status == StatusType.Active
        ) // duplicate key found
            throw new ArgumentException(
              "Dictionary Error: Don't add duplicate keys: "
                + keyP.ToString()
            );
        else if (table[index].Status == StatusType.Deleted) // previously used item, reuse the cell
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
          && table[index].Key.Equals(keyP) == true
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
    private int GetIndex(TKey keyP, int countP)
    {
        // countP captures the number of times we had to solve
        // a collision.
        return (
            Math.Abs(keyP.GetHashCode())
            + collisionR(countP, keyP)
          ) % table.Length;
    }

    // This is the how collision are handled.
    // It depends on the strategy picked.
    // This overall strategy is called open addressing.
    // https://en.wikibooks.org/wiki/Data_Structures/Hash_Tables#Open_addressing
    private int collisionR(int i, TKey keyP)
    {
        if (i == 0)
            return 0;
        else
        {
            if (Strategy == PS.Linear)
                return i++;
            else if (Strategy == PS.Quad)
                return i * i;
            else if (Strategy == PS.Double)
                // This is double hashing.
                return i * (31 - (keyP.GetHashCode() % 31)); // i * hash2(keyP) where hash2 is 31 - (key % 31) and will always be > 0
            else
                throw new ApplicationException(
                  "Unknown collision startegy."
                );
        }
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
              table[index].Key.Equals(keyP) == true
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
