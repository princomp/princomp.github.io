using System;

class Program
{
  public static void Main()
  {
    Person test1 = new Person();
    test1.SetName("Patricia");
    Console.WriteLine(test1.GetName());
    test1.SetName("Patty");
    Console.WriteLine(test1.GetName());

    FMember test = new FMember("Cousin", "Samuel");
  }
}
