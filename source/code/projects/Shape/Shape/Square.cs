using System;

public class Cube : Rectangle
{
    private int height;
    public int Height
    {
        get { return height; }
        set {
            if (value < 0) throw new ArgumentException("Width must be strictly positive.");
            else height = value;
        }
    }
    public Cube(int hP, int wP, int lP, string cP, bool fP)
    {
        if (hP == wP && wP == lP)
        {
            base(wP, lP, cP, fP);
            Height = hP;
        }
        else { throw new ArgumentException("All arguments must be equal"); }
    }

    public override void Talk()
    {
        string msg = @"
╭──────────────╮ 
| I'm a Cube!  |
╰─╲╱───────────╯
";
        Console.Write(msg);
        base.Draw();
    }

}
