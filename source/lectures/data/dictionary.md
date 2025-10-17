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

- *a hash function*, which transforms the key into an `int` (its *hash*), used as an array index, 
- *a collision resolution strategy*, which handles when two *different* keys have been assigned the same hash by the hash function.

## Possible Implementation

### Using Open Addressing

A description is given at <https://en.wikibooks.org/wiki/Data_Structures/Hash_Tables#Open_addressing>.

```{download="./code/projects/Dictionary.zip"}
!include code/projects/Dictionary/Dictionary/Dictionary.cs
```

```{download="./code/projects/Dictionary.zip"}
!include code/projects/Dictionary/Dictionary/PrimeHelper.cs
```

```{download="./code/projects/Dictionary.zip"}
!include code/projects/Dictionary/Dictionary/Program.cs
```
