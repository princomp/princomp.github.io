using System;

class Program
{
    public static void Main()
    {
        char[] passcode = { 'b', 'C', '4', 'a' };
        char[] codentered = { 'B', '4', 'c', 'a' };

        // Test for identity
        bool identical = true;
        for (int i = 0; i < passcode.Length; i++)
        {
            if (passcode[i] != codentered[i]) identical = false;
        }
        if (identical) { Console.WriteLine("Passcode correct"); }
        // Test for validity
        bool valid = true;
        for (int i = 0; i < passcode.Length; i++)
        {
            for (int j = i+1; j < passcode.Length; j++)
                if (passcode[i] == passcode[j]) valid = false;
        }
        if (valid) { Console.WriteLine("Passcode valid"); }
        // Test for sorted
        bool sorted_a = true; // sorted ascending
        bool sorted_d = true; // sorted descending
        for (int i = 0; i < passcode.Length-1; i++)
        {
          if (passcode[i] > passcode[i+1]) sorted_a = false;
          if (passcode[i] < passcode[i + 1]) sorted_d = false;
        }
        if (sorted_a || sorted_d) { Console.WriteLine("Passcode sorted"); }
        // Matching chars -- Same position
        int count1 = 0;
        for (int i = 0; i < passcode.Length; i++)
        {
            if (passcode[i] == codentered[i]) count1++;
        }
        Console.WriteLine("Number of matching characters (at the same position) : " + count1 + ".");
        // Matching chars -- Any position
        int count2 = 0;
        for (int i = 0; i < passcode.Length; i++)
        {
            for (int j = 0; j < codentered.Length; j++)
            if (passcode[i] == codentered[j]) count2++;
        }
        Console.WriteLine("Number of matching characters (at any position) : " + count2 + ".");

    }
}
  
