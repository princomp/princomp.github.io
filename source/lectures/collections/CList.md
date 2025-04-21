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

A "custom" implementation of list can be found [in this project](./code/projects/CList.zip), the following notes detail and explain this code.

## Getting Started

Consider the following code:

```{download="./code/projects/CList.zip"}
!include code/projects/CList_Intro/CList/CList.cs
```

The first two important observations are that

- Our `CList` class uses a [generic type parameter](https://princomp.github.io/lectures/oop/generic_types) (the `<T>` notation), so that we can create `CList`s containing `bool`, `int`, `char`, etc.,
- Our `CList` class contains itself a class, called `Cell`.

Let us discuss the `Cell` class briefly. A `Cell` has two properties:

- `Data`, of type `T`, will hold the actual data: if we are creating a `CList` of `int`s, then each cell will hold an `int` in its `Data` property,
- `Next`, of type `Cell`, which contains a reference to the next `Cell`.

A `Cell` holding `12` and `null` will be represented as follows:

!include diag/flo/Cell1.md

Intuitively, a `Cell` holds a piece of value (`Data`) and the "address" (more precisely, the reference) to the next cell: "linking" cells together is what gives *(singly) linked lists*, which is the [correct technical term](https://en.wikipedia.org/wiki/Linked_list#Singly_linked_list) for the type of list we are implementing (there are other ways of implementing lists).

Now, let us zoom back and look at the `CList` class: a `CList` object has only one attribute, called `first`, which is a `Cell`. 
When a `CList` object is created, then its `first` `Cell` is simply `null`, as follows:

!include diag/flo/CListNull.md


!include diag/flo/CList1.md
