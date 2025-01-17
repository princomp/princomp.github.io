 using System;

class Program
{
  static void Main()
  {
        do
        {
            Console.WriteLine("Try to guess my number");
        }while(!Game.Guess(Console.ReadLine()));
        
  }
}
