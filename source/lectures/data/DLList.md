---
tags:
- datatypes/collections
---

# Doubly Linked List

## Motivation

We can implement the list abstract datatype using *doubly linked lists*.

The main differences with *singly* linked list are as follows:

- Instead of keeping only track of the first element (`first`), we keep track of both the first (`head`) and last (`tail`) elements.
- Each `Cell` contains a pointer to the "next" element (as before), but also to the "previous" element.
- Adding (or removing) to the right is now done in constant time, instead of linear time.
- Traversing the list in opposite order (from end to beginning, or right to left) is now straightforward (cf. the `ToString` method).
- The rest of the edits are about bookkeeping the `Previous` and `Next` attributes of the `Cell`, as well as updating the `tail` attribute. This makes removing and adding "in the middle of the list" a bit tricky.

## Implementation

Our implementation of doubly linked list realizes the ICollection interface:

```{download="./code/projects/DLList_ICollection.zip"}
!include code/projects/DLList_ICollection/DLList_ICollection/DLList.cs
```
