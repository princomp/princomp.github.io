---
tags:
- datatypes/collections
---

# Custom Implementation of Lists

Our goal is to provide our own implementation of Lists, instead of using [the one provided by C#'s `System.Collections.Generic` namespace](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-9.0).
This will help in

- understanding how a simple *data structure* is implemented,
- understanding the differences between arrays and lists,
- developing simple algorithms traversing lists,
- visually representing how lists operate.

The "custom" implementation of list can be found [in this project](./code/projects/CList_Intro.zip), it is also extended [in this project](./code/projects/CList.zip) with many additional methods.

## Getting Started

Consider the following code:

```{download="./code/projects/CList_Intro.zip"}
!include code/projects/CList_Intro/CList/CList.cs
```

The first two important observations are that

- Our `CList` class uses a [generic type parameter](https://princomp.github.io/lectures/oop/generic_types) (the `<T>` notation), so that we can create `CList`s containing `bool`, `int`, `char`, etc.,
- Our `CList` class contains itself a class, called `Cell`.

### Cell Class

Let us discuss the `Cell` class briefly. A `Cell` has two properties:

- `Data`, of type `T`, will hold the actual data: if we are creating a `CList` of `int`s, then each cell will hold an `int` in its `Data` property,
- `Next`, of type `Cell`, which contains a reference to the next `Cell`.

A `Cell` holding the `Data` of type `int` `12` and that has for `Next` value the `Cell` `null` will be represented as follows:

!include diag/flo/Cell1.md

Intuitively, a `Cell` holds a piece of value (`Data`) and the "address" (more precisely, the reference) to the next `Cell`: "linking" `Cell`s together is what gives *(singly) linked lists*, which is the [correct technical term](https://en.wikipedia.org/wiki/Linked_list#Singly_linked_list) for the type of list we are implementing (there are other ways of implementing lists).

### CList Class

### Creating an object

Now, let us zoom back and look at the `CList` class: a `CList` object has only one attribute, called `first`, which is a `Cell`. 
When a `CList` object is created, using for example the following:

```
!include`snippetStart="// We first create an empty CList of int:", snippetEnd="// Then we add its first element:"` code/projects/CList_Intro/CList/Program.cs
```

then its `first` `Cell` is simply `null`:

```
!include`snippetStart="// By default, a CList contains only an empty cell.", snippetEnd="// A Cell is itself two things:"` code/projects/CList_Intro/CList/CList.cs
```

We represent this situation as follows:

!include diag/flo/CListNull.md

### Adding a Cell to a CList

To start adding elements to our `CList` `myList1`, we use the `AddF` method:

```
!include`snippetStart="// We call it AddF for 'Add First'.", snippetEnd="// The updated CList starts with a cell holding dataP and"` code/projects/CList_Intro/CList/CList.cs
```

as follows:

```
!include`snippetStart="// Then we add its first element:", snippetEnd="// Adding another element adds it before (to the left)"` code/projects/CList_Intro/CList/Program.cs
```

This method does the following:

#. It creates a `Cell` hoding `dataP` as its data, the "previous" `first` as its `Next`,
#. It updates `first` so that it refers this new `Cell`.

We would represent this situation as follows:

!include diag/flo/CList1.md

Note that

- Our `CList` now contains two `Cell`s objects, the second being `null`,
- `first` now refers a `Cell` that actually contains a value, `12`.

We can add another element to our list using the following statement:

```
!include`snippetStart="// Adding another element adds it before (to the left)", snippetEnd="// After this statement, our CList contains 10 then 12."` code/projects/CList_Intro/CList/Program.cs
```

and our `myList1` becomes:

!include diag/flo/CList2.md

Note that the element is added *to the left*, that is, the `CList` "grows" from the left using the `AddF` method.

## More Advanced Methods and Properties

### IsEmpty Method and Property

We will often need to test if a `CList` is empty, so we introduce a method to perform this test easily:

```
!include`snippetStart="// a method for that:", snippetEnd="// A method to add a cell at the end"` code/projects/CList/CList/CList.cs
```

Note that we could have decided to implement this test as a property, using for example

```
public bool IsEmpty
{
    get {return first == null;}
}
```

Of course, such property would not have any `set` method: it is not up to the user to decide if the `CList` is empty.

### AddL Method

Our `AddF` method allows to add elements to our `CList` "to the left", but we may want to add elements to *the end* of the list (that is, to its right).
We can achieve this with the following method:

```
!include`snippetStart="// We call it AddL for 'Add Last'.", snippetEnd="// Property for the size of the CList."` code/projects/CList/CList/CList.cs
```

The method proceeds as follows:

- If the `CList` is empty, then we can use `AddF`, since adding to the right or to the left will have the same outcome,
- If it is not, we need to find the "last" `Cell`. Finding the "last" `Cell` is easy: it is the only one whose `Next` is `null`. We move through the list as follows:

    ```
    Cell cCell = first;
    while (cCell.Next != null)
    {
        cCell = cCell.Next;
    }
    ```

    The idea being that as long as the current `Cell` contains a `Next` that is not `null`, then we follow it and make the next cell our current `Cell`.
- Once we found this "last" `Cell`, we update its `Next` so that it refers to a new `Cell` object that contains the data we wanted to insert (`dataP`), and does not refers to any other `Cell` (hence, its `Next` is `null`).

### Size Property

It can be useful to easily know how many non-`null` `Cell`s are contained within a `CList`: this is the equivalent of the `Count` property from [C#'s List](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.count?view=net-9.0#system-collections-generic-list-1-count).
Of course, this property should only contain a `get`, since the `Size` will be computed based on the number of elements contained in the `CList`, so that we get:

```
!include`snippetStart="// Property for the size of the CList.", snippetEnd="// We can implement a ToString method"` code/projects/CList/CList/CList.cs
```

This property uses a loop very similar to the `AddL` method to traverse the `CList`, but it keeps track of how many elements were traversed using a `size` index. Note that it begins by testing if the `CList` is empty: otherwise, the condition `cCell.Next != null` would throw an exception with an empty `CLists`, since `null` does *not* posses a `Next` property!

### ToString Method

We also implement a `ToString` method that returns a table looking like an array:

```
!include`snippetStart="//  if we were drawing an array).", snippetEnd="// Method to obtain the nth element if it exists."` code/projects/CList/CList/CList.cs
```

Our previous `myList1` would then be displayed as follows:

```text
———————————
| 10 | 12 |
———————————
```

Observe that:

- We use the `Size` property to draw the lines above and below our table, repeating the same code twice.
- The string `"———"` is added once to the line above and once to the line below the table to improve the final rendering.
- Our loop uses the `cCell != null` condition, testing if a `Cell` is `null` before trying to access its `Data` property. Note that `cCell` will hold `null` at some point, but no exception will be raised since our condition makes the loop terminates when that happens.
- Attempting to call `ToString` with a `CList` containing only the `null` `Cell` would return

    ```text
    ———
    |
    ———
    ```

    which is not very elegant, but at least no exception is raised.

## Additional Methods and Properties

Additional methods are shared in the following source code:

```{download="./code/projects/CList.zip"}
!include`snippetStart="// Method to obtain the nth element if it exists.", snippetEnd="/* Some other methods that can be implemented are:"` code/projects/CList/CList/CList.cs
```
