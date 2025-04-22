using System;

class Program
{
  static void Main(string[] args)
  {
    /* Example. */
    // We first create an empty CList of int:
    CList<int> myList1 = new CList<int>();
    // Then we add its first element:
    myList1.AddF(12);
    // Adding another element adds it before (to the left)
    myList1.AddF(10);
    // After this statement, our CList contains 10 then 12.
    myList1.AddF(2);
    myList1.AddF(2);
    myList1.AddF(1);
    myList1.AddF(1);
    myList1.AddF(3);
    myList1.AddF(4);
    myList1.AddF(5);
    myList1.AddF(5);
    myList1.AddF(5);
    myList1.AddF(2);
    myList1.AddF(2);
  }
}
