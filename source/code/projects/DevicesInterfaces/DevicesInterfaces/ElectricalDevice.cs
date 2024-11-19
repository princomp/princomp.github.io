interface ElectricalDevice
{
  int Voltage { get; set; }
  int Frequency { get; set; }
  void SafetyNotice();
}
