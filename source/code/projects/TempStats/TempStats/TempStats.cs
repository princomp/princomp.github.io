using System;

class TempStats
{
  public string Description { get; set; }
  private double[] temp;
  public double[] Temp
  {
    set
    {
      bool sortedSoFar = true;
      int index = 0;

      while (index + 1 < value.Length && sortedSoFar)
      {
        if (value[index] > value[index + 1])
          sortedSoFar = false;
        index++;
      }
      if (!sortedSoFar)
      {
        throw new ArgumentException(
          "Your data is not sorted."
        );
      }
      foreach (double i in value)
      {
        if (i < -128.6)
        {
          throw new ArgumentOutOfRangeException(
            "That is colder than the coldest ever recorded on Earth!"
          );
          // https://en.wikipedia.org/wiki/Lowest_temperature_recorded_on_Earth
        }
        else if (i > 134.1)
        {
          throw new ArgumentOutOfRangeException(
            "That is hotter than the hottest ever recorded on Earth!"
          );
          // https://en.wikipedia.org/wiki/Highest_temperature_recorded_on_Earth
        }
      }
      temp = value;
    }
  }

  public TempStats(double[] tempP, string desc)
  {
    Temp = tempP;
    Description = desc;
  }

  public double Average
  {
    get
    {
      double acc = 0;
      foreach (double i in temp)
      {
        acc += i;
      }
      return acc / temp.Length;
    }
  }

  public double Median
  {
    get
    {
      if (temp.Length % 2 != 0)
      {
        return temp[(temp.Length - 1) / 2];
      }
      else
      {
        return (
            temp[(temp.Length - 1) / 2]
            + temp[temp.Length / 2]
          ) / 2;
      }
    }
  }
  public double Mode
  {
    get
    {
      // Mode is not implemented.
      throw new NotImplementedException(
        "Mode property is not implemented."
      );
    }
  }
}
