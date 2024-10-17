public class Bicycle : Bike
{
  private string saddleType;

  public Bicycle()
  {
    SetNOW(2);
    saddleType = "undefined";
  }

  public Bicycle(string cP, double flP, string sT)
    : base(cP, flP)
  {
    saddleType = sT;
  }

  public override string ToString()
  {
    return base.ToString() + $"\nSaddle Type: {saddleType}";
  }
}
