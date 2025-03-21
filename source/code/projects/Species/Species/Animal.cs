using System; // Useful for exceptions

abstract class Animal
{
  private string conservationStatus;

  private double population;
  private string wikiLink;

  /// Smallest double such that 1.0+EpsilonD != 1.0
  /// Courtesy of https://stackoverflow.com/a/46682754
  /// We use it to test if a double is "almost" 0.
  private const double EpsilonD = 2.2204460492503131e-016;
  public double Population
  {
    get { return population; }
    set
    {
      if (value < 0 && conservationStatus != "DD")
      {
        throw new ArgumentException(
          "Population cannot be negative unless conservation status is DD."
        );
      }
      else if (
        Math.Abs(value) < EpsilonD
        && (
          conservationStatus != "EX"
          && conservationStatus != "DD"
        )
      )
      {
        throw new ArgumentException(
          value
            + conservationStatus
            + "Population cannot be zero if conservation status is not EX or DD."
        );
      }
      else if (
        conservationStatus == "EX"
        && Math.Abs(value) > EpsilonD
      )
      {
        throw new ArgumentException(
          "Population cannot be non-zero if conservation status is not EX."
        );
      }
      else
        population = value;
    }
  }
  public string WikiLink
  {
    get { return wikiLink; }
    set
    {
      if (
        value.StartsWith("https://en.wikipedia.org/wiki/")
      )
      {
        wikiLink = value;
      }
      else
      {
        throw new ArgumentException(
          "Submission link ("
            + value
            + ") does not start with \"https://en.wikipedia.org/wiki/\"."
        );
      }
    }
  }

  public void SetConservationStatus(
    string conservationStatusP
  )
  {
    // if char length greater than 2 error.
    if (conservationStatusP.Length != 2)
    {
      throw new ArgumentException(
        "A conservation status is 2 characters long."
      );
    }
    else if (
      conservationStatusP != "EX"
      && conservationStatusP != "EW"
      && conservationStatusP != "CR"
      && conservationStatusP != "EN"
      && conservationStatusP != "VU"
      && conservationStatusP != "NT"
      && conservationStatusP != "CD"
      && conservationStatusP != "LC"
      && conservationStatusP != "DD"
      && conservationStatusP != "NE"
    )
    {
      throw new ArgumentException(
        conservationStatusP
          + " is not a valid conservation status."
      );
    }
    else
    {
      conservationStatus = conservationStatusP;
    }
  }

  protected Animal(
    string conservationStatusP,
    double populationP,
    string wikiLinkP
  )
  {
    SetConservationStatus(conservationStatusP);
    Population = populationP;
    WikiLink = wikiLinkP;
  }

  public override string ToString()
  {
    return String.Format(
        "| {0,-20} | {1,-40:N0}\n",
        "Population",
        Population * 1000
      )
      + String.Format(
        "| {0,-20} | {1,-40}\n",
        "Conservation Status",
        conservationStatus
      )
      + String.Format(
        "| {0,-20} | {1,-40}\n",
        "Wikipedia Link",
        WikiLink
      );
  }

  public static void ExpandConservationStatus()
  {
    Console.WriteLine(
      @"
    Extinct (EX) – There are no known living individuals
    Extinct in the wild (EW) – Known only to survive in captivity, or as a naturalized population outside its historic range
    Critically Endangered (CR) – Highest risk of extinction in the wild
    Endangered (EN) – Higher risk of extinction in the wild
    Vulnerable (VU) – High risk of extinction in the wild
    Near Threatened (NT) – Likely to become endangered in the near future
    Conservation Dependent (CD) – Low risk; is conserved to prevent being near threatened, certain events may lead it to being a higher risk level
    Least concern (LC) – Very Low risk; does not qualify for a higher risk category and not likely to be threatened in the near future. Widespread and abundant taxa are included in this category.
    Data deficient (DD) – Not enough data to make an assessment of its risk of extinction
    Not evaluated (NE) – Has not yet been evaluated against the criteria."
    );
  }
}
