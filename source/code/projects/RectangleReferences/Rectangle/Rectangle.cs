using System;

class Rectangle
{
  private int length;
  public int Length
  {
    get { return length; }
    set
    {
      if (value < 0)
      {
        throw new ArgumentNullException();
      }
      else
        length = value;
    }
  }

  private int width;
  public int Width
  {
    get { return width; }
    set
    {
      if (value < 0)
      {
        throw new ArgumentNullException();
      }
      else
        width = value;
    }
  }

  public Rectangle(int wP, int lP)
  {
    Width = wP;
    Length = lP;
  }

  public override string ToString()
  {
    return $"Width: {Width}\nLength: {Length}";
  }

  public Rectangle Copy()
  {
    return new Rectangle(Width, Length);
  }

  public bool Equals(Rectangle rP)
  {
    if (rP == null)
      return false;
    return rP.Length == Length && rP.Width == Width;
  }

  public void Draw(char symb = '*')
  {
    string drawing = "";
    for (int i = 0; i < Length; i++)
    {
      for (int j = 0; j < Width; j++)
      {
        drawing += symb;
      }
      drawing += "\n";
    }
    Console.WriteLine(drawing);
  }
}
