using System;

class Program
{
  static void Main(string[] args)
  {
    /* Simple example. */
    CList<int> myList1 = new CList<int>();
    Console.WriteLine(myList1);
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
    Console.WriteLine(myList1);

    // A benefit of realizing the ICollection interface
    // is that we can iterate over elements of lists now:
    foreach (var item in myList1)
    {
      Console.WriteLine(item);
    }

    Console.WriteLine(
      "Our list is read-only:" + myList1.IsReadOnly + "."
    );
    myList1.IsReadOnly = true;
    Console.WriteLine(
      "Our list is read-only:" + myList1.IsReadOnly + "."
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
  }
}
