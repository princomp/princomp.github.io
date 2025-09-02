using System;

class Program
{
  static void Main(string[] args)
  {
    /* First example. */
    CStack<int> myStack1 = new CStack<int>();
    Console.WriteLine(myStack1);
    myStack1.Push(1);
    myStack1.Push(5);
    myStack1.Push(2);
    myStack1.Push(2);
    myStack1.Push(1);
    myStack1.Push(1);
    myStack1.Push(3);
    myStack1.Push(4);
    myStack1.Push(5);
    myStack1.Push(5);
    myStack1.Push(5);
    myStack1.Push(2);
    myStack1.Push(2);
    Console.WriteLine(myStack1);

    /* Second example. */
    CStack<char> myStack2 = new CStack<char>();
    try
    {
      myStack2.Pop();
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.Message);
    }
    try
    {
      myStack2.Peek();
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.Message);
    }

    myStack2.Push('a');
    myStack2.Push('z');
    Console.WriteLine(
      "Value at top of stack: " + myStack2.Peek()
    );
  }
}
