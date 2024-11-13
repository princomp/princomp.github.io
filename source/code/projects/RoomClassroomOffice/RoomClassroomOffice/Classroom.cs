class ClassRoom : Room
{
  private bool av;

  public ClassRoom(string bP, int nP, bool aP)
    : base(bP, nP)
  {
    av = aP;
  }

  public override string ToString()
  {
    return base.ToString() + "av? " + av;
  }
}
