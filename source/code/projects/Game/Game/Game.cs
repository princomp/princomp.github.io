using System;

class Game
{
  public static bool Guess(string guessP)
  {
    const int VALUE_TO_GUESS = 12;
    try
    {
      int guessV = int.Parse(guessP);
      if (guessV == VALUE_TO_GUESS)
      {
        Console.WriteLine("You guessed it!");
        return true;
      }
      else
      {
        Console.WriteLine("Try again!");
        return false;
      }
    }
    catch (FormatException)
    {
      Console.WriteLine(
        "Please, provide a string containing only numbers"
      );
      return false;
    }
    finally
    {
      Console.WriteLine("Thank you for playing!");
    }
  }
}
