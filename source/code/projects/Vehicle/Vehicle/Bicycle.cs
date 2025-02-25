public class Bicycle : Bike
{
  private string saddleType;

  public Bicycle()
  {
    saddleType = "undefined";
  }

  public Bicycle(string cP, double flP, string sdtP)
    : base(cP, flP)
  {
    saddleType = sdtP;
  }

  public override string ToString()
  {
    return base.ToString() + $"\nSaddle Type: {saddleType}";
  }
}
