using System;

/*
 * 
 * This solution to the 
 * "Bookmarker" project fulfills the bonus
 * "Have your class handle strings, so that, for example, your Bookmarker constructor would take three strings as input"
 * 
 */

class Bookmarker
{
    public string Title { get; set; }
    private int tPages; // Total number of pages.
    public string TPages // The property accepts string, and will convert them.
    {
        set
        {
            int input = int.Parse(value); // This will throw an error if the value passed is not a number.
            if (input <= 0) // This will throw an error if the value passed is negative.
             throw new ArgumentException(
         "The total number of pages cannot be negative."
       );
            else if (input < cPages) // This will throw an error if the value passed is less than the current page.
            throw new ArgumentException("The total number of pages cannot be less than the current page.");
            else tPages = input; // If no errors were thrown, we set the value to the value passed.
        }
        get { return tPages.ToString(); }
    }
    private int cPages; // Current page
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
        if(value + cPages > tPages) throw new ArgumentException("You cannot have read more than the total number of pages!");
        else cPages += value;
    }
}
