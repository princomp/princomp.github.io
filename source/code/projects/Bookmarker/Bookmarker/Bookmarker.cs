using System;

class Bookmarker
{
    public string Title { get; set; }
    private int tPages;
    public string TPages
    {
        set
        {
            int input = int.Parse(value);
            if (input <= 0) throw new ArgumentException(
         "The total number of pages cannot be negative."
       );
            else tPages = input;
        }
        get { return tPages.ToString(); }
    }
    private int cPages;
    public string CPages
    {
        set
        {
            int input = int.Parse(value);
            if (input < 0) throw new ArgumentException(
          "You cannot have read a negative number of pages!"
        );
            else if (input > tPages)
            {
                throw new ArgumentException("You cannot have read more than the total number of pages!");
            }
            else cPages = input;
        }
        get
        {
            return cPages.ToString();
        }

    }

    public Bookmarker(string titleP, string tPagesP, string cPagesP)
    {
        Title = titleP;
        TPages = tPagesP;
        CPages = cPagesP;
    }

    public override string ToString()
    {
        return $"You have read {((double)cPages / tPages):P} of \"{Title}\".\nYou have {(1 - ((double)cPages / tPages)):P} to go!";
    }
    public void Read(string pReadP)
    {
        int value = int.Parse(pReadP);
        CPages += pReadP;
    }
}
