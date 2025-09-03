using System;

class Program
{
  static void Main(string[] args)
  {
    /* Simple example. */
    DLList<int> myList1 = new DLList<int>();
    Console.WriteLine(myList1);
    myList1.Add(15);
    myList1.Add(5);
    myList1.Add(2);
    myList1.Add(2);
    myList1.Add(1);
    Console.WriteLine(myList1);

    myList1.RemoveI(3);
    Console.WriteLine(myList1);

    myList1.RemoveF();
    Console.WriteLine(myList1);
    myList1.RemoveL();
    Console.WriteLine(myList1);

    myList1.RemoveI(1);
    Console.WriteLine(myList1);

    myList1.Clear();
    myList1.Add(1);
    myList1.Add(3);
    myList1.Add(4);
    myList1.Add(5);
    myList1.Add(5);
    myList1.Add(5);
    myList1.Add(2);
    myList1.Add(22);
    Console.WriteLine(myList1);
    Console.WriteLine("Removed 3: " + myList1.Remove(3));
    Console.WriteLine(myList1);
    Console.WriteLine("Removed 21: " + myList1.Remove(21));
    Console.WriteLine(myList1);
    Console.WriteLine("Removed 2: " + myList1.Remove(2));
    Console.WriteLine(myList1);
    Console.WriteLine("Removed 1: " + myList1.Remove(1));
    Console.WriteLine(myList1);
    Console.WriteLine("Removed 22: " + myList1.Remove(22));
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
    /*
     * Testing Remove in detail
     */

    // Trying to remove from an empty list.
    DLList<string> myList3 = new DLList<string>();
    Console.WriteLine(myList3);
    Console.WriteLine(
      "Remove \"test\": " + myList3.Remove("Test")
    );
    Console.WriteLine(myList3);

    // Trying to remove the only element of a list.
    myList3.Add("Test");
    Console.WriteLine(myList3);
    Console.WriteLine(
      "Remove \"test\": " + myList3.Remove("Test")
    );
    Console.WriteLine(myList3);

    // Trying to remove the first element of a list of size 2.
    myList3.Add("Test");
    myList3.Add("String 1");
    Console.WriteLine(myList3);
    Console.WriteLine(
      "Remove \"test\": " + myList3.Remove("Test")
    );
    Console.WriteLine(myList3);

    // Trying to remove the last element of a list of size 3.
    myList3.Add("String 2");
    myList3.Add("Test");
    Console.WriteLine(myList3);
    Console.WriteLine(
      "Remove \"test\": " + myList3.Remove("Test")
    );
    Console.WriteLine(myList3);

    // Trying to remove an  element that is not in a list.
    Console.WriteLine(myList3);
    Console.WriteLine(
      "Remove \"test\": " + myList3.Remove("Test")
    );
    Console.WriteLine(myList3);

    // Trying to remove an element in the middle of a list of size 5.
    myList3.Add("Test");
    myList3.Add("String 3");
    myList3.Add("String 4");
    Console.WriteLine(myList3);
    Console.WriteLine(
      "Remove \"test\": " + myList3.Remove("Test")
    );
    Console.WriteLine(myList3);
  }
}
