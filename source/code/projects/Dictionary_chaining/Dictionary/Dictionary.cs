using System;
using System.Collections.Generic;

public class CDictionary<TKey, TValue>
  where TKey : IComparable<TKey>
{

    private class Cell
    {
        public TValue Value { get; set; }
        public TKey Key { get; set; }

        public Cell(
          TKey keyP = default(TKey),
          TValue valueP = default(TValue)
        )
        {
            Key = keyP;
            Value = valueP;
        }

        public override string ToString()
        {
            return Key + ":" + Value;
        }
    }

    // A dictionary is an array of *lists* of Cells,
    private List<Cell>[] table;

    public CDictionary(
      int size = 31
    )
    {
        table = new List<Cell>[size];
    }

    // The ToString method uses String.Format
    public override string ToString()
    {
        string returned = "";
        for (int i = 0; i < table.Length; i++)
        {
            returned += String.Format("\nIndex {0, -2} |", i);
            if (table[i] != null)
            {
                foreach (Cell cCell in table[i])
                {
                    returned += String.Format(
          " {0, -10}| {1, -10}|", cCell.Key, cCell.Value);
                }
            }
        }
        return returned;
    }

    public int GetIndex(TKey keyP)
    {
        return (
            Math.Abs(keyP.GetHashCode())
          ) % table.Length;
    }

    public bool Find(TKey keyP)
    {
        bool found = false;
        int index = GetIndex(keyP);
        if (table[index] != null)
        {
            foreach (Cell cCell in table[index])
            {
                if (cCell.Key.Equals(keyP)) { found = true; }
            }
        }
        return found;
    }

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
        int index = GetIndex(keyP);
        if (
          table[index] == null)
        {
            table[index] = new List<Cell>();
        }
        Cell newCell = new Cell(keyP, valueP);
        table[index].Add(newCell);
    }

    public void Remove(TKey keyP)
    {
        if (!Find(keyP))
        {
            throw new ArgumentException(
              "There is no value with key "
                + keyP.ToString()
                + " in the dictionary."
                 );
        }
        int index = GetIndex(keyP);
        bool found = false;
        int counter = 0;
        while (!found)
        {
            if (table[index][counter].Key.Equals(keyP)) { found = true; }
            else { counter++; }
        }
        table[index].RemoveAt(counter);
    }
}
