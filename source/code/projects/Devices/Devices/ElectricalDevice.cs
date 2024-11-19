abstract class ElectricalDevice
{
  public abstract int Voltage { get; set; }
  public abstract int Frequency { get; set; }
  public abstract void SafetyNotice();
}
