using System;

class Program
{
    static void Main(string[] args)
    {
        Rectangle myRectangle = new Rectangle();
        myRectangle.Length = 6;
        myRectangle.Width = 15;
        Console.WriteLine(
            "Your rectangle's length is "
                + $"{myRectangle.Length}, and "
                + $"its width is {myRectangle.Width}"
        );
    }
}
