---
tags:
- datatypes/collections
- oop
---

# Dictionaries

## Introduction

### Abstract Data Type

A *dictionary*, also called a *hash*, an *associative array*, a *map*, or a *hashmap*, is a key-value store: it stores values (that can be of any type) and indexes them using a key (which is in general of a simple type, such as `int` or `string`).

Described [abstractly](./lectures/data/intro#abstract-data-types), [a dictionary](https://en.wikipedia.org/wiki/Hash_table) is 

- a finite collection of pair of elements (one key, one value),
- in *no* particular order,
- that may contain the same *value* multiple times (it *cannot* contain the same key twice, however).

Generally, it has operations to…

- … create an empty dictionary,
- … test for emptiness, 
- … insert or update a key-value pair,
- … remove a key-value pair,
- … test for the existence of a key.

And, very importantly, it uses

- *a hash function*, which transforms a key into an `int` (its *hash*), used as to produce an array index, 
- *a collision resolution strategy*, which handles when two *different* keys have the same hash.

Note that the collision resolution strategy is useful only when two *different* keys have the same hash: a key should always get assigned the same hash, and since a key cannot be part of two different key-value pair, we should not try to resolve this conflict, but instead throw an exception.

### Overview

A dictionary organizes the key-value pairs into an array by storing it in its corresponding index, computed using the hash of the key.
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

Adding an element is a delicate process.
We only need a key and a value, and then we 

- make sure the dictionary does not already contain a key-value pair with the same key ([detailed below](#find)),
- compute an index, store it into a variable `index`, and proceed as follows:

    As long as the table contains a `Cell` at `index` whose status is not `Deleted` nor `Empty`, we

    - Increment the counter `count` that count the number of times we had to "look for a new index" (i.e., solve a conflict),
    - Check if `count` reached the size of the array:
        - if that is the case, throw an exception: we saw as many collisions as there are slots in the array, meaning that the array is full,
        - otherwise, generate another `index`, knowing that we met `count` conflicts already.

- once we have reached this point (i.e., we found a suitable `index`), we know that `index` refers to a place in the array that is either 
    
    - empty, in which case we can create a `Cell` object using the parameters,
    - with a status set to `deleted` or `empty`, and we can re-use it.

```{download="./code/projects/Dictionary.zip"}
!include`snippetStart="// Adding an element", snippetEnd="// Done with adding an element"` code/projects/Dictionary/Dictionary/Dictionary.cs
```

#### Finding a key {#find}

For `find`, we use a subroutine `FindI` that computes the index of a key if it exists, returns -1 otherwise.
The critical point is to understand that we *need to keep looking even if the cell is marked as `deleted`*.
We illustrate this [point below](#deleted).

```{download="./code/projects/Dictionary.zip"}
!include`snippetStart="// We use a bool Find sub-routine", snippetEnd="// Done with found."` code/projects/Dictionary/Dictionary/Dictionary.cs
```

#### Handling Deleting {#deleted}

The `Remove` method heavily relies on `FindI`:

```{download="./code/projects/Dictionary.zip"}
!include`snippetStart="// Removing relies also on Find:", snippetEnd="// Done with Remove"` code/projects/Dictionary/Dictionary/Dictionary.cs
```

The important aspect is to understand why we use the `Deleted` status instead of simply removing the `Cell`. There is one important reason for that.
Imagine the following scenario:

- We want to insert two key-value pairs with keys `"Mary"` and `"Lora"`. Both `GetIndex("Mary", 0)` and `GetIndex("Lora", 0)` return 6 (with an `table` of size 13).
- When we insert the value with key `"Mary"`, we use the index 6.
- When we insert the value with key `"Lora"`, we use `GetIndex("Lora", 1)` to generate a new index (its value will depend on the strategy that was picked, with the `Linear` method we would get 7 **if this index is available**, otherwise we would have to compute the next available index using `GetIndex("Lora", 2)`, and so on).
- We delete the value with key `"Mary"`, and then look for the value with key `"Lora"`. Our `Find` algorithm computes `GetIndex("Lora", 0)`, gets 6, look at `table[6]`. If our `Remove` method simply deleted the cell containing the key with value `"Mary"`, then our `Find` algorithm would conclude that no value with key `"Lora"` is in the `table`, since the index it computed is unoccupied.

This is the reason why we need to keep track of the deleted cells, to make sure `Find` will keep looking because it knows that possibly, when the value with key `"Lora"` was inserted, its index was already taken.

#### How is the size of the array decided? {#array-size}

The size of the array will in general be a prime number. This is discussed in detail [on stackexchange](https://cs.stackexchange.com/a/64191), but can be easily illustrated.
Let us assume that our dictionary

- uses an array of size 4 (so, *not* a prime number),
- uses the quadratic probe sequence strategy,
- receives one value with hash 1,
- then receives two values, both with hash 0.

The first value gets inserted at index 0, the second gets inserted at index 1. For the third value:

- The first index that `Insert` tries is 0, but a value is already there.
- The second index that `Insert` tries is $0 + (1 \times 1) = 1$, but it is taken already.
- The third index that `Insert` tries is $0 + (2 \times 2) = 4$, which gives … 0 modulo 4, 
- And then the sequence goes forever: 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, …

More generally, the quadratic probe sequence gives,

Table size | Probe sequence
--- | --- 
12 | 0, 1, 4, 9, 4, 1, 0, 1, 4, 9, …
13 | 0, 1, 4, 9, 3, 12, 10, 10, 12, 3, …

While still not ideal, we can see that using a prime number for the size allows to "break the cyclicity" every now and then and to obtain additional numbers in the sequence: we go from 4 different indices to 7 per 10 indexes.

The default size of 31 is picked for [various reasons](https://stackoverflow.com/questions/299304/why-does-javas-hashcode-in-string-use-31-as-a-multiplier), some being historical, 


#### Clustering

In general, the main goal is to avoid having parts of the array filled while other parts are left unused, a situation known as *clustering*.
This situation *will* happen if too many keys are given the same hash and index, something that is hard to predict since keys will in general not be uniformly distributed and not known ahead of time.
Linear probing is very bad in solving this problem, since the clusters are "spread out continuously", quadratic probing is an improvement, but only partially solve this issue, since keys with identical hashes will still follow teh same sequence. 
Double hashing is a bit better at solving this problem, since keys with identical hashes may drift apart significantly when the secondary hash function is applied.

This general discussion relates to performance and requires to measure the dictionary's load factor, which is the number of entries occupied in the hash table divided by the table length (or number of "buckets").
Of course, open-addressed hash table cannot have a load factor greater than 1, but other techniques, such as chaining, allows for larger load factors.

<!--
Double hashing, in which the interval between probes is computed by a secondary hash function

For open addressing schemes, the hash function should also avoid clustering, the mapping of two or more keys to consecutive slots. Such clustering may cause the lookup cost to skyrocket, even if the load factor is low and collisions are infrequent. The popular multiplicative hash is claimed to have particularly poor clustering behavior.[22][4]

https://www.javamex.com/tutorials/collections/hash_function_technical_2.shtml

cf. "Implementing Double Hashing" at <https://pressbooks.palni.org/anopenguidetodatastructuresandalgorithms/chapter/hashing-and-hash-tables/>
-->
