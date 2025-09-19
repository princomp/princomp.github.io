---
tags:
- datatypes/collections
---

# The trees collections

## Introduction

A [binary tree](https://en.wikipedia.org/wiki/Binary_tree) is a precise mathematical concept that can be defined as a restriction on graphs.
As an abstract data type, it generally uses the following definitions:

- A binary tree is made of *nodes*, each of which holds *one value*, can have up to 2 *children*.
- A (rooted) binary tree has exactly one node with 0 parent (that is not the child of any other node), called *the root*. Except for the root, all the nodes have exactly one parent.
- A node without children is called *a leaf*.
- The *depth of a node* is the distance (i.e., the number of times we must go to its parent) from it to the root. This means in particular that the depth of the root is $0$.
- The *depth of a tree* is the maximum depth of the nodes it contain.
- A *subtree* is the tree obtain by considering a particular node in a tree as the root of the tree made of all the nodes "below" it, starting with its children.

From there, operations generally include, as usual

- Creating an empty tree,
- Adding a node to a tree,
- Finding the smallest value in the tree,
- Removing a node holding a specific value from the tree, 
- etc.

In the following example:

!include diag/gra/bstree_example_1_with_depth.md

- The root holds the value 10,
- The root has two children, holding the values 7 and 11,
- The node holding the value 5 has $0$ children, hence it is a leaf,
- The node with value 11 has one child (holding the value 30): we call it "the right child", and observe that the node holding the value 11 has no "left child",
- The depth of the tree is $4$,
- The nodes holding the values 7, 5 and 8 taken together form a subtree, of depth $1$.

## Possible Implementation

### Binary Tree

We implemented the binary tree class abstractly, because two methods will be missing at the beginning: how to insert a value, and how to delete a value (we will add them later on, in a class that will inherit from this `BTree` class).
This is the reason why we mark the `Node` class as `protected` below, and not `private`: it will still be accessible by the class inheriting from `BTree`.

#### Node Class

Defining a `BTree` class start by defining a `Node` class:

```{download="./code/projects/Tree.zip"}
!include`snippetStart="// We begin by defining a node class.", snippetEnd="// We can now define the BTree class"` code/projects/Tree/Tree/BTree.cs
```

As we can see, a `Node` has three elements:

- `Data` is the value it is holding,
- `left` denotes its "left child" (which is a `Node`, possibly `null`),
- `right` denotes its "right child" (which is a `Node`, possibly `null`),

If we wanted to be more technically correct in our drawing, we would explicitly label some nodes as `null`, and the previous tree would actually be as follows:

!include diag/gra/bstree_example_1_with_null.md

#### Initializing

A `BTree` object is simply the `root` `Node`, and we can construct, empty, and test for emptiness accordingly:

```{download="./code/projects/Tree.zip"}
!include`snippetStart="// are relying on the root Node.", snippetEnd="// We now look at how to"` code/projects/Tree/Tree/BTree.cs
```

#### Computing the Depth of the tree

Now, assume that we are given a `BTree` object. How can we compute its depth?
Its depth is the maximum depth of the nodes it contain.
However, only the root knows its depth (it is $0$), all the other nodes do not know their depth, only that they have 0, 1 or 2 children.

Of course, if the `BTree` is `null` or if its `root` has $0$ children, then deciding its depth is easy: it is $0$.
Otherwise, the idea is that each tree knows that its depth is $1$ more than the depth of the its two sub-trees: remains to find which sub-tree has the biggest depth.
For this, we will use *recursion*.

In short, for a tree to determine its node, it needs to 

- Have its `root` "ask its children" what their deepest node is,
- Take the maximum value returned.

For the `root`'s children to determine what the deepest node under them is, they need both to

- "Ask their children" what is their deepest node,
- Take the maximum value returned.

Etc., etc. Hence, we get:

```{download="./code/projects/Tree.zip"}
!include`snippetStart="// compute the Depth of a tree.", snippetEnd="// Finding is also recursive."` code/projects/Tree/Tree/BTree.cs
```

Note that we have *two* recursive calls: one for the `left` `Node`, one for the `right` `Node` (if they are not `null`).

#### Displaying Trees

There are essentially three ways of "linearizing" a tree (that is, listing its value in a sequence), depending how we organize the recursive calls.

- *Inorder* traversal displays 
    - First the left sub-tree,
    - Secondly the data held by the current node,
    - Thirdly the right sub-tree.

    For our recurring example, we obtain "5 7 8 10 11 12 15 30".
    
- *Preorder* traversal displays 
    - First the data held by the current node,
    - Secondly the left sub-tree,
    - Thirdly the right sub-tree.

    For our recurring example, we obtain "10 7 5 8 11 30 12 15".
    
- *Postorder* traversal displays 
    - First the left sub-tree,
    - Secondly the right sub-tree,
    - Thirdly the data held by the current node.

    For our recurring example, we obtain "5 8 7 15 12 30 11 10".
    
The code for all three methods will be extremely similar, the only difference is the order in wich we make the recursive calls and add the data held by the current node to the string returned:    

```{download="./code/projects/Tree.zip"}
!include`snippetStart="/* Traversal methods. */", snippetEnd="/* Done with traversal methods. */"` code/projects/Tree/Tree/BTree.cs
```

#### Finding a Value

Finding a value is also a recursive process: a `BTree` will contain a value `dataP` if…

- its root hold `dataP`,
- its right- or left-subtree contain `dataP`.

The subtrees will determine if they hold `dataP` by determining if

- their roots hold `dataP`,
- their right- or left-subtrees contain `dataP`.

As we can see, we once again need to have a method with two recursive calls:

```{download="./code/projects/Tree.zip"}
!include`snippetStart="// Finding is also recursive.", snippetEnd="// Done with finding."` code/projects/Tree/Tree/BTree.cs
```

Finally, observe that we mark the `Find` method as `virtual` because we will override it for something more efficient once we look at binary *search* trees.

### Binary Search Tree

A binary *search* tree (BST) is a specific type of binary tree that ensures that

- each node's value is greater than all the values stored in its left subtree, 
- each node's value is less than all the values stored in its right subtree, 
- a value cannot occur twice.

Our recurring example happens to be a binary search tree: 

- All the values "to the left of" the root are less than $10$, 
- All the values "to the right of" the root are greater than $10$,
- All the values "to the left of" the left child of the root are less than $8$,
- All the values "to the right of" the left child of the root are greater than $8$,
- etc.

Note that this is the reason why the node with value $30$ is drawn "to the right of" the node with value $11$: we always need to make the difference between left and right children, even if there is only one child.
A tree almost identical to our recurring example, but where $30$ was at the right of the node holding the value $11$ would not be a binary *search* tree, but simply a binary tree.

#### Implementation detail

Note that since we need to be able to compare our values, we must tell C# that we will not just be using any generic type `T`, but a type that realizes the [IComparable](https://learn.microsoft.com/en-us/dotnet/api/system.icomparable-1?view=net-9.0) interface.
This forces `T` to have a `CompareTo` method, that we will use to compare the data held by the nodes as follows:

```
dataP.CompareTo(nodeP.Data)
```

will return 

- a value less than $0$ if `dataP < nodeP.Data`,
- a value greater than $0$ if `dataP > nodeP.Data`.

Similarly to the `Equals` method, this is because the `>` and `<` operators are not overloaded by default, so we must use this more convoluted way of determining if `dataP` is less than or greater than `nodeP.Data`. Of course, if neither is `true`, it means that `dataP` is equal to `nodeP.Data`.

#### Insertion

To insert in a binary search tree, we must respect the binary *search* tree definition, meaning that we must:

- refuse to insert a value that is already present,
- insert a value "in its right place", i.e., to the right of nodes containing smaller values, and to the left of nodes containing greater values.

```{download="./code/projects/Tree.zip"}
!include`snippetStart="// Inserting into a BSTree", snippetEnd="// Finding into a BSTree"` code/projects/Tree/Tree/BSTree.cs
```

Note that it implies that creating a `BSTree` by inserting, for example

- 10, 6, 13, 12 and 14
- 14, 12, 13, 6 and 10

will result in different trees.

!include diag/gra/bstree_example_2.md

!include diag/gra/bstree_example_3.md

To begin with, the first will have 10 on its root while the other will have 14!

#### Finding

To find a value in a binary search tree, we can leverage its principles to make only *one recursive call instead of two* (as in our previous `Find` method for `BTree`).
Indeed, if the value we are looking for is …

- the same as the value held by the current node, we are done,
- less than the value held by the current node, we only need to explore the left sub-tree,
- greater than the value held by the current node, we only need to explore the right sub-tree.

Similarly, finding the smallest value is easy: it will be the one held by the left-most node!


```{download="./code/projects/Tree.zip"}
!include`snippetStart="// Finding into a BSTree", snippetEnd="// Deleting from a BSTree"` code/projects/Tree/Tree/BSTree.cs
```

#### Deleting

Deleting is a more convoluted operation:
 
```{download="./code/projects/Tree.zip"}
!include`snippetStart="// Deleting from a BSTree", snippetEnd="// Done with deletion."` code/projects/Tree/Tree/BSTree.cs
```
