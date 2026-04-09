using System;

public class Rectangle : Shape
{
  private int width;
  public int Width
  {
    get { return width; }
    set
    {
      if (value < 0)
        throw new ArgumentException(
          "Width must be strictly positive."
        );
      else
        width = value;
    }
  }
  private int length;
  public int Length
  {
    get { return length; }
    set
    {
      if (value < 0)
        throw new ArgumentException(
          "Length must be strictly positive."
        );
      else
        length = value;
    }
  }
  
  public override double GetArea(){
    return Width * Length;
  }
  
  // ToString method
    public override string ToString()
  {
    return base.ToString() + " a rectangle (W:" + Width + ", L:" + Length + ", Area: " + GetArea() + ")\n";
  }
  
  // Equals method  
  public bool Equals(Rectangle rP){
    return (rP.Length == Length && rP.Width == Width) || (rP.Length == Width && rP.Width == Length); 
  }
  // End of Equals method
  

}
