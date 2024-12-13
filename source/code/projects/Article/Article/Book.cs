class Book : Article
{
  public string Title { get; set; }

  public Book(string idP, decimal priceP, string titleP)
    : base(idP, priceP)
  {
    Title = titleP;
  }

  public override decimal ShippingCosts()
  {
    decimal tenp = .1M * GetPrice();
    if (tenp > 5M)
    {
      tenp = 5M;
    }
    return tenp;
  }
}
