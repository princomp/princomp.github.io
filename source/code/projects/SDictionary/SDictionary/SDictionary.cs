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
}
