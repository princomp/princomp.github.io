using System;
using System.Collections.Generic;

class Program
{
  static void Main(string[] args)
  {
    // Example of using the CDictionary class
    CDictionary<string, Address> notebook = new CDictionary<
      string,
      Address
    >(13, CDictionary<string, Address>.PSSType.Quad);
    // Key of type string, value of type Address, Linear probe sequence strategy.
    // Try with
    // CDictionary<string, Address>.PSSType.Linear
    // CDictionary<string, Address>.PSSType.Quad
    // CDictionary<string, Address>.PSSType.Double

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
          + " (Original index: "
          + notebook.GetIndex(friend, 0)
          + ")"
      );
      notebook.Add(
        friend,
        new Address(
          notebook.GetIndex(friend, 0) + " Main St."
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
    Console.WriteLine(
      "Lora is present:" + notebook.Find("Lora") + "."
    );
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

    Console.WriteLine("Clearing the notebook.");
    notebook.Clear();
    Console.WriteLine(notebook);

    string[] friends2 =
    {
      "Pierre",
      "Sandra",
      "Joy",
      "Nicole",
      "Sam",
      "Fritz",
    };

    foreach (string friend in friends2)
    {
      Console.WriteLine(
        "Inserting "
          + friend
          + " (Original index: "
          + notebook.GetIndex(friend, 0)
          + ")"
      );
      notebook.Add(
        friend,
        new Address(
          notebook.GetIndex(friend, 0) + " Main St."
        )
      );
    }
    Console.WriteLine(notebook);

    Console.WriteLine(
      "If the table size is not prime, we obtain:"
    );
    for (int i = 0; i < 10; i++)
    {
      Console.Write((i * i) % 12 + ", ");
    }

    Console.WriteLine(
      "…\nIf the table size is prime, we obtain:"
    );
    for (int i = 0; i < 10; i++)
    {
      Console.Write((i * i) % 13 + ", ");
    }
    Console.WriteLine("…");

    Console.WriteLine(
      "\nFinally, let us observe the index computed using the quadratic strategy:"
    );

    CDictionary<string, string> demoQ = new CDictionary<
      string,
      string
    >(1009, CDictionary<string, string>.PSSType.Quad);
    bool[] arrayQ = new bool[1009];
    for (int i = 0; i < arrayQ.Length; i++)
    {
      arrayQ[demoQ.GetIndex("Test", i)] = true;
      // Uncomment the following if you'd like to see
      // which indices are hit.
      // Console.WriteLine(i +": " + demoQ.GetIndex("Test", i) + ".");
    }
    int count = 0;
    for (int i = 0; i < arrayQ.Length; i++)
    {
      if (arrayQ[i])
        count++;
    }
    Console.WriteLine(
      $"We hit {((decimal)count / arrayQ.Length):p} of the indices."
    );

    Console.WriteLine(
      "\nFinally, let us observe the index computed using the double hash strategy:"
    );
    // Demonstrating the double hash strategy:
    CDictionary<string, string> demoD = new CDictionary<
      string,
      string
    >(1009, CDictionary<string, string>.PSSType.Double);
    bool[] arrayD = new bool[1009];
    for (int i = 0; i < arrayD.Length; i++)
    {
      arrayD[demoD.GetIndex("Test", i)] = true;
      // Uncomment the following if you'd like to see
      // which indices are hit.
      // Console.WriteLine(i +": " + demoD.GetIndex("Test", i) + ".");
    }
    count = 0;
    for (int i = 0; i < arrayD.Length; i++)
    {
      if (arrayD[i])
        count++;
    }
    Console.WriteLine(
      $"We hit {((decimal)count / arrayD.Length):p} of the indices."
    );
    // 100% !
  }
}
