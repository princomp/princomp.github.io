class Laptop : Computer
{
  public int ScreenSize { get; set; }

  public Laptop(int ssP, string bP)
    : base(bP)
  {
    ScreenSize = ssP;
  }

  public override string ToString()
  {
    return base.ToString()
      + $"\nScreen size: {ScreenSize}\"";
  }
}
