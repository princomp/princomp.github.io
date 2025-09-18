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
- The *depth of a node* is the distance (i.e., the number of times we must go to its parent) from it to the root. This means in particular that the depth of a root is $0$.
- The *depth of a tree* is the greatest distance of its nodes.
- A *subtree* is the tree obtain by considering a particular node in a tree as the root of the tree made of all the nodes "below" it, starting with its children.

From there, operations generally include, as usual

- Creating an empty tree,
- Adding a node to a tree,
- Finding the smallest value in the tree,
- Removing a node from the tree, 
- etc.

In the following example:

!include diag/gra/bstree_example_1_with_depth.md

- The root has value 10,
- The root has two children, 7 and 11,
- The leaf with value 5 has $0$ children,
- The node with value 11 has one child (30): we call it "the right child", and observe that 11 has no "left child",
- The depth of the tree is 3,
- The nodes 7, 5 and 8 taken together form a subtree.

## Possible Implementation

### Binary Tree

#### Node Class

Defining a `BTree` class start by defining a `Node` class:

```{download="./code/projects/Tree.zip"}
!include`snippetStart="// We begin by defining a node class.", snippetEnd="// We can now define the BTree class"` code/projects/Tree/Tree/BTree.cs
```

As we can see, a `Node` has three elements:

- `Data` is the value it is holding,
- `left` denotes its "left child",
- `right` denotes its "right child".

If we wanted to be more technically correct in our drawing, we would explicitly label some nodes as `null`, and the previous tree would actually be as follows:

!include diag/gra/bstree_example_1_with_null.md

#### Initializing

Then, a `BTree` object is simply … the `root` `Node`, and we can construct, empty, and test for emptiness accordingly:

```{download="./code/projects/Tree.zip"}
!include`snippetStart="// are relying on the root Node.", snippetEnd="// We now look at how to"` code/projects/Tree/Tree/BTree.cs
```

#### Computing the Depth

Now, assume that we are given a `BTree` object. How can we compute its depth?
Its depth is the depth of the "deeper" node, but each node do not know their depth, only that they have 0, 1 or 2 children.
Of course, if the `BTree` is `null`, then deciding its depth is easy: it is $0$.
Then, the idea is that each node knows that its depth is $1$ more than the depth of its parent: remains to find which node has the biggest depth.
For this, we will use *recursion*.

In short, for a tree to determine its node, it needs to 

- Have its `root` "ask its children" what their deepest node is,
- Take the maximum value returned.

For the `root`'s children to determine what the deepest node under them is, they need both to

- "Ask its children" what is their deepest node,
- Take the maximum value returned.

Etc., etc. Hence, we get:

```{download="./code/projects/Tree.zip"}
!include`snippetStart="// compute the Depth of a tree.", snippetEnd="// Finding is also recursive."` code/projects/Tree/Tree/BTree.cs
```

#### Displaying Trees

#### Implementation Detail

We implemented the binary tree class abstractly, because two methods are still missing: how to insert a value, and how to delete a value (we will add them later on).
This is the reason why we marked the `Node` class as `protected`, and not private: it will still be accessible by the class inheriting from `BTree`.

#### Finding a Value

We also mark the `Find` method as `virtual` because we will override it for something more efficient.
Note, finally, that we use the `protected` keyword, so that classes inheriting the `BTree` class will be able to manipulate `Node`s.


```{download="./code/projects/Tree.zip"}
!include`snippetStart="// Finding is also recursive.", snippetEnd="// Done with finding."` code/projects/Tree/Tree/BTree.cs
```

### Binary Search Tree

A binary *search* tree (BST) is a specific type of binary tree that ensures that

- each node's value is greater than all the values stored in its left subtree, 
- each node's value is less than all the values stored in its right subtree, 
- a value cannot occur twice.
 
```{download="./code/projects/Tree.zip"}
!include code/projects/Tree/Tree/BSTree.cs
```
