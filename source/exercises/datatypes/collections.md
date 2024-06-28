---
tags:
  - datatypes/collections
aliases:
  - Datatype - Collections
---

## Warm-up Exercises

## Questions

#. What sequence will appear on the output of this C# code? Which parameter of `SD(int[] A, int B)` method is passed by value? 
```cs
using System;
class Program
{
    static void SD(int[] A, int B)
    {
        A[2] += A[2];
        B /= B;
    }
    static void Main(string[] args)
    {
        int[] A = { 0, 1, 2, 3 };
        S(A, A[2]);
        Console.Write($"[{A[0]},{A[1]},{A[2]},{A[3]}]");
    }
}
```
<details><summary>Solution</summary>
  The sequence that appears in the output is 0, 1, 4, 3. The parameter int B is passed by value.
</details>

#. Which of the following correctly declares and creates a two-dimensional rectangular array of integers?
- [x] int[,] sum = new int[10, 40];
- [ ] int[][] sum = new int[25, 43];
- [ ] int sum[] = new int[20, 20];
- [ ] None of the above.

#. C# supports two types of two-dimensional arrays:
- [ ] quadrilateral and isosceles
- [x] jagged and rectangular
- [ ] jagged and round
- [ ] None of the above.

## Problems
