using System;

public class Cube : Rectangle
{
  private int height;
  public int Height
  {
    get { return height; }
    set
    {
      if (value < 0)
        throw new ArgumentException(
          "Width must be strictly positive."
        );
      else
        height = value;
    }
  }

  public Cube(int hP, int wP, int lP, string cP, bool fP):base(hP, wP, cP, fP)
  {
    if (hP != wP || wP != lP)
    {
      throw new ArgumentException(
        "All arguments must be equal"
      );
    }
        Height = hP;
  }

  public override void Talk()
  {
    string msg =
      @"
╭──────────────╮ 
| I'm a Cube!  |
╰─╲╱───────────╯
";
    Console.Write(msg);
    base.Draw();
  }
}
