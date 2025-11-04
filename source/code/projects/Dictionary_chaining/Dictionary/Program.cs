using System;
using System.Collections.Generic;

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

class Program
{
    static void Main(string[] args)
    {
        // Example of using the CDictionary class
        CDictionary<string, Address> notebook = new CDictionary<
          string,
          Address
        >(13);

        string[] friends =
        {
      "Bob",
      "Sarah",
      "Sam",
      "Justice",
      "Claire",
      "Pierre",
      "Mary",
      "Lora",
    };

        foreach (string friend in friends)
        {
            Console.WriteLine(
              "Inserting "
                + friend
                + ".");

            notebook.Add(
              friend,
              new Address(
                notebook.GetIndex(friend) + " Main St."
              )
            );
        }

        Console.WriteLine(notebook);
        Console.WriteLine(
          "Bob is present:" + notebook.Find("Bob") + "."
        );
        try
        {
            notebook.Add("Bob", new Address("Broad Street"));
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine("Removing Mary.");
        notebook.Remove("Mary");
        Console.WriteLine(notebook);
        try
        {
            notebook.Remove("Mary");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
