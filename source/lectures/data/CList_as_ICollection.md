---
tags:
- datatypes/collections
---

# List as ICollection

## Motivation

Another way of implementing lists is to make our class realize the [ICollection interface](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1?view=net-9.0).

Quoting [C# 12 in a Nutshell](https://www.albahari.com/nutshell/): 

> `ICollection<T>` is the standard interface for countable collections of objects. It provides the ability to determine the size of a collection (`Count`), determine whether an item exists in the collection (`Contains`), copy the collection into an array (`ToArray`), and determine whether the collection is read-only (`IsReadOnly`).

Its UML diagram is as follows:

!include diag/cla/ICollection.md

Providing a way of constructing a `IEnumerator<T>` object let C# iterate over our custom lists using `foreach`, so that we can for example write

```{download="./code/projects/CList_ICollection.zip"}
!include`snippetStart="// is that we can iterate over elements of lists now:", snippetEnd="// Done with first example."` code/projects/CList_ICollection/CList_ICollection/Program.cs
```

for `myList1` a `CList<int>` object.

Implementing interfaces is an excellent way of signaling to C# that our class respects certain convention on one hand, and to help programmer follow usual guidelines on the other.

## Implementation

In addition to signaling that our class realizes the interface, using `public class CList<T> : ICollection<T>`, we need to implement the following properties and methods:

```{download="./code/projects/CList_ICollection.zip"}
!include`snippetStart="/* Done with Cell.*/", snippetEnd="/* We are done realizing the ICollection class. */"` code/projects/CList_ICollection/CList_ICollection/CList.cs
```
