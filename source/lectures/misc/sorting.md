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


## Algorithm Comparison

The algorithms we are about to study compare [as follows](https://en.wikipedia.org/wiki/Sorting_algorithm#Comparison_of_algorithms):

Name | Best | Average | Worst | Memory | Stable | In-place | 
--------- | --- | --- | --- | --- | --- | --- | 
Insertion sort | n | $n^2$ | $n^2$ | 1 | Yes | Yes |
Heapsort | $n \log n$ | $n \log n$ | $n \log n$ | 1 | No | Yes |
Bubble sort | n | $n^2$ | $n^2$ | 1 | Yes | Yes |
Shellsort | $n (\log n)^2$ | $n (\log n)^2$ | $n (\log n)^2$ | 1 | No | Yes | 
Quicksort | $n \log n$ | $n \log n$ | $n^2$ | $\log n$ | No | Yes | 
Selection sort | $n^2$ | $n^2$ | $n^2$ | 1 | No | Yes | 
Merge sort | $n \log n$ | $n \log n$ | $n \log n$ | n | Yes | No | 

## Helper Methods

We start by defining two simple "helper" methods:

```
!include`snippetStart="// Helper methods", snippetEnd="// Done with helpers method."` code/projects/Sorting/Sorting/Sorting.cs
```

## Insertion Sort Algorithm

### Implementation

This algorithm is [nicely explained and illustrated on wikipedia](https://en.wikipedia.org/wiki/Insertion_sort), and can be implemented as follows:

```
!include`snippetStart="// Insertion Algorithm", snippetEnd="// Done with insertion Algorithm"` code/projects/Sorting/Sorting/Sorting.cs
```

### Description

This algorithm moves the `bar` from the beginning of the list to the end, one by one.
At every step, it position a `slot` on the bar and look *back*, moving the value at the `slot` earlier and earlier on as long as its predecessor is smaller than itself.

### Complexity

[As explained on wikipedia](https://en.wikipedia.org/wiki/Insertion_sort#Best,_worst,_and_average_cases), the simplest worst case input is an array sorted in reverse order. 
With an array sorted in reverse order, every iteration of the inner loop will scan and shift the entire sorted subsection of the array (i.e., from `bar` to the beginning) before inserting the next element. This gives a quadratic running time (i.e., $O(n^2)$). 

## Heapsort Algorithm

### Implementation

We first define some helper methods:

```
!include`snippetStart="// Helper methods for Heapsort", snippetEnd="// Done with helper methods for Heapsort"` code/projects/Sorting/Sorting/Sorting.cs
```

and then leverage the heap structure to sort:

```
!include`snippetStart="// Heapsort algorithm", snippetEnd="// Done with heapsort algorithm"` code/projects/Sorting/Sorting/Sorting.cs
```

Note that `PercDown` builds a *max heap*: once the values are "pre-sorted **greater value first**", removing the first one to move it to the *end* of the list makes the list sorted from smallest to greatest value once we are done.

### Description

This algorithm works in two steps:

- First, it constructs the heap "in-place", by arranging the elements from the last-to-lower level (`listP.Count / 2` corresponds to "the last parent") to the first level (`i >=0`), in increasing order (i.e., this is a max heap, the greater value is first),
- Then, it recursively extract the first element, and place it after the end of the heap: note that `PercDown(listP, 0, i)` makes it so that the heap is considered to stop at index `i`, as it decreases in size by 1 at every iteration.

### Complexity

- The `PercDown` method has complexity $O(\log(n))$, since it iterates through the tree from top to bottom, i.e., it is relative to the tree height, which is $O(\log(n))$.
- The first step calls `PercDown` $n / 2$ times, which is equivalent to $O(n)$, so overall this first step is $O(n \times \log(n))$.
- The second step also calls `PercDown` $n$ times, so it is overall $O(n \times \log(n))$ as well.

Hence, the complexity of heapsort is $O(n \times \log(n))$ by [the sum rule](./docs/programming_and_computer_usage/complexity#simplifications).

## Bubble Algorithm

### Implementation

```
!include`snippetStart="// Bubble Algorithm", snippetEnd="// Done with bubble algorithm."` code/projects/Sorting/Sorting/Sorting.cs
```

### Description

The nested loop accomplishes the following: "from the beginning of the list to where I stopped the last time -1, go through the elements one by one and swap them if needed".

### Complexity

Since both loops depends on the size of the list, $n$, the algorithm is overall $O(n^2)$: we need to perform $n$ times $n$ operations.

## ShellSort Algorithm

### Implementation

```
!include`snippetStart="// ShellSort Algorithm", snippetEnd="// Done with shellSort algorithm."` code/projects/Sorting/Sorting/Sorting.cs
```

### Description

Consider a list of size 30, we have (assuming `current.CompareTo(listP[slot - gap]) < 0` is always `true`):

`gap` | `next`  | `slot`  | `slot - gap`
  ----     |  ----       | -----       | -----       |
11 | 11 | 11 | 0
" | 12 | 12 | 1
" | 13 | 13 | 2
… | … | … | … |
" | 22 | 22 | 11
" | " | 11 | 0
" | 23 | 23 | 12
" | " | 12  | 1
… | … | … | … |
11 | 30 | 30 | 19
" | " | 19 | 8
5 | 5 | 5 | 0
" | " | 6 | 1 
" | " | 7 | 2
… | … | … | … |
" | 10 | 10 | 5
" | 10 | 5 | 0
" | 11 | 11 | 6
" | " | 6 | 1 
… | … | … | … |
2 | 
… | … | … | 
1 | 

The important point is to understand that we generate the sequences
- *Gap of 11*: (11, 0), (12, 1), (13, 2), … (22, 11), (11, 0),  (23, 12), (12, 1), (30, 19), (19, 8), 
- *Gap of 5*: (5, 0), (11, 6), (6, 1), …

which are sequences of values we are comparing. 
After we are done going through "the $i$ gap", we know that all values $i$ indices apart are sorted.
Reducing the value of $i$ to $1$ makes it so that the whole array is sorted.


### Complexity


