---
tags:
  - datatypes/collections
---

# Two-Dimensional Arrays (Solutions)

## Multiple Choices

#. What is the correct way of creating a 2-dimensional rectangular array of `int` with 5 rows and 2 columns named `myMatrix`?

    - [ ] `int[][] myMatrix = new int[5][2];`
    - [ ] `int[][] myMatrix = new int[2][5];`
    - [ ] `int[,] myMatrix = new int[2, 5];`
    - [x] `int[,] myMatrix = new int[5, 2];`

#. Consider the following code:

    ```
    int[,] grades = {{10, 20}, {30, 40}};
    Console.WriteLine(grades[1,0]);
    ```

    What will it display?
    
    - [ ] Nothing
    - [ ] 10
    - [ ] 20
    - [ ] grades
    - [x] 30
    - [ ] grades[1,0]
    - [ ] 40


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
    </details>


#. Write a declaration for a 2-dimensional rectangular array of `int` containing the following data:

    | | | | 
    | --- | --- | --- | 
    | 10  | 20  | 30  |
    | 40  | 50  | 60  | 
    | 70  | 80  | 90  | 
    
    <details>
    <summary>Solution</summary>

    ```
    int[,] matrix =
        {
            {10, 20, 30},
            {40, 50, 60},
            {70, 80, 90}
        };
    ```
    </details>

#. Write a declaration for a 2-dimensional ragged array of `int` containing the following data:

    | | | | 
    | --- | --- | --- | 
    | 10  | 20  | 
    | 40  |
    | 70  | 80  | 90  | 
    
    <details>
    <summary>Solution</summary>

    ```
    int[][] data = new int[3][];
    data[0] = new int[3] { 10, 20, 30 };
    data[1] = new int[1] { 40 };
    data[2] = new int[3] { 70, 80, 90 };
    ```
    </details>


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
    
#. Write a `Display` static method that takes as an argument a 2-dimensional array and displays it at the screen.

    <details>
    <summary>Solution</summary>```
    !include`snippetStart="// Method to display 2-d arrays", snippetEnd="// End of method to display 2-d arrays"` code/snippets/2darrays.cs
    ```
    </details>

#. Write a program that display "Every row contains its own index" if the 2-dimensional rectangular array of `int` `matrix` is such that its first row contains the value 0, its second row contains the value 1, etc.

    <details>
    <summary>Solution</summary>
    ```
    bool foundIndex = true;
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        if(row == 0 || foundIndex)
        {
            foundIndex = false;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] == row) {
                    foundIndex = true;
                }
            }
        }
    }

    if(foundIndex){
        Console.WriteLine("Every row contains its own index");
    }
    ```
    </details>

#. Write a program that display the average of each row of a 2-dimensional jagged array of `int` `jArray`.

    <details>
    <summary>Solution</summary>
    ```
    double sum;
    for(int i = 0; i < jArray.Length; i++)
    {
        sum = 0;
        for (int j = 0; j < jArray[i].Length; j++)
        {
            sum += jArray[i][j];
        }
        Console.WriteLine("Average for row #" + i
            + " is " + sum / jArray[i].Length);
    }
    ```
    </details>

#. Write a program that display the sum of the values on the diagonal of a 2-dimensional rectangular array of `int` `jArray`.

    <details>
    <summary>Solution</summary>
    ```
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, i];
    }
    Console.WriteLine(sum);
    ```
    </details>

#. Write a program that "rotate" a 2-dimensional array 90° clockwise. For example, the array 

    ```
    !include`snippetStart="// Example array1", snippetEnd="// End of example array1"` code/snippets/2darrays.cs
    ```
    
    would become
    
    ```text
    |  10 |   7 |   4 |   1  |
    |  11 |   8 |   5 |   2  |
    |  12 |   9 |   6 |   3  |
    ```

    <details>
    <summary>Solution</summary>```
    !include`snippetStart="// Method to rotate an array 90° clockwise", snippetEnd="// End of method to rotate an array 90° clockwise"` code/snippets/2darrays.cs
    ```
    </details>
    

## Wrapping-up Problem

#. Answer the following questions using a 2-dimensional jagged array **and** a 2-dimensional rectangular array.

    #. Write statements that declare a 2-dimensional array with at least 2 rows containing values 1 through 6.
    #. Write statements that display the values stored in a 2-dimensional array called `arTest`.
    #. Write statements displaying "Ranked" if the sum of the values stored in each row is greater than the sum of the values in the preceding row in the `arTest` array. For example, the following rectangular and jagged arrays are both ranked, as 4 < 5 < 6.

        ```text
        2 1 1
        3 1 1
        5 1 0
        ```

        ```text
        4 0
        3 1 1
        2 2 1 1
        ```
    
    <details>
    <summary>Solution</summary>
    ```{download="./code/projects/RankedArrays.zip"}
!include code/projects/RankedArrays/RankedArrays/Program.cs
    ```
    </details>
    

## Problem: Toward a Crossword Puzzle Solver

The goal of this problem is to work toward the creation of a program that solve crossword puzzles.
We will reason in the simple case where the "word" is actually simply a pair of number (so, "1, 2" or "8, 101").

In the following, assume given two `int` variables `first` and `second`, as well as a 2-dimensional rectangular array `values`.

#. Write a program that display "pair found" if `first` and `second` occur next to each other in the same row.
#. Edit your program so that "pair found" is displayed also if `second` occurs before `first` in the same row.
#. Edit your program so that "pair found" is displayed also if `first` occurs "above" `second` (that is, if they are next to each other in the same column),
#. Edit your program so that "pair found" is displayed also if `second` occurs "above" `first`,
#. Edit your program so that "pair found" is displayed also if `first` and `second` occur diagonally,
#. Edit your program so that "pair found" is displayed also if `first` and `first` occur anti-diagonally.

Test your program thoroughly, possibly bundling it in a `static` class to ease testing and debugging.

<details>
<summary>Solution</summary>
A possible implementation, as a static class, is as follows:
```{download="./code/projects/CrossWord.zip"}
!include code/projects/CrossWord/CrossWord/Crossword.cs
```
</details>


