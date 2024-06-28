---
tags:
  - control-structures/iteratives
aliases:
  - Control Structures - Iteratives
---

## Warm-up Exercises

#. Explain the concept of loops with sentinel, and give a small example.

<details>
	<summary>Solution</summary>
	Loops check for a condition to determine whether or not to repeat execution. The value that is checked in this condition is known as the sentinel value.

Example:
```cs
	int i = 0;
	while (i <= 5) { i++; } // this code will loop until it becomes greater than 5 (the sentinel value)
```
</details>


## Questions

#. A while statement can cause logic errors where the body never stops executing.
This is known as a(n)
- [ ] Syntax error
- [ ] Fatal error
- [x] Infinite loop
- [ ] None of the above.

#. A _____ can be used in a repetition structure (a loop) to control the number of times a set of statements will execute.
- [ ] Declaration
- [x] Counter
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
- [x] 11
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
- [x] 12
- [ ] 11
- [ ] 0

#. Which of the following increments the variable a by one?
- [ ] ++a
- [ ] a++
- [ ] a+=1
- [x] All of the above.

#. Counting loops should be controlled with _____ values.
- [ ] double
- [x] int
- [ ] char
- [ ] None of the above.

#. A common logic error known as a(n) _____ occurs when the programmer incorrectly specifies a conditional operator, such as `<` instead of `<=`.
- [ ] Fatal error
- [x] Off-by-one error
- [ ] Syntax error
- [ ] None of the above.

#. The header `for(int i = 0; i <= 10; ++i)` will cause `i` to be incremented:
- [ ] Before the body begins execution
- [ ] After the body begins to execute, but before it finishes
- [x] After the entire body executes
- [ ] None of the above.

#. The _____ statement, when executed in a while loop, will skip the remaining statements in the loop body and proceed with the next iteration of the loop.
- [x] continue
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
- [x] if (gender == 1 && age >= 65)
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
- [x] Recursive

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

<details>
	<summary>Solution</summary>

Example:
```cs
	for (int A = 1; A != 5; A = (A + 3) % 7)
	{
		Console.WriteLine($"A= {A}");
	}
	Console.WriteLine($"A= {A}");
```
The *for* loop contains the incrementing variable, the looping condition, and the incrementing statement needed for a loop.
</details>

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
<details>
	<summary>Solution</summary>

```cs
	using System;
	namespace ConsoleApp; // added missing semicolon
	{
		class Program
		{
			static void Main(string[] args)
			{
			Console.Write("n="); // added closing quotation marks
			int n= Int32.Parse(Console.Readline());
			Console.Write($"The value of odd factorial of n is equal to {OddFactorial(n)}");
			}
			static int OddFactorial(int n) // removed semicolon
			{
				if ((n % 2) == 0) // changed "fi" to "if"
					return -1;
				else if (n == 1) return 1;
				else return (n * OddFactorial(n - 2)); // Added close parenthesis
			}
		}
	}
```
</details>