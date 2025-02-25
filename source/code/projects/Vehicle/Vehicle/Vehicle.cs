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
    // We could also decide to throw an exception here.
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
  }

  public override string ToString()
  {
    return $"Number of wheels: {numberOfWheels}"
      + $"\nColor: {Color}";
  }
}
