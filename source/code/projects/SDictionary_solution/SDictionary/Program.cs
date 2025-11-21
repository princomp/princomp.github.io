using System;

class Program
{
    static void Main(string[] args)
    {
        SDictionary friends = new SDictionary(11);
        friends.Add("Bob", null);
        friends.Add("Pete", null);
        friends.Add("Mary", null);
        friends.Add("Lora", null);
        Console.WriteLine(friends);
        // Inserting "Lora" again.
        friends.Add("Lora", null);
        Console.WriteLine(friends);

        Console.WriteLine("Deleted Bob:" + friends.Delete("Bob"));
        Console.WriteLine(friends);
        Console.WriteLine("Deleted Mary:" + friends.Delete("Mary"));
        Console.WriteLine(friends);

        // Exhibiting Delete incorrect behavior:
        SDictionary demo = new SDictionary(2);
        string error = "Alex";
        demo.Add("Alice", null);
        demo.Add(error, null);
        demo.Delete("Alice");
        Console.WriteLine($"{error} is in dictionary: {demo.Delete(error)}.");
        // Done: the program will believe that the 
        // string error ("Alex") is not
        // in the demo array, while it is.
        Console.WriteLine(demo);

    }
}
