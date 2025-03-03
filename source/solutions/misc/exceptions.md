---
tags:
- debugging/exceptions
---

# Exceptions (Solutions)

## Questions

#. In computing, what is an exception?

    - [ ] A compilation error.
    - [ ] When a program user requires a special accommodation.
    - [x] When a behaviour not supposed to happen occurs during execution.
    - [ ] A keyword.

#. When a program meets an unexpected behaviour, we say that it…

    - [ ] … *raises* an exception.
    - [ ] … *throws* an exception.
    - [x] All of the above.

#. An exception can occur when…

    - [ ] … a user enters for example the `string` "Test" when asked for a numerical value.
    - [ ] … a division by 0 occurs.
    - [ ] … the program tries to access an array outside of its index range.
    - [x] All of the above.

#. A `try-catch` block…

    - [ ] … executes all the code inside its `try` block, then all its code inside its `catch` block.
    - [ ] … executes all the code inside its `try` block, then all its code inside its `catch` block if an exception was raised at any point.
    - [ ] … executes only if an exception was raised in the program before.
    - [x] … executes the code inside its `try` block, and switches to its `catch` block if an exception was thrown.
    - [ ] … executes its `catch` block first, and then its `try` block if an exception was raised.

#. A `try-catch-finally` block…

    - [ ] … can have multiple `catch` block.
    - [ ] … can omit the `finally` block.
    - [ ] … can omit the `catch` block.
    - [x] All of the above.

## Warm-up Exercise

#. Consider the following code:

	```{download="./code/projects/TriggeringExceptions.zip"}
    !include code/projects/TriggeringExceptions/TriggeringExceptions/Program.cs
	```

    - Determine which input would the user needs to enter to get "IndexOutOfRangeException", "DivideByZeroException", "FormatException" and "ArgumentNullException" displayed.
    - Is there something the user could enter that would _not_ raise any exception?

<details><summary>Solution</summary>

Exception | Input
--- | ---
"IndexOutOfRangeException" | Any number greater than 2.
"DivideByZeroException" | 1
"FormatException" | Any string that is not a number (for example, "Test")
"ArgumentNullException" | A `null` string (ctrl + d on linux, ctrl + z on windows)

Entering 0 would not raise any exception.
</details>


## Problems

#. We implement two methods for a simple `Calculator` `static` class and use one of them.

    #. Write a `Square` method that takes one `int` argument and returns its value squared if the parameter is less than 46341^[The square of $46,341$ is greater than the maximum value an `int` can hold, `int.MaxValue`.], and throws an `OverflowException` exception otherwise.
    <details><summary>Solution</summary>
    ```
    public static int Square(int p){
        if (p > 46341 || p < -46341) throw new OverflowException();
        else return p*p;
    }
    ```
    Note that this code additionally throws an exception if the parameter is less than 46341.
    </details>
    #. Write a `Divide` method that takes two `int` arguments and returns the result of dividing the first parameter by the second. If the second parameter is 0, then the method should throw an `ArgumentOutOfRangeException` exception.
    <details><summary>Solution</summary>
    ```
    public static int Divide(int dividend, int divisor){
        if (divisor == 0) throw new ArgumentOutOfRangeException();
        else return dividend / divisor;
    }
    ```
    </details>
    #. Write a piece of code (to be inserted into a `Main` method) that asks the user to enter one number. Then, call `Square` with it (no need to loop). Your code should *not* check the value of the `string` entered for the operation, but must catch the exceptions potentially thrown by the `Square` method (*and, as a bonus, by the `Parse` method*). Your code should also display "Thanks!" regardless of whether an exception was thrown.
    <details><summary>Solution</summary>
    ```
    try{
        int uInput = int.Parse(Console.ReadLine());
        Console.Write("Your value squared is " + Calculator.Square(uInput));
    }
    catch(OverflowException)
    {
        Console.WriteLine("Your value squared will not fit in an int!");
    }
    finally{
        Console.WriteLine("Thanks!");
        }
    ```
    </details>
    
    <details><summary>Complete solution</summary>
    ```{download="./code/projects/Calculator.zip"}
    !include code/projects/Calculator/Calculator/Program.cs
	```
	<details>

    
