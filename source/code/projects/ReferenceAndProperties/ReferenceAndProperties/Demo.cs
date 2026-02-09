using System;

class Demo
{
  private int[] values;
  public int[] Values
  {
    get { return values; }
  }

  private int value;
  public int Value
  {
    get { return value; }
  }

  public Demo(int[] valuesP, int valueP)
  {
    values = valuesP;
    value = valueP;
  }
}
