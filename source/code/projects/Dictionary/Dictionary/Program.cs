using System;
using System.Collections.Generic;


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
        >(13, CDictionary<string, Address>.PSSType.Linear);
        // Key of type string, value of type int.

        string[] friends = { "Bob", "Sarah", "Justice", "Claire", "Pierre", "Mary", "Lora" };
        foreach (string friend in friends)
        {
            Console.WriteLine("Inserting " + friend + " (Original index: " + notebook.GetIndex(friend, 0) + ")");
            notebook.Add(friend, new Address("Main St."));
        }

        Console.WriteLine(notebook);
        Console.WriteLine("Bob is present:" + notebook.Find("Bob") + ".");
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
        Console.WriteLine("Lora is present:" + notebook.Find("Lora") + ".");
        notebook.Add("Mary", new Address("12th St."));
        Console.WriteLine(notebook);

        try
        {
            notebook.Remove("Stefan");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        /*

        notebook.Add("twenty", 20);
    notebook.Add("fourteen", 14);
    notebook.Add("two", 2);
    notebook.Add("seventeen", 17);
    notebook["fifteen"] = 15;
    Console.Write(notebook);
    Console.WriteLine(notebook["two"]);
    notebook["two"] = 10;
    Console.WriteLine(notebook["two"]);

    int x = notebook.Find("two");
    Console.WriteLine($"Found x = {x}");
    try
    {
      int y = notebook.Find("zzz");
      Console.WriteLine($"Found x = {y}");
    }
    catch (Exception)
    {
      Console.WriteLine($"Didn't find zzz");
    }

    notebook.Remove("two");
    try
    {
      int y = notebook.Find("two");
      Console.WriteLine($"Should not find two = {y}");
    }
    catch (Exception)
    {
      Console.WriteLine(
        $"Didn't find two since it was removed"
      );
    }
    try
    {
      notebook.Remove("two");
      int y = notebook.Find("two");
      Console.WriteLine($"Should not find two = {y}");
    }
    catch (Exception)
    {
      Console.WriteLine(
        $"Shoud throw when trying to remove two since it was removed"
      );
    }
    */
    }
}
