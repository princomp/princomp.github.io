public class Bike : Vehicle
{
    public double ForkLength;
    public Bike()
    {
        ForkLength = -1;
        SetCPM(0.15M); // or base.setCPM(0.15M);
    }
    public Bike(string cP, decimal cpmP, double flP) : base(cP, cpmP)
    {
        ForkLength = flP;
    }
    public override string ToString()
    {
        return base.ToString()
         + $"\nFork Length: {ForkLength}";
    }
} 
