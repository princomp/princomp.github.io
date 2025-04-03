using System;

class BedRoom : Room
{
    private int capacity;
    public int Capacity
    {
        set
        {
            if (value < 0) { throw new ArgumentException("A capacity must be positive or 0."); }
            else { capacity = value; }
        }
    }

    public BedRoom(double wP, double lP, int cP) : base(wP, lP)
    {
        Capacity = cP;
        }

    public override string ToString()
  {
        return base.ToString() + "Capacity: " + capacity;
  }
}
