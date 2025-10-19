---
tags:
- datatypes/collections
- oop
---

# Dictionaries

## Introduction

### Abstract Data Type

A *dictionary*, also called a *hash*, an *associative array*, a *map*, or a *hashmap*, is a key-value store: it stores values (that can be of any type) and indexes them using a key (which is in general of a simple type, such as `int`).

Described [abstractly](./lectures/data/intro#abstract-data-types), [a dictionary](https://en.wikipedia.org/wiki/Hash_table) is 

- a finite collection of pair of elements (one key, one value),
- in *no* particular order,
- that may contain the same *value* multiple times (it *cannot* contain the same key twice, however).

Generally, it has operations to…

- … create an empty dictionary,
- … test for emptiness, 
- … insert or update a value,
- … remove a key-value pair,
- … test for existence of a key.

And, very importantly, it uses

- *a hash function*, which transforms the key into an `int` (its *hash*), used as to produce an array index, 
- *a collision resolution strategy*, which handles when two *different* keys have been assigned the same index.

### Overview

A dictionary organises the key-value pairs into an array by storing it in its corresponding index, computed using the hash of the key.
The main benefit of this approach is that looking if a key-value pair is already in the dictionary is immediate: it suffices to hash the key, and to look at the index obtained if the same key is already stored.
The main downside is that *multiple (different) keys can be assigned the same hash, and hence the same index*: indeed, since the keys that will be used is not known ahead of time, it is possible that different keys are assigned the same index. This is a *collision*, and there are two main ways of resolving it:

- One can use [chaining](https://en.wikibooks.org/wiki/Data_Structures/Hash_Tables#Chaining) so that the array actually contains *lists* of key-value pairs.
- One case use [open addressing](https://en.wikibooks.org/wiki/Data_Structures/Hash_Tables#Open_addressing) so that "the next available index" is used. To determine which "next index" should be used, we will need a *probe sequence strategy*, i.e., a way of deciding how the next index is computed.

## Possible Implementation

### Preliminaries

Implementing dictionaries requires some preliminaries:  prime numbers, [enumerated types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum), and the built-in [`GetHashCode` method](https://learn.microsoft.com/en-us/dotnet/api/system.object.gethashcode).

We first illustrate prime numbers with the following class, [remembering that](https://en.wikipedia.org/wiki/Prime_number)

> A prime number is a natural number greater than 1 that is not a product of two smaller natural numbers.

```{download="./code/projects/Dictionary_prelim.zip"}
!include code/projects/Dictionary_prelim/Dictionary_prelim/PrimeHelper.cs
```

We can then declare a `Level` enumerated type, and demonstrate how to use it, our PrimeHelper `static` class, and a couple of examples using `GetHashCode`:

```{download="./code/projects/ĉ.zip"}
!include code/projects/Dictionary_prelim/Dictionary_prelim/Program.cs
```

### Using Open Addressing

#### Setting-up

The first step in our definition of dictionary is to require *two* [generic type parameters](./lectures/oop/generic_types): one for the key (which will generally be simple, such as `int` or `string`), and one for the values.
We additional require that the datatype for keys realizes the `IComparable` interface:

```{download="./code/projects/Dictionary.zip"}
!include`snippetStart="// A Dictionary requires two generic types parameter.", snippetEnd="// We only need to assume that Keys can be compared."` code/projects/Dictionary/Dictionary/Dictionary.cs
```

We then define the `Cell` class, which we will use to store the key and value. A third attribute of the enumerated datatype `StatusType`, will be used to mark if the cell is empty, active or deleted: its purpose will become clearer later on.

```{download="./code/projects/Dictionary.zip"}
!include`snippetStart="// the status of a cell.", snippetEnd="// A dictionary is"` code/projects/Dictionary/Dictionary/Dictionary.cs
```

Then, a dictionary has only two attributes: an array of `Cell`s, and a probe sequence strategy of the `PSSType`.

```{download="./code/projects/Dictionary.zip"}
!include`snippetStart="// probe sequence strategy type.", snippetEnd="// Status Type will be used to mark"` code/projects/Dictionary/Dictionary/Dictionary.cs
```
```{download="./code/projects/Dictionary.zip"}
!include`snippetStart="// - and a probe sequence strategy.", snippetEnd="// The ToString method uses String.Format"` code/projects/Dictionary/Dictionary/Dictionary.cs
```

The default size of 31 and the reason why we are using the `NextPrime` method are discussed [further down](#array-size).

#### Computing the index

The next important bit is to decide where a pair key, value will be stored in the `table` array. For this, we need to compute a valid index based on the key, *knowing that we may have to solve conflicts*.
Hence, computing an index requires to 

- start from the hash of the key, as computed by `GetHashCode`,
- take its absolute value (since a `GetHashCode` can return negative values),
- "shift" the hash if a collision happened (possibly multiple times), by adding something to it,
- take the remainder of dividing this number by `table.Length`, to make sure we produce a "valid" index.

All together, this guarantee that the index we produced is positive, and less than `table.Length`.

We obtain the following, where the details of `CollisionResolution` are not important at this point: the crucial point is to note that if `countP` is 0, then no collision have occurred yet, and we do not shift the hash.

```{download="./code/projects/Dictionary.zip"}
!include`snippetStart="// how many collisions we met so far.", snippetEnd="// Done with GetIndex"` code/projects/Dictionary/Dictionary/Dictionary.cs
```

#### Adding an element

Adding an element is a lengthy process.
We simply require a key and a value, compute an index, store it into a variable `index`, and proceed as follows:

As long as the table contains a `Cell` at `index` whose status is not `Deleted` nor `Empty`,

- Increment the counter `count` that count the number of times we saw a conflict,
- Check if `count` reached the size of the array:
    - if that is the case, throw an exception: we saw as many collisions as there are slots in the array, meaning that the array is full,
    - otherwise, generate another `index`, knowing that we met `count` conflicts already.

Once we have reached this point (i.e., once we exit the `while` loop), we know that `index` refers to a place in the array that is either empty, 
        



```{download="./code/projects/Dictionary.zip"}
!include`snippetStart="// Adding an element", snippetEnd="// Done with adding an element"` code/projects/Dictionary/Dictionary/Dictionary.cs
```


<!--
https://en.wikibooks.org/wiki/Data_Structures/Hash_Tables#Open_addressing

https://github.com/dotnet/runtime/issues/38340


    /*
     * First, we find an empty cell (e.g. cell is null, status empty or deleted)
     * - We computer a possible index:
     *      - We first use GetHashCode() to generate a hash code,
     *      - then shift it using collisionR.
     * - We check if the cell at this index is available,
     * - If it is not, we try with the next one,
     * - If all cells are occupied, we throw an error.
     */

#### How is the size of the array decided? {#array-size}

<!--
/*
 * Why prime numbers are needed is explained for example
 * at
 * https://cs.stackexchange.com/questions/11029
 */
 
 Also why 31
-->


<!--


We then define the `Cell` class, which we will use to store the key and value. A third attribute of the enumerated datatype `StatusType`, will be used to mark if the cell is empty, active or deleted: its purpose will become clearer later on.

```{download="./code/projects/Dictionary.zip"}
!include`snippetStart="// the status of a cell.", snippetEnd="// A dictionary is "` code/projects/Dictionary/Dictionary/Dictionary.cs
```



```{download="./code/projects/Dictionary.zip"}
!include code/projects/Dictionary/Dictionary/Dictionary.cs
```

```{download="./code/projects/Dictionary.zip"}
!include code/projects/Dictionary/Dictionary/PrimeHelper.cs
```

```{download="./code/projects/Dictionary.zip"}
!include code/projects/Dictionary/Dictionary/Program.cs
```
-->

x

