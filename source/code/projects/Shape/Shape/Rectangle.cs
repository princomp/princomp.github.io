using System;
using System.Linq;

public class Rectangle : Shape
{
  public Rectangle(int wP, int lP, string cP, bool fP)
    : base(cP, fP)
  {
    Width = wP;
    Length = lP;
  }

  public override string ToString()
  {
    return base.ToString() + "Test";
  }

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

  public override void Talk()
  {
    string msg =
      @"
╭───────────────────╮ 
| I'm a rectangle!  |
╰─╲╱────────────────╯
";
    Console.Write(msg);
    Draw();
  }

  public void Draw()
  {
    // To read about colors, refer e.g. to
    // https://stackoverflow.com/questions/2743260/is-it-possible-to-write-to-the-console-in-colour-in-net
    string msg = "";
    Type type = typeof(ConsoleColor);
    if (Enum.GetNames(type).Contains(GetColor()))
    {
      Console.ForegroundColor = (ConsoleColor)
        Enum.Parse(type, GetColor());
    }
    for (int i = 0; i < length; i++)
    {
      for (int j = 0; j < width; j++)
      {
        if (i == 0 && j == 0)
        {
          msg += "┍";
        }
        else if (i == length - 1 && j == 0)
        {
          msg += "┕";
        }
        else if (i == 0 && j == width - 1)
        {
          msg += "┑";
        }
        else if (i == length - 1 && j == width - 1)
        {
          msg += "┙";
        }
        else if (i == 0 || i == length - 1)
        {
          msg += "─";
        }
        else if (j == 0 || j == width - 1)
        {
          msg += "|";
        }
        else if (!GetFilled())
        {
          msg += " ";
        }
        else
        {
          msg += "█";
        }
      }
      msg += "\n";
    }
    Console.WriteLine(msg);
    Console.ForegroundColor = (ConsoleColor)
      Enum.Parse(type, "White");
  }

  public override void FlipRight()
  {
    int temp;
    temp = Length;
    Length = Width;
    Width = temp;
  }

  public override double Area()
  {
    return Length * Width;
  }
}
