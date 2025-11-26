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

The algorithms we are about to study compare [as follows](https://en.wikipedia.org/wiki/Sorting_algorithm#Comparison_of_algorithms), omitting the $O(.)$, $\times$, and letting $n$ be the size of the list we have to sort:

Name | Best | Average | Worst | Memory | Stable | 
--------- | --- | --- | --- | --- | --- | 
Insertion sort | $n$ | $n^2$ | $n^2$ | $c$ | Yes | 
Heapsort | $n \log(n)$ | $n \log (n)$ | $n \log(n)$ | $c$ | No | 
Bubble sort | $n$ | $n^2$ | $n^2$ | $c$ | Yes | 
Shellsort | $n (\log(n))^2$ | $n (\log(n))^2$ | $n (\log(n))^2$ | $c$ | No | 
Quicksort | $n \log(n)$ | $n \log(n)$ | $n^2$ | $\log(n)$ | No |
Selection sort | $n^2$ | $n^2$ | $n^2$ | $c$ | No | 
Merge sort | $n \log(n)$ | $n \log(n)$ | $n \log(n)$ | $n$ | Yes |

All the algorithms above are in-place except for merge sort.

## Helper Methods

We start by defining two simple "helper" methods:

```{download="./code/projects/Sorting.zip"}
!include`snippetStart="// Helper methods", snippetEnd="// Done with helpers method."` code/projects/Sorting/Sorting/Sorting.cs
```

## Insertion Sort Algorithm

### Implementation

This algorithm is [nicely explained and illustrated on wikipedia](https://en.wikipedia.org/wiki/Insertion_sort), and can be implemented as follows:

```{download="./code/projects/Sorting.zip"}
!include`snippetStart="// Insertion Algorithm", snippetEnd="// Done with insertion Algorithm"` code/projects/Sorting/Sorting/Sorting.cs
```

### Description

This algorithm moves the `bar` from the beginning of the list to the end, one by one.
At every step, it position a `slot` on the bar and look *back*, moving the value at the `slot` earlier and earlier on as long as its predecessor is smaller than itself.

### Complexity

[As explained on wikipedia](https://en.wikipedia.org/wiki/Insertion_sort#Best,_worst,_and_average_cases), the simplest **worst** case input is an array sorted in reverse order. 
With an array sorted in reverse order, every iteration of the inner loop will scan and shift the entire sorted subsection of the array (i.e., from `bar` to the beginning) before inserting the next element. This gives a quadratic running time (i.e., $O(n^2)$), since `bar` is linear in `n`, and we iterate twice over it.

On the flip side, if the array is already sorted, then the algorithm is linear, since the inner loop will always execute just one time, giving an overall **best** performance of $O(n)$.

But **on average**, the algorithm remains in $O(n^2)$ since it will need to go through the list twice.

## Heapsort Algorithm

### Implementation

We first define a helper method:

```{download="./code/projects/Sorting.zip"}
!include`snippetStart="// Helper method for Heapsort", snippetEnd="// Done with helper method for Heapsort"` code/projects/Sorting/Sorting/Sorting.cs
```

and then leverage the heap structure to sort:

```{download="./code/projects/Sorting.zip"}
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
Note that the **average**, **worst** and **best** complexity are all the same!

## Bubble Algorithm

### Implementation

```{download="./code/projects/Sorting.zip"}
!include`snippetStart="// Bubble Algorithm", snippetEnd="// Done with bubble algorithm."` code/projects/Sorting/Sorting/Sorting.cs
```

### Description

The nested loop accomplishes the following: "from the beginning of the list to where I stopped the last time -1, go through the elements one by one and swap them if needed".

### Complexity

Since both loops depends on the size of the list, $n$, the algorithm is **on average** $O(n^2)$: we need to perform $n$ times $n$ operations.
An optimization (not presented here) that stops the inner loop when elements were not swapped allows to bring the **best** case performance of bubble sort to linear ($O(n)$).

## ShellSort Algorithm

### Implementation

```{download="./code/projects/Sorting.zip"}
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

The important point is to understand that we generate the sequences of pairs (`slot`, `slot-gap`) as follows:

- *Gap of 11*: (11, 0), (12, 1), (13, 2), … (22, 11), (11, 0),  (23, 12), (12, 1), (30, 19), (19, 8), 
- *Gap of 5*: (5, 0), (11, 6), (6, 1), …

which are sequences of values we are comparing. For the gap of 11, it means we do the following:

- First, we compare the values at indices 11 and 0, and swap them if needed,
- Then, we compare the values at indices 12 and 1, and swap them if needed,
- …
- Then, we compare the values at indices 30 and 19, and swap them if needed,
- If we did swap the values previously, then we compare the values at indices 19 and 8, and swap them if needed. 

After we are done going through "the $i$ gap", we know that all values $i$ indices apart are sorted.
Reducing the value of $i$ to $1$ makes it so that the whole array is sorted.

### Complexity

The complexity of shell sort depends with the "gap sequence" that is used. We use `listP.Count / 3 + 1`, `(listP.Count / 3 + 1) / 2`, `(listP.Count / 3 + 1) / 4`, …, `1`. 
This sequence follows Shell's original algorithm, and it is of complexity $O(n^2)$ in the **worst case**: indeed, we may need to explore $O(n)$ gaps, each requiring $O(n)$ swaps.
If the **best case**, if the array is already mostly sorted, then we still need to explore $O(n)$ gaps, but each gap takes only $O(\log(n))$ swaps, giving a $O(n \times \log(n))$ complexity.
On **average**, the complexity depends a lot on the sequence, but can be around $O(n^{1.5})$, which is still better than quadratic!

Playing with the gap sequence further can give a **best**, **worst** and **average** performance of $O(n \times (\log(n))^2)$!

## Quick Sort Algorithm

### Implementation


```{download="./code/projects/Sorting.zip"}
!include`snippetStart="// Quick sort algorithm", snippetEnd="// End of quick Sort algorithm"` code/projects/Sorting/Sorting/Sorting.cs
```
 
### Description

At a high level, the algorithm

- pick a "median" value (the pivot), at the middle of the list to be sorted,
- organize the list so that the values to the left of the pivot are smaller than the pivot, and the values greater than or equal to the pivot are to its right,
- then recursively call quicksort on the list on the left of the pivot, and on the list on the right of the pivot,
- when the lists left to be sorted are of size 1, we know that quicksort is done (a list of size 1 is sorted!), the list is sorted.

In detail, this algorithm works as follows:

- Choose a pivot: we use the `medianOfThree` method to select an element from the list as the pivot. Other ways of choosing the pivot exist, this "median-of-three" technique is optimal when no information about the ordering of the input is known. Note that this method actually sorts those three elements (at the beginning, center and end of the list to be sorted), and take the median one as the `pivot`,
- Partition the list: the `while (left <= right)` loop in `QuickSort` proceeds as follows:
  
    - It first look for the smallest `left` index such that `listP[left] > pivot`,
    - It then look for the greatest `right` index such that `pivot <= listP[right]` and `left <= right`,
    - At this point, we know that those values at `left` and `right` needs to be swapped (if `left < right`, i.e., they did not cross) and we swap them.
    
- When this loop is done, we know that `left` is where the `pivot` ought to be, it's the median value of the list we are sorting.
- We can then call `Quicksort` on the two sub-lists:
  - the one that goes from `leftP` to `left - 1` (i.e, the values to the left of the pivot),
  - the one that goes from `left + 1` to `rightP` (i.e, the values to the left of the pivot),

One subtlety is that we know that `left` is where the `pivot` value ought to be (we actually did not know where it should have been where we started, we simply made an educated guess): hence, it was swapped at the end of `medianOfThree` and back at the end of `Quicksort`.

### Complexity

The complexity of quick sort depends on how "lucky" we were when we picked the pivot value.
The **best case** is when the pivot always divides the array in two equal halves. Let $T(n)$ be the complexity of sorting a list of size $n$ using quicksort:

- We need to perform a linear ($O(n)$) number of comparison, to partition the values to the left and the right of the pivot, and then to sort each-sublist,
- To sort each sub-list, we need to first partition them, which takes $O(n/2)$ number of comparison,
- Then, sorting each sub-list takes $T(n / 2)$.
- So, we get that $T(n) = O(n) + 2 \times T(n / 2)$,
- Iterating this mechanism, we get that $T(n) = 2^k \times T(n/(2^k)) + k \times n$, for $n = 2^k$,
- Then, we get $k = \log(n)$ and $T(n) = n \times T(1) + n \times \log(n) = O(n \times \log(n))$.

The **average case** is also $O(n \times \log(n))$, but if we are unlucky with our pivot (which is always at the beginning or at the end of the list), then we have to keep on sorting a sub-list that is linear $n$ (we partition our list in lists of size $n-1$ and $1$), and we get a **worst case** complexity of $O(n^2)$.
