using System;

class USWashingMachine : ElectricalDevice
{
  private int voltage;
  public override int Voltage
  {
    get { return voltage; }
    set
    {
      if (value < 110 || value > 220)
      {
        throw new ArgumentOutOfRangeException();
      }
      else
      {
        voltage = value;
      }
    }
  }
  private int frequency;
  public override int Frequency
  {
    get { return frequency; }
    set
    {
      if (value != 50 && value != 60)
      {
        throw new ArgumentOutOfRangeException();
      }
      else
        frequency = value;
    }
  }

  public USWashingMachine(int vP, int fP)
  {
    Voltage = vP;
    Frequency = fP;
  }

  public override void SafetyNotice()
  {
    Console.WriteLine(
      "Refer to https://www.energy.gov/sites/prod/files/2016/06/f32/NFPA_DryerWasherSafetyTips.pdf"
    );
  }
}
