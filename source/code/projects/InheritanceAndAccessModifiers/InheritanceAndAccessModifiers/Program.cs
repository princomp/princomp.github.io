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

    // test1.name = "Test";
    // would give
    // 'Person.name' is inaccessible due to its protection level

    // test1.nickName = "Test";
    // would give
    // 'Person.nickName' is inaccessible due to its protection level

    test1.commonName = "Test";
    FMember test2 = new FMember("Cousin", "Samuel");
    
  }
}
