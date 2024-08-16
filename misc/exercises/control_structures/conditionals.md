---
tags:
  - control-structures/conditionals
aliases:
  - Control Structures - Conditionals
---

## Warm-up Exercises

#. Explain the meaning of the switch mechanism including the meaning of break and default. Give a small example.
<details><summary>Solution</summary>
  A switch statement will execute code attached to a specific case determined by the value of a variable. The default keyword is used when defining the case in which the value of the determining variable does not match the value attached to any of the other cases. 

  Example

  int i = 0

  switch(i)
  
  {

  case 1:
  break;

  case 2:
  break;

  default:
  break;
</details>

#. Identify lines and cause of syntax errors preventing this code from execution #recursion

```
1: using System;
2:
3: namespace Factorial
4: {
5:    class Program
6:    {
7:        static int Factorial(int n); // returns the factorial value, or
8:        { // -1 if this value is not defined
9:          int answer = -1;
10:         if (n = 1) answer = 1;
11:         else if (n > 1) answer = n . Factorial(n - 1);
12:         return answer;
13:       }
14:       static void Main(string[] args)
15:       {
16:          int n = 7;
17:          Console.WriteLine($"Factorial({n})={Factorial(n)}");
18:       }
19:    }
20: }
```
<details><summary>Solution</summary>
  In line 7, there is a semicolon in between the method header and body.
  In line 11, there is period in assignment statement.
</details>

#. Assume you are testing two positive (>0) integer numbers X and Y. What property is tested by during call of method E(X, Y) in the code given below?

```
using System;
class Program
{
    static bool E(int X, int Y)
    {
        if (((X % Y) == 0) && ((Y % X) == 0))
            return true;
        else
            return false;
    }
    static void Main(string[] args)
    {
        int X = 3; int Y = 2; // experiment with different values of X and Y
        {
            Console.WriteLine($"The answer for X={X} and Y={Y} is {E(X, Y)}");
        }
    }
}
```
<details><summary>Solution</summary>
  The method E(X, Y) tests whether X and Y are equal.
</details>
## Questions

#. Assume that A, B, and C are integer variables. What property on A, B, and C is tested by this code? Provide short justification.
```
if ((A-- == B++) && (--B == C++))
{
    Console.WriteLine($"Property satisfied");
}
else
{
    Console.WriteLine($"Property not satisfied");
}
```
<details><summary>Solution</summary>
  This code tests whether or not the 3 variables are equal in value. Integers A and B are checked for equality before their values are incremented and decremented respectively. Then, B is incremented back to its original value and subsequently checked for equality with C.
</details>

#. The if-statement allows a program to run a piece of code based on the truth of some condition.

  - [x] Yes
  - [ ] No
<details><summary>Solution</summary>
  This code tests whether or not the 3 variables are equal in value. Integers A and B are checked for equality before their values are incremented and decremented respectively. Then, B is incremented back to its original value and subsequently checked for equality with C.
</details>

#. A(n) _____ statement allows a program to make a decision based on the truth or falsity of some condition.
- [x] if
- [ ] test
- [ ] logic
- [ ] None of the above.

#. The three types of selection structures are:
- [ ] foreach, for and switch
- [ ] if, for and switch
- [ ] if, if-else and while
- [x] if, if-else and switch.

#. In a switch statement, a case can be labeled as _____ so that it executes in the event that none of the provided cases are equivalent to the controlling expression.
- [ ] general
- [x] default
- [ ] case *
- [ ] None of the above.

## Problems