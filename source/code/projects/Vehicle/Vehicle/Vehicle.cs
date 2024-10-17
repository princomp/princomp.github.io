public class Vehicle
{
    public string Color { get; set; }
    private decimal costPerMile;
    public void SetCPM(decimal cpmP)
    {
        if (cpmP > 0) costPerMile = cpmP;
        else costPerMile = -1M;
    }
    public Vehicle()
    {
        Color = "undefined";
        costPerMile = -1M;
    }
    public Vehicle(string cP, decimal cpmP)
    {
        costPerMile = cpmP;
        Color = cP;
    }
    public override string ToString()
    {
        return $"Cost per mile: {costPerMile:C}"
        + $"\nColor: {Color}";
    }
}