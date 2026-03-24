using System;

class Program
{
  static void Main()
  {
    Derived test1 = new Derived("This is the parameter");
    Console.WriteLine(test1);

    test1.Test(null);
    test1.Test();

    test1.Attr2 = "This is the parameter.";
    Console.WriteLine(test1.GetAttr2());

    try
    {
      Derived test2 = new Derived('Z');
      test2.Attr4W = '3';
    }
    catch
    {
      Console.WriteLine(
        "Derived constructor threw an error"
      );
    }
  }
}
