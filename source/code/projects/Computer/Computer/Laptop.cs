using System;
class Laptop : Computer
{
  public double Battery { get; set; }
  private int screenSize;
  public int ScreenSize{
    get{return screenSize;}
    set{if (value < 0) throw new ArgumentException(); else screenSize = value;}}
  public Laptop(double baP, int ssP, string brP)
    : base(brP)
  {
    Battery = baP;
    ScreenSize = ssP;
  }

  public override string ToString()
  {
    return base.ToString()
      + $"\nBattery: {Battery:P}"
      + $"\nScreen size: {ScreenSize}\"";
  }
}
