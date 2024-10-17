using System;

class Program
{
  static void Main(string[] args)
  {
    Rectangle r0 = new Rectangle(3, 2);

    r0.Draw();
    r0.Draw('-');

    Rectangle original;
    original = new Rectangle(5, 10);
    Rectangle copy = original.Copy();
    Console.WriteLine(
      "Original:\n" + original + "\nCopy:\n" + copy + "\n"
    );
    copy.Length = 12;
    Console.WriteLine(
      "\nOriginal:\n" + original + "\nCopy:\n" + copy + "\n"
    );

    Rectangle r1 = new Rectangle(5, 10);
    Rectangle r2 = new Rectangle(5, 10);
    Rectangle r3 = null;
    Rectangle r4 = r1;
    Rectangle r5 = new Rectangle(10, 5);

    Console.WriteLine(
      "r1 and r2 identical: "
        + r1?.Equals(r2)
        + "\nr1 and r3 identical: "
        + r1?.Equals(r3)
        + "\nr3 and r1 identical: "
        + r3?.Equals(r1)
        + "\nr3 and r3 identical: "
        + r3?.Equals(r3)
        + "\nr1 and r4 identical: "
        + r1?.Equals(r4)
        + "\nr1 and r5 identical: "
        + r1?.Equals(r5)
    );
  }
}
