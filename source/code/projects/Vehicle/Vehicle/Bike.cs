public class Bike : Vehicle
{
    public double ForkLength;
    public Bike()
    {
        ForkLength = -1;
        SetNOW(2); // or base.setNOW(2);
    }
    public Bike(string cP, double flP) : base(cP, 2)
    {
        ForkLength = flP;
    }
    public override string ToString()
    {
        return base.ToString()
         + $"\nFork Length: {ForkLength}";
    }
} 
