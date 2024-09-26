using System;

class Circle
{
  private decimal diameter;
  public decimal Diameter
  {
    get { return diameter; }
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
