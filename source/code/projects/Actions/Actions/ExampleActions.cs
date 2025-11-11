using System;

public static class ExampleActions
{
  public static void Test()
  {
    Console.WriteLine("Test");
  }

  public static void Display(int i)
  {
    Console.WriteLine(i);
  }
}

public static class ExampleActions<T>
{
  public static void DisplayArray(T[] arrayP)
  {
    for (int i = 0; i < arrayP.Length; i++)
    {
      Console.WriteLine(arrayP[i]);
    }
  }
}
