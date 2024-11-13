class Office : Room
{
  private string phone;

  public Office(string bP, int nP, string pP)
    : base(bP, nP)
  {
    phone = pP;
  }
}
