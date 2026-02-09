using System;

class TempStats
{
  private const double LOWEST_TEMPERATURE = -128.6;

  // https://en.wikipedia.org/wiki/Lowest_temperature_recorded_on_Earth
  private const double HIGHEST_TEMPERATURE = 134.1;

  // https://en.wikipedia.org/wiki/Highest_temperature_recorded_on_Earth

  public string Description { get; set; }
  private double[] temp;
  public double[] Temp
  {
    set
    {
      bool sortedSoFar = true;
      int index = 0;

      if (value == null)
      {
        throw new ArgumentException(
          "Array of temperatures cannot be null."
        );
      }

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

      // At this point, we know the array is sorted (increasingly).
      // We can check only the first value against LOWEST_TEMPERATURE,
      // since we know all other values are greater.
      // Similarly, we can check only the last value against HIGHEST_TEMPERATURE.
      if (value[0] < LOWEST_TEMPERATURE)
      {
        throw new ArgumentOutOfRangeException(
          "That is colder than the coldest ever recorded on Earth!"
        );
      }
      else if (
        value[value.Length - 1] > HIGHEST_TEMPERATURE
      )
      {
        throw new ArgumentOutOfRangeException(
          "That is hotter than the hottest ever recorded on Earth!"
        );
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
