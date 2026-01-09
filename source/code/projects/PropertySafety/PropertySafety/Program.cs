using System;

class Program
{
  static void Main()
  {
    PropertySafety test = new PropertySafety();

    try
    {
      test.SensibleData = "Forbidden word";
    }
    catch (AccessViolationException ex)
    {
      Console.WriteLine(ex.Message);
    }
    Console.WriteLine(test.SensibleData);
  }
}
