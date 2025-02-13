using System;

class Program
{
  static void Main()
  {
    SDCard test = new SDCard();
    test.Nickname = "Blue";
    test.Capacity = 8;
    Console.WriteLine(test);
    try
    {
      test.Capacity = 7;
    }
    catch (Exception e)
    {
      Console.WriteLine(e.Message);
    }
  }
}
