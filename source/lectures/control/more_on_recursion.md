---
tags:
- control-structures/iteratives
---

# More on Recursion

The code for this lecture is available [in this archive](./code/projects/RecursionHelloWorld.zip) (first parts) and [this one](./code/projects/ListDirectoriesFileRecursively.zip) (listing files and folders recursively).

## Re-Introduction

We previously defined recursion as follows:

>  a method is *recursive* if it calls itself.

Applied very strictly, the simplest (and most likely shortest) recursive method is the following:

```
!include`snippetStart="// Simplest possible example of a recursive function:", snippetEnd="// Uncomment at your own risk!"` code/projects/AdvancedRecursion/AdvancedRecursion/Program.cs
```

It is a method (`R`) that simply … calls itself. Even if this method does not "do" anything, calling it will most likely make your program crash, since `R` will keep calling itself forever: this is actually an example of an infinite loop.

A better definition of recursion would include something about the method eventually terminating, like the following:

```
!include`snippetStart="// Recursive CountDown method:", snippetEnd="// Usage example:"` code/projects/AdvancedRecursion/AdvancedRecursion/Program.cs
```

In that case, if we call e.g., `CountDown(10)`, then would be displayed:

```text
10…9…8…7…6…5…4…3…2…1…0: Blast off!
```

But note that this method is not _always_ terminating: indeed, calling `CountDown(-1)` actually loops forever, since removing 1 to -1 repetitively will never make it reach 0 (if we forget about overflows for an instant).

A possible way to patch this would be to have two additional method: one to count "up" to 0, and one that decides which method to call:

```
!include`snippetStart="// Recursive CountUp method", snippetEnd="// Mutually recursive methods"` code/projects/AdvancedRecursion/AdvancedRecursion/Program.cs
```

As we can see, `Count` itself is *not* recursive, but it calls a recursive method.

Finally, methods can be *mutually recursive*: a method `MyTurn` can call a `YourTurn` method that itself calls `MyTurn`. While neither method are recursive, they create a recursive situation, as exemplified below:

```
!include`snippetStart="// Mutually recursive methods", snippetEnd="// Usage example"` code/projects/AdvancedRecursion/AdvancedRecursion/Program.cs
```

Note that determining how many time both methods will be executed may not be easy: in our example, if `MyTurn(4)` is called, can you determine what will be displayed?

## Arrays and Recursion

Any structure over which we can iterate can be treated using recursion, and arrays are no exception.
In the following, we will re-implement two simple methods using recursion: one to decide if an array is sorted, and one that implements binary search.

### Sorted Array Using Recursion

Given an array and a current index, to determine if the array *is sorted*, one can:

- Make sure that the array to the left of the current index *is sorted*,
- Make sure that the value at the current index is less than the value at the next index,
- Make sure that the array to the right of the current index *is sorted*.

Note that our definition above is recursive: *being sorted* is defined using *being sorted*.

Assuming the array is sorted up to `currentIndex`, the following will return `true` if the rest of the array is sorted, `false` otherwise:

```
!include`snippetStart="// Sorted method helper", snippetEnd="// Sorted method"` code/projects/AdvancedRecursion/AdvancedRecursion/Program.cs
```

The first test check if we are done (in which case the array *is* sorted), the second compare the value at the current index with the one that follows, and the last one kicks in the reduction by stipulating that if the other two tests failed, then the array is sorted if the rest of the array is.

Compared to our informal above, we are missing the "making sure the left of the current index is sorted" bit, *unless* we start with current index … 0!
Putting it all together, we can define `Sorted` calling the recursive `SortedH` method with the right arguments (and after performing some checks):

```
!include`snippetStart="// Sorted method", snippetEnd="// Examples"` code/projects/AdvancedRecursion/AdvancedRecursion/Program.cs
```

### Binary Search Using Recursion

We can perform [binary search](./lectures/arrays/search#binary-search) using recursion:

```
!include`snippetStart="// Binary Search helper", snippetEnd="// Examples"` code/projects/AdvancedRecursion/AdvancedRecursion/Program.cs
```

## Lists and Recursion

Lists are also naturally manipulated by recursive methods.
We show, as an example, two ways of defining a method that construct a `string` describing a .NET list.

```
!include`snippetStart="// Recursive way of displaying lists", snippetEnd="// Examples"` code/projects/AdvancedRecursion/AdvancedRecursion/Program.cs
```

Note that the `DisplayH` method is a bit cumbersome, as it must carry around

#. The whole list (`listP`),
#. The string that is being constructed (`retString`),
#. An index (`indexP`).

An alternative way of writing such a method is to

#. shorten the list as we go (using `RemoveAt`),
#. and to use a *reference* to the string,

as follows:

```
!include`snippetStart="// Using reference and recursion to display lists", snippetEnd="// Example."` code/projects/AdvancedRecursion/AdvancedRecursion/Program.cs
```

**But note that the list is *actually* shortened** by the `RemoveAt` instruction: if we additionally have to leave the original string unmodified, then a copy of the list must be created, using e.g.

```
!include`snippetStart="// Note that we create a copy of the list.", snippetEnd="// We now call the method with the copy of the list."` code/projects/AdvancedRecursion/AdvancedRecursion/Program.cs
```
