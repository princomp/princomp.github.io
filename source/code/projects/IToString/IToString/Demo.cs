class Demo : IToString
{
  public string Name { get; set; }

  public Demo(string nameP)
  {
    Name = nameP;
  }
  // public override string ToString(){return "The name attribute contains:" + Name;}
}
