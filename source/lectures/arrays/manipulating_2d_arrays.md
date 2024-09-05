---
tags:
- datatypes/collections
---

# Manipulating 2D Arrays

We present below some simple algorithms to manipulate 2-dimensional arrays.

## Summing the values row per row

The following code sum the values contained in a 2-dimensional array row per row, and display the result each time before moving on to the next row:

```
int[,] numbers =
    {
    {1, 2, 3, 4},
    {5, 6, 7, 8}
    };
int acc;
for (int row = 0; row < numbers.GetLength(0); row++)
    {
    acc = 0;
    for (int col = 0; col < numbers.GetLength(1); col++)
    {
        acc += numbers[row, col];
    }
    Console.WriteLine("Total for row #" + row + " is " + acc + ".");
}
```

This code can easily be adapted to compute the sums _column per column_ if needed.

## Computing Magic Square

*To be written*.

```
int[,] magicSquare = {
    { 4, 9, 2 }, { 3, 5, 7 }, {8, 1, 6}
};
```
