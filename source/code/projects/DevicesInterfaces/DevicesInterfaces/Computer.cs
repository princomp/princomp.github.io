using System;
class Computer: ElectricalDevice, ComputingDevice
{
    private double ips;
    public double IPS
    {
        get { return ips; }
        set
        {
            if (value < 0)
                throw new ArgumentException(
                  "This is not possible."
                );
            else
                ips = value;
        }

    }
    private int voltage;
    public int Voltage
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
    public int Frequency
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
    public Computer(double ipsP, int voltageP, int frequencyP)
    {
        IPS = ipsP;
        Voltage = voltageP;
        Frequency = frequencyP;
    }
    public void Instructions()
    {
        Console.WriteLine(
          "Refer to your operating system manual."
        );
    }
    public void SafetyNotice()
    {
        Console.WriteLine("Refer to your manufacturer website.");
    }
}
