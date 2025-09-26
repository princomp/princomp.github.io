using System;

class Program
{
  static void Main(string[] args)
  {
    /* Simple example. */
    CList<int> myList1 = new CList<int>();
    myList1.Add(1);
    myList1.Add(5);
    myList1.Add(2);
    myList1.Add(2);
    myList1.Add(1);
    myList1.Add(1);
    myList1.Add(3);
    myList1.Add(4);
    myList1.Add(5);
    myList1.Add(5);
    myList1.Add(5);
    myList1.Add(2);
    myList1.Add(2);

    // A benefit of realizing the ICollection interface
    // is that we can iterate over elements of lists now:
    foreach (var item in myList1)
    {
      Console.Write(item + " ");
    }
    Console.WriteLine("");

    Console.Write(
      "We removed an occurence of 1: "
        + myList1.Remove(1)
        + ".\n"
    );
    foreach (var item in myList1)
    {
      Console.Write(item + " ");
    }
    Console.WriteLine("");

    Console.Write(
      "We removed an occurence of 10: "
        + myList1.Remove(10)
        + ".\n"
    );
    foreach (var item in myList1)
    {
      Console.Write(item + " ");
    }
    Console.WriteLine("");

    Console.WriteLine(
      "Our list is read-only: " + myList1.IsReadOnly + "."
    );
    myList1.IsReadOnly = true;
    Console.WriteLine(
      "Our list is read-only: " + myList1.IsReadOnly + "."
    );
    try
    {
      myList1.Add(12);
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.Message);
    }
    try
    {
      myList1.Remove(1);
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.Message);
    }

    int[] array = new int[15];
    try
    {
      myList1.CopyTo(array, 6);
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.Message);
    }

    array[0] = -10;
    myList1.CopyTo(array, 1);
    Console.WriteLine("The array contains:");
    foreach (int i in array)
    {
      Console.Write(i + " ");
    }
    // Last, we test the RemoveL method
    myList1.IsReadOnly = false;
    Console.WriteLine("\nThe list contains:");
    foreach (int i in myList1)
    {
      Console.Write(i + " ");
    }
    for (int i = 0; i < myList1.Count; i++)
    {
      try
      {
        Console.WriteLine(
          "\nValue removed: " + myList1.RemoveL()
        );
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
    }

    Console.WriteLine("\nThe list contains:");
    foreach (int i in myList1)
    {
      Console.Write(i + " ");
    }
  }
}
