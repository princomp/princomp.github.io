using System;

class Abacus : ComputingDevice
{
  private double ips;
  public override double IPS
  {
    get { return ips; }
    set
    {
      if (value < 0 || value > 1000)
        throw new ArgumentException(
          "This is not plausible"
        );
      else
        ips = value;
    }
  }
  public string Material { get; set; }

  public Abacus(double ipsP, string materialP)
  {
    IPS = ipsP;
    Material = materialP;
  }

  public override void Instructions()
  {
    Console.WriteLine(
      "Refer to https://www.wikihow.com/Use-an-Abacus"
    );
  }
}
