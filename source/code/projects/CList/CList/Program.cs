﻿using System;

class Program
{
  static void Main(string[] args)
  {
    /* First example. */
    CList<int> myList1 = new CList<int>();
    myList1.AddL(1);
    myList1.AddL(2);
    myList1.AddL(3);
    myList1.AddL(4);
    myList1.AddL(5);
    Console.WriteLine(myList1);
    Console.WriteLine("Size is " + myList1.Size);
    Console.WriteLine("0th elem is " + myList1.Access(0));
    Console.WriteLine("2nd elem is " + myList1.Access(2));
    myList1.RemoveI(2);
    Console.WriteLine(
      "Removed the element on the second index."
    );
    Console.WriteLine(myList1);
    Console.WriteLine("0th elem is " + myList1.Access(0));
    Console.WriteLine("2nd elem is " + myList1.Access(2));

    Console.WriteLine("\n\n\n"); // Spacing…

    /* Second example. */
    CList<char> myList2 = new CList<char>();
    try
    {
      myList2.RemoveI(0);
    }
    catch
    {
      Console.WriteLine(
        "Tried to acces an element at an index that doesn't exist."
      );
    }
    try
    {
      myList2.RemoveF();
      Console.WriteLine(
        "Sucessfully removed the first element."
      );
      myList2.RemoveL();
      Console.WriteLine(
        "Sucessfully removed the last element."
      );
      Console.WriteLine(myList2.Access(0));
    }
    catch
    {
      Console.WriteLine(
        "Tried to access an element that doesn't exist."
      );
    }

    myList2.AddF('a');
    myList2.AddL('z');
    Console.WriteLine(myList2);
    Console.WriteLine(myList2.Access(0));
    Console.WriteLine(myList2.Access(1));
    try
    {
      Console.WriteLine(myList2.Access(2));
    }
    catch
    {
      Console.WriteLine(
        "Tried to access an element that doesn't exist."
      );
    }
  }
}