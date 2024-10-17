public class Vehicle
{
    public string Color { get; set; }
    private int numberOfWheels;
    public void SetNOW(int nowP)
    {
        if (nowP > 0) numberOfWheels = nowP;
        else numberOfWheels = -1;
    }
    public Vehicle()
    {
        Color = "undefined";
        numberOfWheels = -1;
    }
    public Vehicle(string cP, int nowP)
    {
        numberOfWheels = nowP;
        Color = cP;
    }
    public override string ToString()
    {
        return $"Number of wheels: {numberOfWheels}"
        + $"\nColor: {Color}";
    }
}