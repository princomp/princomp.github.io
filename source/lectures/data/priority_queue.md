---
tags:
- datatypes/collections
---

# Priority Queues

## Introduction

### Abstract Data Type

Described [abstractly](./lectures/data/intro#abstract-data-types), [a priority queue](https://en.wikipedia.org/wiki/Priority_queue) is (the differences with queue are **in bold**):

- a finite collection of elements, **endowed with a priority**
- in **no** particular order,
- that may contain the same element multiple times.

Generally, it has operations to…

- … create an empty priority queue,
- … test for emptiness, 
- … add an element **with a given priority**,
- … remove the element **with the highest priority**,
- … **increase the priority of a particular element**.

Letting a greater priority means "more important" is called a *max-priority queue*, it is also possible to implement *min-priority queue*, where the most element important are the ones with the lowest priority.
In both cases, a decision must be made if multiple elements have the same priority: we can decide arbitrarily, using the element value, take the "first one" in the structure, etc.

Exactly like a people waiting **at the ER**, priority queues implement a **"most-important-in-first-out"** principle.

## Possible Implementation

### Using Arrays

Here is an implementation of priority queues using arrays:

```{download="./code/projects/PQueue_array.zip"}
!include code/projects/PQueue_array/PQueue/PQueue.cs
```

This implementation as the following performance:

- `Add` is $O(n)$, it may take $n$ steps to find an empty slot,
- `MinPriority` is also $O(n)$, we will have to go through the entire array to find the `Cell` with the highest priority.
- `Peek` and `Extract` both rely on `MinPriority`, so they are also $O(n)$.

### Using Lists

An implementation using lists would be very similar to the one using array, except that `Add` would be $O(c)$, since inserting in a list can simply be done at the beginning.

### Using Heaps

A maximally efficient implementation of priority queues is given by [heaps](https://en.wikipedia.org/wiki/Heap_(data_structure)).

<!--

Heap definitions. The binary heap is a data structure that can efficiently support the basic priority-queue operations. In a binary heap, the items are stored in an array such that each key is guaranteed to be larger than (or equal to) the keys at two other specific positions. In turn, each of those keys must be larger than two more keys, and so forth. This ordering is easy to see if we view the keys as being in a binary tree structure with edges from each key to the two keys known to be smaller.

Definition. A binary tree is heap-ordered if the key in each node is larger than (or equal to) the keys in that nodes two children (if any).

Proposition. The largest key in a heap-ordered binary tree is found at the root. 


 We can impose the heap-ordering restriction on any binary tree. It is particularly convenient, however, to use a complete binary tree like the one below.

Heap representations
We represent complete binary trees sequentially within an array by putting the nodes with level order, with the root at position 1, its children at positions 2 and 3, their children in positions 4, 5, 6 and 7, and so on.

Definition. A binary heap is a set of nodes with keys arranged in a complete heap-ordered binary tree, represented in level order in an array (not using the first entry).

Heap representations 
-->
