using System;

class SDCard
{
  public string Nickname { get; set; }
  private int capacity;
  public int Capacity
  {
    set
    {
      if (
        value == 8
        || value == 16
        || value == 32
        || value == 64
        || value == 128
      )
        capacity = value;
      else
        throw new ArgumentException();
    }
    get { return capacity; }
  }
  public int CapacityInGb
  {
    get { return capacity * 8; }
  }

  public override string ToString()
  {
    return "Name: "
      + Nickname
      + "\nCapacity: "
      + Capacity
      + "GB"
      + "\nCapacity in Gb: "
      + CapacityInGb
      + "Gb";
  }
}
