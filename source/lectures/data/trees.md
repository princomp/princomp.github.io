---
tags:
- datatypes/collections
---

# The trees collections

## Introduction

A [binary tree](https://en.wikipedia.org/wiki/Binary_tree) is a precise mathematical concept that can be defined as a restriction on graphs.
As an abstract data type, it generally uses the following definitions:

- A binary tree is made of *nodes*, each of which contain *one value*, can have up to 2 *children*.
- A (rooted) binary tree has exactly one node with 0 parent (that is not the child of any other node), called *the root*. Except for the root, all the nodes have exactly one parent.
- A *leaf* is a node *without children*.
- The *depth of a node* is the distance (i.e., the number of times we must go to its parent) from it to the root.
- The *depth of a tree* is the greatest distance of its nodes.
- A *subtree* is the tree obtain by considering a particular node in a tree as the root of the tree made of its children.

From there, operations generally include, as usual

- Creating an empty tree,
- Adding a node to a tree,
- Finding the smalles value in the tree,
- Removing a node from the tree,

<!--
### Abstract Data Type

### Difference with array 
-->

## Possible Implementation

### Binary Tree

We implement a binary tree class abstractly, because two methods will be missing: how to insert a value, and how to delete a value.
We also mark the `Find` method as `virtual` because we will override it for something more efficient.
Note, finally, that we use the `protected` keyword, so that classes inheriting the `BTree` class will be able to manipulate `Node`s.

```{download="./code/projects/Tree.zip"}
!include code/projects/Tree/Tree/BTree.cs
```

### Binary Search Tree

A binary *search* tree (BST) is a specific type of binary tree that ensures that

- each node's value is greater than all the values stored in its left subtree, 
- each node's value is less than all the values stored in its right subtree, 
- a value cannot occur twice.
 
```{download="./code/projects/Tree.zip"}
!include code/projects/Tree/Tree/BSTree.cs
```
