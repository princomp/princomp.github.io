using System;

class Program
{
  static void Main()
  {
    Class1 object1 = new Class1();
    object1.Property = -12;

    Class2 object2 = new Class2();
    try
    {
      object2.Property = -12;
    }
    catch
    {
      Console.WriteLine(
        "In Class2, Property cannot be set to a negative value."
      );
    }
  }
}
