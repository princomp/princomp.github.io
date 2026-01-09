using System;

class PropertySafety
{
  private string sensibleData;
  public string SensibleData
  {
    set
    {
      if (value == "Forbidden word")
      {
        Console.WriteLine("Intrusion detected, aborting!");
        throw new AccessViolationException();
      }
      sensibleData = value;
    }
    get { return sensibleData; }
  }
}
