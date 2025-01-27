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
