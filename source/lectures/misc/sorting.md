---
tags:
- datatypes
---

# Sorting Algorithms

## Motivation

[Wikipedia](https://en.wikipedia.org/wiki/Sorting_algorithm) explains it very nicely: sorting is ubiquitous in Computer Sciences. 
It is a simple problem ("*How can I sort the following values the most efficiently?*") that has many solutions, but still offers open problems.

We only consider **correct** algorithms, i.e., one where their output is such that

- each element is larger than or equal to the previous one, according to the order picked,
- all the elements that were in the input are present in the output (with the same cardinality, if repetition is allowed).

There are many ways of "comparing" sorting algorithms.
A sorting algorithm…

- has a best, worst and average case time complexity (measured in general in number of comparisons required),
- has a best, worst and average case space complexity (i.e., "how much additional memory is required?"),
- can be "stable" (i.e., equal values are not permutted),
- uses *insertion*, *exchange*, *selection*, *merging* method,
- is serial or parallel,

among other properties.

# Insertion Sort Algorithm


```
!include`snippetStart="// Insertion Algorithm", snippetEnd="// Done with insertion Algorithm"` code/projects/Sorting/Sorting/Sorting.cs
```

# Heapsort Algorithm

We first define some helper methods:

```
!include`snippetStart="// Helper methods for Heapsort", snippetEnd="// Done with helper methods for Heapsort` code/projects/Sorting/Sorting/Sorting.cs
```

```
!include`snippetStart="// Heapsort Algorithm", snippetEnd="// Done with heapsort Algorithm` code/projects/Sorting/Sorting/Sorting.cs
```
