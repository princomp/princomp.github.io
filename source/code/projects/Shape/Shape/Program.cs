using System;

class Program
{
  static void Main()
  {
    /* Black
     * DarkBlue
     * DarkGreen
     * DarkCyan
     * DarkRed
     * DarkMagenta
     * DarkMagenta
     * DarkYellow
     * Gray
     * DarkGray
     * Blue
     * Green
     * Cyan
     * Red
     * Magenta
     * Yellow
     * White
     * Black
     */

    Rectangle test0 = new Rectangle(5, 3, "Blue", false);
    Console.Write(test0);
    test0.Talk();
    test0.FlipRight();
    Console.Write(test0);
    test0.Talk();

    Rectangle test1 = new Rectangle(2, 3, "Cyan", true);
    Console.Write(test1);
    test1.Talk();
    test1.FlipRight();
    Console.Write(test1);
    test1.Talk();

    if (test0.CompareTo(test1) > 0)
      Console.WriteLine("test0 is greater than test1");
    else if (test0.CompareTo(test1) < 0)
      Console.WriteLine("test0 is smaller than test1");
    else
      Console.WriteLine(
        "test0 and test1 are of the same size"
      );

    Cube test2 = new Cube(3, 3, 3, "Yellow", false);
    test2.Talk();

    try
    {
      Cube test3 = new Cube(1, 2, 3, "Magenta", true);
    }
    catch
    {
      Console.WriteLine("Error creating this cube.");
    }
  }
}
