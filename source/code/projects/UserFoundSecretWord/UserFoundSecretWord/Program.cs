using System;

class Program
{
  static void Main()
  { 
    string stringtest;
    bool booltest = Demo.UserFoundSecretWord(out stringtest);
    Console.WriteLine("The method returned " + booltest + " after you entered \"" + stringtest + "\".");
  }
}

public static class Demo{
  // Beginning of solution.
  public static bool UserFoundSecretWord(out string uInput){
    Console.WriteLine("Enter a string");
    uInput = Console.ReadLine();
    if(uInput == null) throw new ArgumentNullException();
    return uInput.Contains("scytale");
  }
  // End of solution.
}
