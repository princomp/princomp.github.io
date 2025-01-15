class Circle
{
    public decimal Diameter { get; set; }
    // The constructor below  sets the value
    // of the property's backing field through
    // the property's set accessor.
    public Circle(decimal dP)
    {
        Diameter = dP;
    }
    // The Radius property below is
    // 1. read-only (no set accessor),
    // 2. without a backing field.
    public decimal Radius {
        get { return Diameter / 2; }
    }

    public static string Explanation()
    {
        return "The diameter is the radius times 2, the circumference is the diameter times pi."
    }

    public decimal Circumference
    {
        get { return Diameter * PI; }
    }

    public override string ToString()
    {
        return "Your circle has a diameter of " + Diameter + "\nA radius of " + Radius + "\nCircumference of " + Circumference;
    }

    public static decimal PI { get; } = 3.1415926535897931M;
    // Pretty much the same as
    // public const decimal PI = 3.1415926535897931M;
}
