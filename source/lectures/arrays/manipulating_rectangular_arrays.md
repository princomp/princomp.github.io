---
tags:
- datatypes/collections
---

# Manipulating Rectangular Arrays

We present below some simple algorithms to manipulate 2-dimensional (rectangular) arrays.
The code for this lecture is available [in this archive](./code/projects/MagicSquare.zip).


## Summing the values row per row

The following code sum the values contained in a 2-dimensional array row per row, and display the result each time before moving on to the next row:

```
!include`snippetStart="// Summing the values row per row", snippetEnd="As an exercise, you can"` code/projects/MagicSquare/MagicSquare/Program.cs
```

This code can easily be adapted to compute the sums _column per column_ if needed.

## Computing Magic Square

A [magic square](https://en.wikipedia.org/wiki/Magic_square) is a square matrix where the sums of the numbers in each row, each column, and both the diagonal and the anti-diagonal are the same.

The following is an example of a magic square:

```
!include`snippetStart="// Examples courtesy of https://en.wikipedia.org/wiki/Magic_square", snippetEnd="// Check by hand that this square is indeed magic!"` code/projects/MagicSquare/MagicSquare/Program.cs
```

as we have, diagonally,
$$4+5+6=15$$

and anti-diagonally,
$$2+5+8=15$$

and on the rows,
$$4+9+2=15$$
$$3+5+7=15$$
$$8+1+6=15$$

and finally on the columns
$$4+3+8=15$$
$$9+5+1=15$$
$$2+7+6=15$$

A method to return `true` if the 2d-matrix of `int` passed as an argument is a magic square is as follows:

```
!include code/projects/MagicSquare/MagicSquare/MagicSquare.cs
```

