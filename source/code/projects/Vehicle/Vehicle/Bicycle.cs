public class Bicycle : Bike
{
    private string saddleType;
    public Bicycle()
    {
        saddleType = "undefined";
        SetCPM(0.1M);
    }
    public Bicycle(string cP, decimal cpmP, double flP, string sT) : base(cP, cpmP, flP)
    {
        saddleType = sT;
    }
    public override string ToString()
    {
        return base.ToString()
         + $"\nSaddle Type: {saddleType}";
    }
}
