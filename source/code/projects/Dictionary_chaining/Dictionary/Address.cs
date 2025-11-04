// A simple, dummy class, to illustrate that
// dictionaries can contain any type of
// values, even complex ones.
public class Address
{
    public string Street { get; set; }

    public Address(string streetP)
    {
        Street = streetP;
    }

    public override string ToString()
    {
        return Street;
    }
}
