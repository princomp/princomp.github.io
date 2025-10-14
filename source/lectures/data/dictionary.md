---
tags:
- datatypes/collections
- oop
---

# Dictionaries

## Introduction

### Abstract Data Type

A *dictionary*, also called a *hash*, an *associative array*, a *map*, or a *hashmap*, is a key-value store: it stores values (that can be of any type) and indexes them using a key (which is in general of a simple type, such as `int`).

Described [abstractly](./lectures/data/intro#abstract-data-types), [a dictionary](https://en.wikipedia.org/wiki/Hash_table)) is 

- a finite collection of elements,
- in *no* particular order,
- that may contain the same element multiple times.

The fact that it may contain the same element multiple times makes it different from a set, the fact that it is ordered makes it different from a [multiset](https://en.wikipedia.org/wiki/Multiset).

Generally, it has operations to…

- … create an empty dictionary,
- … test for emptiness, 
- … insert or update a value,
- … remove a key-value pair,
- … test for existence of a key.


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
