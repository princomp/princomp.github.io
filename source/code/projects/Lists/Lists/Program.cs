using System;
using System.Collections.Generic;

class Program
{
  static void Main()
  {
    // We create an (empty) list of strings, and a list of ints
    // containing 1, 2 and 3.
    List<string> nameList = new List<string>();
    List<int> valueList = new List<int>() { 1, 2, 3 };
    // We count the elements and add to the list of strings.
    Console.WriteLine(
      "nameList has " + nameList.Count + " element."
    );
    nameList.Add("Bob");
    Console.WriteLine(
      "nameList has " + nameList.Count + " element."
    );
    nameList.Add("Sandrine");
    Console.WriteLine(
      "nameList has " + nameList.Count + " elements."
    );
    // We can access the first element with [0].
    // Reading it:
    Console.WriteLine(nameList[0]);
    // Writing it:
    nameList[0] = "Robert";
    // The following is incorrect:
    // nameList[2] = "Sandrine";
    // Accessing using foreach:
    foreach (string name in nameList)
    {
      Console.WriteLine(name);
    }
    // Removing an element:
    nameList.RemoveAt(0);
    // also shrink the list.
    // Creating a new example
    List<int> valueList2 = new List<int>()
    {
      -1,
      0,
      1,
      2,
      3,
      2,
      5,
    };
    // and then removing the first 1 in it:
    valueList2.Remove(1);
    // Testing if 0 was removed:
    if (valueList2.Remove(0))
    {
      Console.WriteLine("0 was removed.");
    }
    // and finally removing the first occurrence of 2:
    valueList2.Remove(2);
    // so that the list contains:
    foreach (int element in valueList2)
    {
      Console.Write(element + ",");
    }
    // -1,3,2,5
  }
}
