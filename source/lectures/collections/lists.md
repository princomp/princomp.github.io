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
- Lists require to have the `using System.Collections.Generic;` statement at the beginning of the file,
- Lists have many built-in methods.

The [complete description of the `List` class](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-9.0) describes all the useful methods, we simply give a quick overview below.

## Syntax

### Creation

The syntax to create an empty list of `string` named `nameList` and a list of `int` named `valueList` containing 1, 2 and 3 is:

```{download="./code/projects/Lists.zip"}
!include`snippetStart="// containing 1, 2 and 3.", snippetEnd="// We count the elements and add to the list of strings.", dedent=4` code/projects/Lists/Lists/Program.cs
```

### Adding Elements

Adding an element to the list is done using the `Add` method, and counting the number of elements is done using the `Count` property:

```
!include`snippetStart="// We count the elements and add to the list of strings.", snippetEnd="// We can access the first element with [0].", dedent=4` code/projects/Lists/Lists/Program.cs
```

Note that we did not need to resize the `nameList` manually: its size went from 0 to 1 after we added "Bob", and from 1 to 2 after we added "Sandrine".

### Accessing Elements

#### Using the indexer access operator

Accessing an element can be done using the same operator as with arrays (the `[]` operator, called ["indexer operator"](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/member-access-operators#indexer-operator-)):

```
!include`snippetStart="// Reading it:", snippetEnd="// Writing it:", dedent=4` code/projects/Lists/Lists/Program.cs
```

will display "Bob". Note that this syntax can be used to change the value of an element that already exist.
For example,

```
!include`snippetStart="// Writing it:", snippetEnd="// The following is incorrect:", dedent=4` code/projects/Lists/Lists/Program.cs
```

would replace the first value in the list ("Bob") with "Robert".

Note that while accessing or replacing an element using the `[]` operator inside a list is fine, *you cannot add new elements to the list using this syntax*. 
For example,

```
nameList[2] = "Sandrine";
```

would raise an exception since there is no third element to our list.

#### Using `foreach`

Another way of accessing the elements in a list is to use `foreach` loops:

```
!include`snippetStart="// Accessing using foreach:", snippetEnd="// Removing an element:", dedent=4` code/projects/Lists/Lists/Program.cs
```

### Removing Elements

An element can be removed from the list using the `RemoveAt` method.
If `nameList` contains "Robert" and "Sandrine", then after the following statement,

```
!include`snippetStart="// Removing an element:", snippetEnd="// also shrink the list.", dedent=4` code/projects/Lists/Lists/Program.cs
```

it would only contain "Sandrine" and its size would be 1. That is, the first element would be deleted and the list would shrink.

Another way of removing an element is to use the `Remove` method.
Suppose we have the following list:

```
!include`snippetStart="// Creating a new example", snippetEnd="// and then removing the first 1 in it:", dedent=4` code/projects/Lists/Lists/Program.cs
```

then using

```
!include`snippetStart="// and then removing the first 1 in it:", snippetEnd="// Testing if 0 was removed:", dedent=4` code/projects/Lists/Lists/Program.cs
```

would remove "1" from the list, and the list would become -1, 0, 2, 3, 2, 5.

Observe that `Remove` returns a `bool`, so that for instance the following

```
!include`snippetStart="// Testing if 0 was removed:", snippetEnd="// and finally removing the first occurrence of 2:", dedent=4` code/projects/Lists/Lists/Program.cs
```

would not only remove 0 from the list, but also display "0 was removed".

Finally, if the value is present multiple times in the list, then only its first occurrence is removed.
For example, if the list is -1, 2, 3, 2, 5, then after executing

```
!include`snippetStart="// and finally removing the first occurrence of 2:", snippetEnd="// so that the list contains:", dedent=4` code/projects/Lists/Lists/Program.cs
```

it would become -1, 3, 2, 5: observe that only the first occurrence of 2 was removed from the list.
