using System;

class Employee : Person
{
  private decimal hourlyPay;
  public override string Id
  {
    set
    {
      if (value[0] != 'E')
        throw new ArgumentException(
          "An employee ID must start with an 'E'."
        );
    }
  }
}
