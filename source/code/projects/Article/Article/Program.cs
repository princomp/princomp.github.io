using System;

class Program
{
  public static void Main()
  {
    Book test = new Book(
      "AAA001",
      12.5M,
      "What it's like to be a bird."
    );
    Console.WriteLine($"{test.ShippingCosts():C}");
    Console.WriteLine(test.Id);
  }
}
