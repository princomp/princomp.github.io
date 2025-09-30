---
tags:
- datatypes/collections
---

# AVL trees

## Introduction

An [AVL tree](https://en.wikipedia.org/wiki/AVL_tree) (for **A**delson-**V**elsky and **L**andis, their two inventors) is a particular type of binary search tree, with the *self-balancing* property. In a nutshell, self-balancing trees always thrive to keep their height as small as possible when inserting and deleting values.

Indeed, consider a binary search tree using the `Insert` method defined previously to insert the values 1, 2, 3, …, 100 (in that order). Then we obtain a tree that is a line, with each node having at most 1 child.

!include diag/gra/bstree_example_6.md

The resulting tree has for height the number of nodes, 100 in this case.
Since looking up a value or inserting a value is linear in the height of the tree, this means that those operations takes 100 operations: the benefits of using a tree instead of a list is lost!

The resulting tree would be much more efficient if we were leveraging the property of binary search tree to "balance" the values and obtain something … more balanced, with a "maximal number of children" for each nodes.

!include diag/gra/bstree_example_7.md

This is precisely the point of AVL trees, which are binary search trees with the additional property:

> The heights of the two child subtrees of any node differ by at most one; if at any time they differ by more than one, rebalancing is done to restore this property.

where 

- the *height* of a node is the number of edges on the longest path from the node to a leaf.
- the *depth* of a node is the number of edges from the node to the tree's root node.

A good way of [remembering the difference](https://stackoverflow.com/q/2603692) is to observe that we measure the height of a person from toe (leaf) to head (root), while we measure the depth (of an ocean) from earth's surface (root) to ocean bed (leaf).

## Possible Implementation


```{download="./code/projects/AVLTree.zip"}
!include code/projects/AVLTree/AVLTree/AVLTree.cs
```
