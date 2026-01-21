using System;

public class SDictionary
{
  private class Cell
  {
    public string Value { get; set; }
    public string Key { get; set; }

    public Cell(string keyP, string valueP)
    {
      Key = keyP;
      Value = valueP;
    }

    public override string ToString()
    {
      return Key + ":" + Value;
    }
  }

  private Cell[] table;

  public SDictionary(int size = 31)
  {
    table = new Cell[size];
  }

  public int GetIndex(string keyP, int countP)
  {
    return ((int)(keyP[0]) + countP) % table.Length;
  }

  public void Add(string keyP, string valueP)
  {
    int count = 0;
    int index = GetIndex(keyP, count);
    while (table[index] != null)
    {
      count++;
      index = GetIndex(keyP, count);
    }
    table[index] = new Cell(keyP, valueP);
  }

  // Delete method:
  public bool Delete(string keyP)
  {
    int count = 0;
    int index = GetIndex(keyP, count);
    bool found = false;
    while (table[index] != null && !found)
    {
      if (table[index].Key.Equals(keyP))
      {
        found = true;
        table[index] = null;
      }
      count++;
      index = GetIndex(keyP, count);
    }
    return found;
  }

  // End of Delete method.

  // ToString solution:
  public override string ToString()
  {
    string returned = "";
    for (int i = 0; i < table.Length; i++)
    {
      returned += String.Format("\nIndex {0, -2} |", i);
      if (table[i] != null)
      {
        returned += String.Format(
          " {0, -10}| {1, -10} |",
          table[i].Key,
          table[i].Value
        );
      }
    }
    return returned;
  }
  // End of ToString solution.
}
