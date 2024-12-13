using System;

abstract class Article
{
  public string Id { get; set; }
  private decimal price;

  public void SetPrice(decimal priceP)
  {
    if (priceP < 0)
    {
      throw new ArgumentOutOfRangeException();
    }
    else
    {
      price = priceP;
    }
  }

  public decimal GetPrice()
  {
    return price;
  }

  public Article(string idP, decimal priceP)
  {
    Id = idP;
    SetPrice(priceP);
  }

  public abstract decimal ShippingCosts();
}
