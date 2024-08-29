using System;
class Circle
{
    public decimal diameter;
    public decimal Diameter
    {
        get
        {
            return Diameter;
        }
        set
        {
        if (value <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                diameter = value;
            }
        }
    }

    public Circle(decimal dP)
    {
        Diameter = dP;
    }

    public override string ToString()
    {
        return "Diameter: " + diameter;
    }
}
