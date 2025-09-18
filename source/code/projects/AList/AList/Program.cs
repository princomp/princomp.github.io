using System;

class Program
{
  static void Main(string[] args)
  {
    AList<int> myList1 = new AList<int>();

    /* Testing IsEmpty(), Clear() and Count. */
    Console.WriteLine(
      "The list is empty: " + myList1.IsEmpty()
    ); // Should display "True".
    Console.WriteLine("List size: " + myList1.Count); // Should display "0".
    myList1.Add(10);
    Console.WriteLine(
      "The list is empty: " + myList1.IsEmpty()
    ); // Should display "False".
    Console.WriteLine("List size: " + myList1.Count); // Should display "1".
    myList1.Clear();
    Console.WriteLine(
      "The list is empty: " + myList1.IsEmpty()
    ); // Should display "True".
    Console.WriteLine("List size: " + myList1.Count); // Should display "0".
    myList1.Add(10);
    myList1.Remove(10);
    Console.WriteLine(
      "The list is empty: " + myList1.IsEmpty()
    ); // Should display "True".
    Console.WriteLine("List size: " + myList1.Count); // Should display "0".

    /* Adding more elements, and then displaying the list.*/
    for (int i = 0; i < 15; i++)
    {
      myList1.Add(i);
    }

    // A benefit of realizing the ICollection interface
    // is that we can iterate over elements of lists now:
    foreach (var item in myList1)
    {
      Console.Write(item + " ");
    }
    Console.WriteLine("");
    Console.WriteLine("List size: " + myList1.Count); // Should display "15".

    /* Adding "from the rigt" */
    for (int i = -10; i < 0; i++)
    {
      myList1.AddR(i);
    }
    foreach (var item in myList1)
    {
      Console.Write(item + " ");
    }
    Console.WriteLine("");
    Console.WriteLine("List size: " + myList1.Count); // Should display "15".

    /* Testing Remove in more detail.*/

    // 1. Removing a value that is present one time.
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

    // 2. Removing a value that is present three times.
    myList1.Add(1);
    myList1.Add(1);
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

    // 3. Removing a value that is not in the list.
    Console.Write(
      "We removed an occurence of 20: "
        + myList1.Remove(20)
        + ".\n"
    );
    foreach (var item in myList1)
    {
      Console.Write(item + " ");
    }
    Console.WriteLine("");

    /*
     * Advanced testing:
     * IsReadOnly and CopyTo.
     */
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
    try
    {
      myList1.Clear();
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.Message);
    }

    /* Testing copying into an array.*/
    int[] array = new int[myList1.Count + 1];
    try
    {
      myList1.CopyTo(array, 6);
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.Message);
    }
    // We insert a dummy value
    // into the array that will receive
    // a copy of the list at index 1.
    array[0] = -10;
    myList1.CopyTo(array, 1);
    Console.WriteLine("The array contains:");
    foreach (int i in array)
    {
      Console.Write(i + " ");
    }
  }
}
