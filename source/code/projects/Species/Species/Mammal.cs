using System; // Useful for exceptions

abstract class Mammal : Animal
{
  private int mammaryGlands;
  public int MammaryGlands
  {
    get { return mammaryGlands; }
    set
    {
      // Values courtesy of https://en.wikipedia.org/wiki/Mammary_gland#General
      if (value < 2)
      {
        throw new ArgumentException(
          "Number of mammary glands cannot be less than 2."
        );
      }
      else if (value == 13 || (value >= 25 && value <= 27))
      {
        // It must be the Southern red-sided opossum or a
        // Virginia opossum
        mammaryGlands = value;
      }
      else if (value % 2 != 0)
      {
        throw new ArgumentException(
          "Number of mammary glands cannot be odd, unless it is 13, 25 or 27."
        );
      }
      else if (
        value != 6
        && value != 14
        && value != 16
        && value <= 18
      )
      {
        // The value is either 2, 4, 8, 10, 12 or 18,
        // since we already know that it is greater than 2 and even.
        mammaryGlands = value;
      }
      else
      {
        throw new ArgumentException(
          "Number of mammary glands is not valid."
        );
      }
    }
  }

  protected Mammal(
    string conservationStatusP,
    double populationP,
    string wikiLinkP,
    int mammaryGlandsP
  )
    : base(conservationStatusP, populationP, wikiLinkP)
  {
    MammaryGlands = mammaryGlandsP;
  }

  public override string ToString()
  {
    return base.ToString()
      + String.Format(
        "| {0,-20} | {1,-40}\n",
        "Mammary Glands",
        MammaryGlands
      );
  }
}
