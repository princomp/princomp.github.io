using System;

class PropertySafety
{
  private string sensibleData;
  public string SensibleData
  {
    set
    {
      sensibleData = value;
      if (value == "Forbidden word")
      {
        Console.WriteLine("Intrusion detected, aborting!");
        throw new AccessViolationException();
      }
    }
    get { return sensibleData; }
  }
}
