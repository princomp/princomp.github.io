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
- One case use [open addressing](https://en.wikibooks.org/wiki/Data_Structures/Hash_Tables#Open_addressing) so that "the next available index" is used.

## Possible Implementation

### Preliminaries

Implementing dictionaries requires some preliminaries:  prime numbers, [enumerated types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum), and the built-in [`GetHashCode` method](https://learn.microsoft.com/en-us/dotnet/api/system.object.gethashcode).

We first illustrate prime numbers with the following class, [remembering that](https://en.wikipedia.org/wiki/Prime_number)

> A prime number is a natural number greater than 1 that is not a product of two smaller natural numbers.

```{download="./code/projects/Dictionary_prelim.zip"}
!include code/projects/Dictionary_prelim/Dictionary_prelim/PrimeHelper.cs
```

We can then declare a `Level` enumerated type, and demonstrate how to use it, our PrimeHelper `static` class, and a couple of examples using `GetHashCode`:

```{download="./code/projects/Dictionary_prelim.zip"}
!include code/projects/Dictionary_prelim/Dictionary_prelim/Program.cs
```

### Using Open Addressing


```{download="./code/projects/Dictionary.zip"}
!include code/projects/Dictionary/Dictionary/Dictionary.cs
```

```{download="./code/projects/Dictionary.zip"}
!include code/projects/Dictionary/Dictionary/PrimeHelper.cs
```

```{download="./code/projects/Dictionary.zip"}
!include code/projects/Dictionary/Dictionary/Program.cs
```


<!--
/*
 * Why prime numbers are needed is explained for example
 * at
 * https://cs.stackexchange.com/questions/11029
 */
-->
