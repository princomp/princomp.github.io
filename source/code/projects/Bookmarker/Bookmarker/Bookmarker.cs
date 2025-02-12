using System;

class Bookmarker
{
  public string Title { get; set; }
  private int tPages; // Total number of pages.
  public int TPages // The property will check that the total number of page is "valid"
  {
    set
    {
      if (value <= 0) // This will throw an error if the value passed is negative.
        throw new ArgumentException(
          "The total number of pages cannot be negative."
        );
      else if (value < cPages) // This will throw an error if the value passed is less than the current page.
        throw new ArgumentException(
          "The total number of pages cannot be less than the current page."
        );
      else
        tPages = value; // If no errors were thrown, we set the value to the value passed.
    }
    get { return tPages; }
  }
  private int cPages; // Current page
  public int CPages // The property will check that the current number of page is "valid"
  {
    set
    {
      if (value < 0)
        throw new ArgumentException(
          "You cannot have read a negative number of pages!"
        );
      else if (value > tPages)
      {
        throw new ArgumentException(
          "You cannot have read more than the total number of pages!"
        );
      }
      else
        cPages = value;
    }
    get { return cPages; }
  }

  public Bookmarker(string titleP, int tPagesP, int cPagesP)
  {
    Title = titleP;
    TPages = tPagesP;
    CPages = cPagesP;
  }

  public override string ToString()
  {
    return $"You have read {((double)cPages / tPages):P} of \"{Title}\".\nYou have {(1 - ((double)cPages / tPages)):P} to go!";
  }

  public void Read(int pReadP)
  {
    if (pReadP + cPages > tPages)
      throw new ArgumentException(
        "You cannot have read more than the total number of pages!"
      );
    else
      cPages += pReadP;
  }
}
