using System;

class Circle : Shape
{
  // Radius property
  private int radius;
  public int Radius
  {
    get { return radius; }
    set
    {
      if (value < 0)
        throw new ArgumentException(
          "Radius must be strictly positive."
        );
      else
        radius = value;
    }
  }

  // Diameter property
  public int Diameter
  {
    get { return Radius * 2; }
  }

  // Rest of the class
  public override double GetArea()
  {
    return Math.PI * Radius * Radius;
  }

  public override string ToString()
  {
    return base.ToString()
      + $" a circle.\nRadius: {Radius}\nDiameter: {Diameter}.\n";
  }
}
