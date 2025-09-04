---
tags:
- datatypes/collections
---

# The Stack collections

## Introduction

### Abstract Data Type

Described [abstractly](./lectures/data/intro#abstract-data-types), [a stack](https://en.wikipedia.org/wiki/Stack_(abstract_data_type)) is 

- a finite collection of elements,
- in a particular order,
- that may contain the same element multiple times.

The fact that it may contain the same element multiple times makes it different from a set, the fact that it is ordered makes it different from a [multiset](https://en.wikipedia.org/wiki/Multiset).

Generally, it has operations to…

- … create an empty list,
- … test for emptiness, 
- … obtain the value of the element at "the top" of the stak ("peek"),
- … add an element at "the top" of the stack ("push"),
- … remove an element at "the top" of the stack ("pop").

The fact that only the "top element" can be accessed is the main difference with the list abstract data type.
Exactly like a stack of plates, stacks implement a "last in, first out" (LIFO) principle.

### Difference with array 

Like lists, the `Stack` class serves a similar purpose than arrays, but with a few notable differences:

- Stacks do not need to have a number of elements fixed ahead of time,
- Stacks automatically expand when elements are added,
- Stacks automatically shrink when elements are removed.

### Difference with lists

However, the `Stack` class is also different from lists:

- Only the top element can be read,
- Adding and removing can only be done "on the right side", that is, at the top of the stack.

## Possible Implementation

### Using Cells

Here is a possible implementation of stacks, using cells:

```{download="./code/projects/CStack.zip"}
!include code/projects/CStack/CStack/CStack.cs
```


### Using Arrays

Another implementation, using arrays, requires the stack to have a fixed size:

```{download="./code/projects/CAStack.zip"}
!include code/projects/CAStack/CAStack/CAStack.cs
```
