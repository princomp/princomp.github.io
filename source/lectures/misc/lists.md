---
tags:
- datatypes/collections
---

# The List collections

## Introduction

The `List` class serves a similar purpose than arrays, but with a few notable differences:

- Lists do not need to have a number of elements fixed ahead of time,
- Lists automatically expand when elements are added,
- Lists automatically shrink when elements are removed,
- Lists require to have the `using System.Collections.Generic;` statement at the beginning of the file.


## Snippet

```
List<string> nameList = new List<string>();
List<int> valueList = new List<int>() { 1, 2, 3 };

nameList.Add("Bob");
nameList.Add("Mary");

Console.WriteLine("nameList has " + nameList.Count + " elements.");

nameList[0] = "Sandrine";
//         nameList[2] = "Sandrine";
Console.WriteLine("nameList has " + nameList.Count + " elements.");
Console.Write(nameList[0]);

nameList.RemoveAt(0);
Console.Write(nameList[0]);

nameList.Remove("Mary");
Console.WriteLine("nameList has " + nameList.Count + " elements.");

nameList.Add("Bob");
nameList.Add("Mary");
nameList.Add("Bob");
nameList.Add("Jane");
nameList.Add("Bob");
Console.WriteLine("nameList has " + nameList.Count + " elements.");
nameList.Remove("Bob");
Console.WriteLine("nameList has " + nameList.Count + " elements.");
foreach (string name in nameList)
{
    Console.WriteLine(name); 
// Mary, Bob, Jane, Bob

}
```
