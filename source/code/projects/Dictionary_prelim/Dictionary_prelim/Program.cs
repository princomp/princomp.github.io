using System;
using System.Collections.Generic;

class Program
{
    public enum Level
    {
        Low,
        Medium,
        High
    }

    static void Main(string[] args)
    {
        // Demonstrating enum type.
        Console.WriteLine("Demonstrating enumerated types:");
        Level lvl1 = Level.Medium; // To access the value, we prefix with Level.
        Level lvl2 = (Level)0; // We can cast an int into a Level.
        Console.WriteLine(lvl1);
        Console.WriteLine(lvl2.ToString());
        // Will display "Medium" then "Low": the ToString() method is given by default.

        // Demonstrating PrimeHelper class:
        Console.WriteLine("\nDemonstrating PrimeHelper class:");
        // Testing IsPrime
        int[] testingValues = { 89, 6700417, 2147483646, 2147483647 };
        // 2147483647 remained the largest known prime until 1867, 
        // and is the largest value that a signed 32-bit integer field can hold!
        // cf. https://en.wikipedia.org/wiki/2,147,483,647
        foreach (int i in testingValues)
        {
            Console.WriteLine($"{i:N00} is prime: {PrimeHelper.IsPrime(i)}.");
        }
        // Testing NextPrime
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(
              "The smallest prime greater than or equal to "
                + i
                + " is "
                + PrimeHelper.NextPrime(i)
                + "."
            );
        }
        Console.WriteLine("The smallest prime greater than or equal to 2,147,483,000 is: " + PrimeHelper.NextPrime(2147483000));

        // Demonstrating GetHashCode:
        Console.WriteLine("\nDemonstrating GetHashCode method:");
        Console.WriteLine(
          "The hash code of an empty array of 12 int is: "
            + (new int[12]).GetHashCode() // 156563611
            + "."
        );
        Console.WriteLine(
          "The hash code of an empty array of 14 string is: "
            + (new string[14]).GetHashCode() // -800837957
            + "."
        );
        Console.WriteLine(
          "The hash code of \"test string\" is: "
            + "test string".GetHashCode() // 1040790544
            + "."
        );
        Console.WriteLine(
          "The hash code of 12 is: " + 12.GetHashCode() + "." // 12
        );
    }
}
