---
tags:
- datatypes/collections
---

# Introduction

Arrays are structures that allow you to store multiple values in memory using a single name and indexes.
Internally, an array contains a fixed number of variables (called *elements*) of a particular type^[Usually, all the elements of an array have the same type, but an array can store elements of different types if `object` is its type, since any element is actually of type `object`.].
The elements in an array are always stored in a contiguous block of memory, providing fast and efficient access.

An array can be:

- Single-Dimensional,
- Multidimensional.

Multidimensional arrays can be 

- Jagged,
- Rectangular.

Arrays are useful, for instance,

- When you want to store a collection of related values,
- When you do not know in advance how many variables will be needed,
- When you need a large number of variables (say, 10) of the same type,
- When you want to represent matrices (as you can use an array of arrays to represent 2-dimensional objects).
