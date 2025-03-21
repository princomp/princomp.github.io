using System;

class Bat : Mammal
{
  private double flightSpeed;
  public double FlightSpeed
  {
    get { return flightSpeed; }
    set
    {
      if (value < 0) //Exception only thrown if value is strictly negative
      {
        throw new Exception(
          "Flight speed cannot be strictly negative."
        );
      }
      else
      {
        flightSpeed = value;
      }
    }
  }

  public Bat(
    string conservationStatusP,
    double populationP,
    string wikiLinkP,
    int mammaryGlandsP,
    double flightSpeedP
  )
    : base(
      conservationStatusP,
      populationP,
      wikiLinkP,
      mammaryGlandsP
    )
  {
    if (mammaryGlandsP != 2 && mammaryGlandsP != 4)
    {
      Console.WriteLine(
        "Your object was created, but according to https://www.auburn.edu/cosam/faculty/biology/hood/lab/documents/Kunz.et.al.2010.LactationChapter.pdf, bats have either 2 or 4 mammary glands."
      );
    }
    flightSpeed = flightSpeedP;
  }

  public override string ToString()
  {
    return base.ToString()
      + String.Format(
        "| {0,-20} | {1,-40}\n",
        "Flight speed",
        flightSpeed
      )
      + String.Format(
        "| {0,-20} | {1,-40}\n",
        "Sound(s) produced",
        Bat.SoundProduced()
      );
  }

  public static string SoundProduced()
  {
    return "screech, squeak, eek";
  }
}
