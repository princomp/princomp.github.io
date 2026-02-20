using System;
public class Vehicle
{
  public string Color { get; set; }
  private int numberOfWheels;

  public void SetNOW(int nowP)
  {
    if (nowP > 0)
      numberOfWheels = nowP;
    else
      numberOfWheels = -1;
    // We could also decide to throw an exception here, using e.g.
    // throw new ArgumentException();
  }

  public Vehicle()
  {
    Color = "undefined";
    numberOfWheels = -1;
  }

  public Vehicle(string cP, int nowP)
  {
    Color = cP;
    numberOfWheels = nowP;
    // We could also use our SetNOW method, as follows:
    // SetNOW(nowP);
  }

  public override string ToString()
  {
    return $"Number of wheels: {numberOfWheels}"
      + $"\nColor: {Color}";
  }
}
