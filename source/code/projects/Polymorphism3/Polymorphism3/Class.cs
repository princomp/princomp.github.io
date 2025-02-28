class Class1
{
  public virtual string Test()
  {
    return "Class1";
  }
}

class Class2 : Class1
{
  public override string Test()
  {
    return "Class2";
  }
}