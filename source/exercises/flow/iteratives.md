<!--

DO NOT EDIT THIS FILE

Edit exercises_w_sol/flow/iteratives.md, and run
make exercises/flow/iteratives.md
instead.
-->

---
tags:
  - control-structures/iteratives
---

## Warm-up Exercises

#. Explain the concept of loops with sentinel, and give a small example.


#. Write a program containing a **while** loop that would display the numbers between -100 and 100 (both included) with a space between them when executed.


#. Write a **for** loop that displays on the screen the sequence "1, 2, 3, 4, 5, 6, 7, 8, 9, 10, ".


#. Write a **for** loop that displays on the screen the sequence "1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ". Notice that the final number is not followed by a comma.


#. Write a **for** loop that displays on the screen the sequence “1 3 5 7 9 ”.



## Questions

#. A while statement can cause logic errors where the body never stops executing.
This is known as a(n)
- [ ] Syntax error
- [ ] Fatal error
- [ ] Infinite loop
- [ ] None of the above.

#. A _____ can be used in a repetition structure (a loop) to control the number of times a set of statements will execute.
- [ ] Declaration
- [ ] Counter
- [ ] Controller
- [ ] None of the above.

#. How many times is the body of the loop below executed?
```cs
int counter = 10;
while (counter >= 0)
{
    counter--;
}//End while
```
- [ ] 9
- [ ] 10
- [ ] 11
- [ ] 0

#. How many times is the while statement checked in the code below?
```cs
int counter = 10;
while (counter >= 0)
{
    counter--;
}//End while
```
- [ ] 9
- [ ] 12
- [ ] 11
- [ ] 0

#. Which of the following increments the variable a by one?
- [ ] ++a
- [ ] a++
- [ ] a+=1
- [ ] All of the above.

#. Counting loops should be controlled with _____ values.
- [ ] double
- [ ] int
- [ ] char
- [ ] None of the above.

#. A common logic error known as a(n) _____ occurs when the programmer incorrectly specifies a conditional operator, such as `<` instead of `<=`.
- [ ] Fatal error
- [ ] Off-by-one error
- [ ] Syntax error
- [ ] None of the above.

#. The header `for(int i = 0; i <= 10; ++i)` will cause `i` to be incremented:
- [ ] Before the body begins execution
- [ ] After the body begins to execute, but before it finishes
- [ ] After the entire body executes
- [ ] None of the above.

#. The _____ statement, when executed in a while loop, will skip the remaining statements in the loop body and proceed with the next iteration of the loop.
- [ ] continue
- [ ] break
- [ ] next
- [ ] None of the above.

#. Consider the code segment below.
```cs
if (gender == 1)
{
    if (age >= 65)
    {
        ++seniorFemales;
    }
}
```
This segment is equivalent to which of the following?
- [ ] if (gender == 1 || age >= 65)
{
    ++seniorFemales;
}
- [ ] if (gender == 1 && age >= 65)
{
    ++seniorFemales;
}
- [ ] if (gender == 1 AND age >= 65)
{
    ++seniorFemales;
}
- [ ] if (gender == 1 OR age >= 65)
{
    ++seniorFemales;
}

#. Methods that call themselves are known as _____ methods.
- [ ] Reiterative
- [ ] Self-calling
- [ ] Repeat-calling
- [ ] Recursive

#. What will be displayed on the screen by the following program?

```cs
for (int num = 3; num <= 5 ; num++)
	Console.Write(num + " ");
```


#. Given an **int** variable counter, write three statements to decrement its value by 1.


#. What will be displayed on the screen?

```cs
int x = 3, y = 7;
Console.WriteLine(x++ +" and "+ --y);
```


#. What will be displayed on the screen by the following program?

```cs
int counter = 2;
while (counter != 5)
{
	Console.Write(counter + "\n");
	counter++;
}
```


#. What will be displayed on the screen by the following program?

```cs
int counter = 10;
while (counter != 5);
Console.Write(counter + "\n");
counter--;
```


#. What will be displayed on the screen by the following program?

```cs
int counter = 7;
while (counter != 2);
Console.Write(counter + "\n");
counter--;
```


#. What do we name a variable that is incremented at every iteration of a loop, i.e., that keeps the running total?



## Problems

#. Write an equivalent code replacing the while loop with a for loop, and provide short justification.
```cs
int A = 1;
while (A != 5)
{
    Console.WriteLine($"A= {A}");
    A = (A + 3) % 7;
}
Console.WriteLine($"A= {A}");
```


#. Find all syntax errors in this code
```cs
using System;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= );
            int n= Int32.Parse(Console.ReadLine());
            Console.Write($"The value of odd factorial of n is equal to {OddFactorial(n)}");
        }
        static int OddFactorial(int n);
        {
            fi ((n % 2) == 0)
                return -1;
            else if (n == 1) return 1;
            else return (n * OddFactorial(n - 2);
        }
    }
}
```

#. Write a C# program that takes a single-digit number as input and then, using a *for loop*, displays a rectangle of that digit that is 3 columns wide and 5 rows tall.


#. Assume you are given an initialized **string** variable `name`, and a **string** variable `field`. Write a small program that assigns to `field`
	- "CS" if name is "Turing" or "Liskov"
	- "Math" if name is "Aryabhata" or "Noether"
	- "Unknown" otherwise.


#. Assume you are given an un-assigned **string** variable `letterGrade`, and an already assigned **float** variable `numberGrade`. Write a small program that assigns "A" to `letterGrade` if `numberGrade` is between 100 and 90 (both included), "B" if `numberGrade` is between 90 (excluded) and 80 (included), etc., and "Invalid data" is strictly lower than 0 or strictly greater than 100.
Should you use a **switch** statement or an **if...else if...else**?


#. Write a loop that displays on the screen numbers between [0.0, 1.0], using one decimal place precision, i.e. 0.0, 0.1, 0.2, 0.3...


#. Write a loop that displays on the screen a value that decreases by 0.5 on each iteration. Start from 10 and iterate as long as the value remains positive.


#. Write a program that computes the sum of numbers [1, n]. You can choose any value you want for n, where n > 1. For example, if you choose n = 10, then program should compute and display the result for the following: 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 = 55.
