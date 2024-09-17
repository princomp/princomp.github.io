---
tags:
  - datatypes/collections
---

# Two-Dimensional Arrays

## Exercises

#. Write a statement that creates a 2-dimensional rectangular array of `int` with 5 rows and 3 columns.

    <details>
    <summary>Solution</summary>

    ```
    int[,] matrix = new int[5, 3];
    ```
    </details>

#. Write a statement that creates a 2-dimensional jagged array of `int` with 2 rows. The first row should contain an array containing 1, the second row should contain an array containing 2, 3.

    <details>
    <summary>Solution</summary>

    ```
    int[][] jaggedArray = new int[2][];
    jaggedArray[0] = new int[1] { 1 };
    jaggedArray[1] = new int [2]{ 2, 3};
    ```
    
#. Suppose we have a 2-dimensional rectangular array named `temp` that has been declared and initialized. How can we know the number of rows in this array?
    
    <details>
    <summary>Solution</summary>
    By using the `GetLength` method: `temp.GetLength(0)` is the number of rows in the `temp` array.
    </details>
    
#. Suppose we have a 2-dimensional rectangular array named `temp` that has been declared and initialized. How can we know the number of elements in this array?
    
    <details>
    <summary>Solution</summary>
    By using the `Length` field: `temp.Length` is the number of elements in the `temp` array.
    We can also compute the product of `temp.GetLength(0)` and `temp.GetLength(1)`.
    </details>
