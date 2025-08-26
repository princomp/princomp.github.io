# Complexity (Solutions)

## Questions

#. Put a checkmark in the box corresponding to true statements.

    - [ ] Abstract data types have exactly one implementation.
    - [x] Data structures are generally useful to store and retrieve data.
    - [x] A data type generally comes with allowed operations.
    - [ ] In data structures classes, ergonomics is the main metrics to compare programs.
    - [x] In data structures classes, hardware is generally ignored.

#. Rank the following from 1 ("best", fast to execute, slow to grow) to 5 ("worst", fast to grow, slow to execute):

    - cubic
    - linear
    - linearithmic
    - logarithmic
    - exponential

    <details><summary>Solution</summary>

    From fastest to execute to slowest to execute:

    #. logarithmic
    #. linear
    #. linearithmic
    #. cubic
    #. exponential
    </details>

#. Complete the following sentences:

    - A quadratic order of magnitude is denoted  ͟ ͟ ͟ ͟ ͟ ͟ ͟ ͟ ͟ ͟ ͟ ͟.
    - A  ͟ ͟ ͟ ͟ ͟ ͟ ͟ ͟ ͟ ͟ ͟ ͟ order of magnitude is denoted $O(c)$.
    - A factorial order of magnitude is denoted  ͟ ͟ ͟ ͟ ͟ ͟ ͟ ͟ ͟ ͟ ͟ ͟.

    <details><summary>Solution</summary>

    - A quadratic order of magnitude is denoted  ͟O͟(͟n͟²͟)͟.
    - A  ͟c͟o͟n͟s͟t͟a͟n͟t͟ order of magnitude is denoted $O(c)$.
    - A factorial order of magnitude is denoted  ͟O͟(͟n͟!͟)͟.
    
    </details>

## Problems

   
#. Write a code snippet (no need to include `using` statements or `Main` header) that displays the sum of all the values in a `score` `int` array that you can suppose declared and initialized.  What is the worst case time complexity of the algorithm you wrote, relative to the size $n$ of the array `score`?
    
    <details><summary>Solution</summary>
    ```
    int sum = 0;
    for(int i = 0; i < score.Length; i++){sum += score[i];}
    Console.WriteLine($"The sum is {sum}.");
    ```
    
    This algorithm is linear: it goes through the array once.
    </detail>
    

