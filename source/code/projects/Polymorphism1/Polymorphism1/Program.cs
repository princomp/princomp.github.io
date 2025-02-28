class Program
{
  static void Main()
  {
    Class1 object1 = new Class1();
    object1.SetAttribute1("Test");
    object1.Property1 = "Test";

    Class2 object2 = new Class2();
    object2.SetAttribute1("Test");
    object2.Property1 = "Test";
    object2.Property2 = "Test";

        ClassHelper.Method1(object1);
        ClassHelper.Method1(object2);
        ClassHelper.Method2(object2);

    }
}
