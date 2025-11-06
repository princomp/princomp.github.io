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
Our examples will use the [Emergency Severity Index](https://en.wikipedia.org/wiki/Emergency_Severity_Index), which ranges from 1 (most urgent) to 5 (less urgent).


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

A maximally efficient implementation of priority queues is given by [heaps](https://en.wikipedia.org/wiki/Heap_(data_structure)), which is

- A complete binary tree^[A complete binary tree is such that all levels are filled completely except the lowest level, which is filled from as left as possible.] (that we will represent in an array),
- Such that the priority of every (non-root) node is greater than the priority of its parent (remember that we are implementing a *min-priority queue*, so a lowest priority means "comes first").

Note that this is different from being a binary search tree.
We begin by explaining informally the main principles, before commenting on the implementation.

#### Representing complete binary trees using arrays

A [binary heap](https://en.wikipedia.org/wiki/Binary_heap) is often [implemented as an array](https://en.wikipedia.org/wiki/Binary_heap#Heap_implementation).
Consider the following binary tree (we will take the priority of the node to be its value in the following):

!include diag/gra/heap_example_1.md

It is a heap, but not a binary search tree. It can be represented as the following array:

Index |     0 |   1 |   2 |   3 |   4 |   5 |   6 |   7 | 
---   |   :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: |
Node  |`null` |   1 |   3 |   2 |   6 |   4 |   5 | `null` |

It can help to see the tree as follows^[Symbols courtesy of <https://gist.github.com/GeorgeHernandez/10dcbb5fd6ca8b087d169d5a44d72cd2>.]:

```text
1
└── 3
│   └──── 6
│   └────────4 
└──────2
       └──────── 5
       └────────────(null)
```

so that reading it right to left gives the array pictured above.

The reason why we start at index 1 and not 0 is because it makes the following calculation easier^[The difference can be looked up [on wikipedia](https://en.wikipedia.org/wiki/Binary_heap#Heap_implementation), it is mostly a matter of substracting or adding 1 at various places.].
Indeed, each element at index $i$ has

- its children at indices $2 \times i$ and $(2 \times i) + 1$,
- its parent at index $\lfloor i/2 \rfloor$ for $\lfloor \cdot \rfloor$ the floor function (i.e., $\lfloor 1.5 \rfloor = 1$).

#### Inserting into a heap

To insert an element to a heap, we perform the following steps:

1. Add the element to the bottom level of the heap at the leftmost open space (or "start" a new level if the last level is full).
2. Compare the added element with its parent; if they are in the correct order, stop.
3. If not, swap the element with its parent and return to the previous step.

Imagine we want to insert $-1$ in our previous example, we would:

- Add $-1$ as the right child of $2$, 
- Swap $-1$ and $2$, 
- Swap $-1$ and $1$,
- Be done.

In terms of array representation, we would obtain (with the values that changed **in bold**):

Index |     0 |   1 |   2 |   3 |   4 |   5 |   6 |   7 | 
---   |   :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: |
Node  |`null` |  **-1** |   3 |   **1** |   6 |   4 |   5 | **2** |


#### Deleting from a heap

Extracting the element with the lowest priority is easy: it is located at the root of the tree, or at index 1 in the array representation. 
The challenge is to restore "the heap property", which is done as follows:

1. Replace the root of the heap with the last element on the last level.
2. Compare the new root with its children; if they are in the correct order, stop.
3. If not, swap the element with one of its children and return to the previous step (swaping with the smaller child in a min-heap).

The 2nd and 3rd steps are called "percolate-down": the idea is that the element that is at the root will "go down" the heap by swapping with elements with smaller priority.
At each step, we compare its priority with its children priority, and swap it with the children with the lowest priority if it is lower than its own.
When both children have a higher than or equal priority to its own, we know we are done and can stop.

#### Implementing priority queue using heaps implemented as arrays


```{download="./code/projects/PQueue_heap.zip"}
!include code/projects/PQueue_heap/PQueue/PQueue.cs
```
