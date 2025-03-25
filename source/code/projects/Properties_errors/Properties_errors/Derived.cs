using System; // Useful for exceptions

class Derived:Base
{
    // Misconception #1
    private string attr1;
    public string Attr1 { get; set; }
    public Derived(string attr1P)
    {
        Attr1 = attr1P;
    }
    public override string ToString()
    {
        return "The attribute is " + attr1;
    }

    /* Misconception #1 is ignoring the 
     * Warning CS0649: Field 'Derived.attr1' is never assigned to, and will always have its default value null (CS0649) (Properties_errors)
     * that shows that attr1 "plays no role": no connection is made 
     * between the attribute attr1 and the property Attr1.
     * A remedy is to have the Attr1 property *actually uses attr1*, as follows:
    */
    /*
  public string Attr1
    {
        get { return attr1; }
        set { attr1 = value; }
    }

*/   
    // Misconception #2
    public void Test(string argP)
    {
        Console.WriteLine("Hello from Derived!");
    }

    /*
     * This previous method *does not* override
     * the Test() method from the Base class!
     */    

    // Misconception #3 + #4
    private char attr4w;
    public char Attr4W { set { attr4w = value; } get { return attr4w; } }
    public Derived(char attr4wP)
    {
        char[] admissibleChars =
        {
            'A', 'B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
        };
        if(Array.Exists(admissibleChars, element => element == attr4wP)){
            attr4w = attr4wP;
        }
        else
        {
            throw new Exception("Invalid value");
        }
    }

    /*
     * Misconception #3 is to believe that the
     * following property is enforced at all time:
     * "At no point attr4w can hold any value not between 'A' and 'Z'"
     * since the value of attr4w can be set later on, using the 
     * public property    
     */

        /* 
         * Misconception #4 is to look on the internet 
         * for unfamiliar solutions (Array.Exists) while
         * familiar tools are readily available.
         */        

    // Remedy to misconception #3: Use the property to check the value!
    private char attr4r;
    public char Attr4R
    {
        set
        {
            if (value >= 'A' && value <= 'Z')
            { // Remedy to misconception #4: Think about simpler ways instead of googling complicated method!
                attr4r = value;
            }
            else
            {
                throw new Exception("Invalid value");
            }
        }
        get { return attr4r; }
    }


    // Misconception #5
    // What does readonly?
    private readonly int attr2; // Can not be set here!

    Derived(int attr2P)
    {
        attr2 = attr2P; // It's ok to set its value "once and for all" in the constructor.
    }
    void ResetAttr2()
    {
        // attr2 = 0;
        // ^ Error if uncommented
    }

    // That is a difference with const
    private const int ATTR3 = 12;
    // which *requires* to be set when defined,
    // and is hence "static" in nature.
    // private static const int ATTR3 = 10;
    // would give Compiler Error CS0504
    // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0504

    // Question, can you find the differences (if any) between the following three 
    // ways of declaring a "Foo" property?

    public int Foo1 { get; private set; }

    private readonly int foo2;
    public int Foo2
    {
        get { return foo2; }
    }

    private int foo3;
    public int Foo3
    {
        get { return foo3; }
    }
}
