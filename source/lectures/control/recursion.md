---
tags:
- control-structures/iteratives
---

# Recursion

The code for this lecture is available [in this archive](./code/projects/RecursionHelloWorld.zip) (first parts) and [this one](./code/projects/ListDirectoriesFileRecursively.zip) (listing files and folders recursively).

## Introduction

Recursion is a central notion in programming, simple to state but difficult to master: a method is *recursive* if it calls itself.
This concept is related to the idea of repetition, or looping, of program parts, and come with the same danger of not terminating.
Below, we present some simple recursive programs: while some could be written without recursion, some would be very hard, if possible at all, to write without using recursion.

## First Examples

Consider the following:

```
!include`snippetStart="// Displays numbers from n to 1", snippetEnd="// Displays numbers from 1 to n"` code/projects/RecursionHelloWorld/RecursionHelloWorld/Program.cs
```

If we call `displayAll(3);`, then the following will happen:

#. `displayAll(3)` will test that `3>0`,
#. `displayAll(3)` will display "3 ",
#. `displayAll(3)` will call `displayAll(2)`,
    #. `displayAll(2)` will test that `2>0`,
    #. `displayAll(2)` will display "2 ",
    #. `displayAll(2)` will call `displayAll(1)`,
        #. `displayAll(1)` will test that `1>0`,
        #. `displayAll(1)` will display "1 ",
        #. `displayAll(1)` will call `displayAll(0)`,
            #. `displayAll(0)` will test that `0>0`, 
            #. `displayAll(0)` will terminate.
        #. `displayAll(1)` will terminate.
    #. `displayAll(2)` will terminate.
#. `displayAll(3)` will terminate.

Hence, `displayAll` calls itself with a smaller number, unless that number is 0, in which case it simply terminates.
In our example, it would display "3 2 1 ".

*When* the function calls itself matters a lot. Indeed, consider `displayRAll`, which calls itself *before* executing the `Console.WriteLine` instruction:

```
!include`snippetStart="// Displays numbers from 1 to n", snippetEnd="// Recursive multiplication"` code/projects/RecursionHelloWorld/RecursionHelloWorld/Program.cs
```

If we call `displayRall(3);`, then the following will happen:

#. `displayRall(3)` will test that `3>0`,
#. `displayRall(3)` will call `displayRall(2)`,
    #. `displayRall(2)` will test that `2>0`,
    #. `displayRall(2)` will call `displayRall(1)`,
        #. `displayRall(1)` will test that `1>0`,
        #. `displayRall(1)` will call `displayRall(0)`,
            #. `displayRall(0)` will test that `0>0`, 
            #. `displayRall(0)` will terminate.
        #. `displayRall(1)` will display "1 ",
        #. `displayRall(1)` will terminate.
    #. `displayRall(2)` will display "2 ",
    #. `displayRall(2)` will terminate.
#. `displayRall(3)` will display "3 ",
#. `displayRall(3)` will terminate.

In this example, "1 2 3 " would be displayed: the order is reversed with respect to `displayAll`!

| ❗ Caution |
|:---------------------------|
| Recursion can be very powerful and can very easily make your program crash or misbehave. To see it for yourself, *after saving all important documents*, replace `-` with `+` in the previous examples and run the programs again. |

## Recursive Methods Returning a Value

Recursive methods can also return a value, used by previous calls to compute some other value.

### Multiplication

For example, consider that multiplication can be defined by addition: indeed, $x × y$ is $y + y + y + … + y$ where $y$ is summed $x$ times. Stated differently (read: recursively), $x × y$ is $y + ((x - 1) × y)$.
We can implement such a program easily:

```
!include`snippetStart="// Recursive multiplication", snippetEnd="// Recursive factorial"` code/projects/RecursionHelloWorld/RecursionHelloWorld/Program.cs
```

For example, `mult(2, 10)` tests that `2` is neither 0 nor 1, and adds 10 with the result of `mult(1, 10)`, which is 10 since the first argument is 1.

Observe that `mult(10000000, 0)` would call `mult` 10000001 times and add 0 to itself 10000001 times: this algorithm is not very efficient!

### Factorial

The factorial of $n$ is $n! = n × (n-1) × (n-2) × (n-3) × … × 1$.
This function can easily be implemented using recursion:

```
!include`snippetStart="// Recursive factorial", snippetEnd="// An improvment would be to replace"` code/projects/RecursionHelloWorld/RecursionHelloWorld/Program.cs
```

Note that this code actually compute e.g., $5! = 5 × 4 × 3 × 2 × 1 × 1$ (with one superfluous $× 1$): can you see why?

## Listing Files and Directories -- Recursively

While multiplication and factorial can be implemented without recursion, some structures makes it natural, or even required, to use recursion.
Going through folders and files is an example of such situation.

```
!include code/projects/ListDirectoriesFileRecursively/ListDirectoriesFileRecursively/Program.cs
```

<!--
`snippetStart="// https://stackoverflow.com/a/929277", snippetEnd="// An improvment would be to replace"
-->

Note that our previous examples were calling themselves only once per method call, but that `ListDir` calls itself as many times as there are folders in the folder currently examined.
