class Class1
{
  public virtual string Test()
  {
    return "Class1";
  }
}

class Class2 : Class1
{
  public sealed override string Test()
  {
    return "Class2";
  }
}

class Class3 : Class2
{
  public override string Test()
  {
    return "Class 3";
  }
}
