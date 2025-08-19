# Complexity

## What makes a program "better"?

There are multiple ways of measuring if a program is "better" than an other, assuming they perform similar functions:

- Correctness: a program not producing the correct output is worst than a program that is always correct,
- Security: a program leaking personal information or infesting your computer will always be worst than one that does not,
- Memory: the less a program requires memory to be installed and to run efficiently, the better.
- Time: the faster the program produces the output, the better.
- Other measures: ergonomics, cost, compatibility with operating systems, licence, network efficiency, may also come into play to decide which program is "best".

Some criteria may be subjective (usability, for example), but some can be approach objectively: in a first approximation, memory (also called "space") and time are the two preferred measures.

## Orders of magnitude in growth rates

### Principles

When measuring space or time, it is important to take the size of the input into account: that a word-processing software can open a document containing 1 word in 0.0001 second is no good if it takes hours to open a 10 pages document.

Hence, algorithms and programs are classified according to their *growth rates*, how "fast" their run time or space requirements grow when the input size grows.
This growth rate is classified according to ["orders"](https://en.wikipedia.org/wiki/Big_O_notation#Orders_of_common_functions), using the [*Big O notation*](https://en.wikipedia.org/wiki/Big_O_notation), whose definition follows:

Using $|\cdot|$ to denote the absolute value, we write:

$$f(x) = O(g(x))$$

if there exists positive numbers $n$ and $x_0$ such that

$$|f(x)| \leqslant M |g(x)|$$

for all $x \geqslant x_0$.

### Common orders of magnitude

Using $c>1$ for "a constant", $n$ for the size of the input and $\log$ for logarithm in base $2$, we have the following common [orders of magnitude](https://en.wikipedia.org/wiki/Big_O_notation#Orders_of_common_functions):

- constant ($O(c)$),
- logarithmic ($O(\log n)$),
- linear ($O(n)$),
- [linearithmic](https://en.wikipedia.org/wiki/Time_complexity#Quasilinear_time) ($O(n \times \log(n)))$),
- polynomial ($O(n^c)$), which includes
    - quadratic ($O(n^2)$),
    - cubic ($O(n^3)$),
- exponential ($O(c^n)$),
- factorial ($O(n!)$).

### Simplifications

In typical usage the $O$ notation is *asymptotical* (we are interested in very large values), which means that only the contribution of the terms that grow "most quickly" is relevant. Hence, we can use the following rules:

- If $f(x)$ is a sum of several terms, if there is one with largest growth rate, it can be kept, and all others omitted.
- If $f(x)$ is a product of several factors, any constants (factors in the product that do not depend on $x$) can be omitted.

There are additionally some very useful [properties of the big O notation](https://www.geeksforgeeks.org/dsa/properties-of-asymptotic-notations/):

- Reflexivity: $f(n) = O(f(n))$,
- Transitivity: $f(n) = O(g(n))$ and $g(n) = O(h(n))$ implies $f(n) = O(h(n))$,
- Constant factor: $f(n) = O(g(n))$ and $c > 1$ implies $c\times f(n) = O(g(n))$,
- Sum rule: $f(n) = O(g(n))$ and $h(n) = O(k(n))$ implies $f(n) + h(n) = O(\max (g(n), k(n))$,
- Product rule: $f(n) = O(g(n))$ and $h(n) = O(k(n))$ implies $f(n) \times h(n) = O(g(n) \times k(n))$,
- Composition rule: $f(n) = O(g(n))$ and $g(n) = O(h(n))$ implies $f(g(n)) = O(h(n))$.

<!--
    Example 1:  f(n) = 3n2 + 2n + 1000Logn +  5000
    After ignoring lower order terms, we get the highest order term as 3n2
    After ignoring the constant 3, we get n2
    Therefore the Big O value of this expression is O(n2)

    Example 2 :  f(n) = 3n3 + 2n2 + 5n + 1
    Dominant Term: 3n3
    Order of Growth: Cubic (n3)
    Big O Notation: O(n3)
--> 

Have a look at the [Big-O complexity chart](https://www.bigocheatsheet.com/):

![Big-O Complexity Chart](https://www.bigocheatsheet.com/img/big-o-complexity-chart.png)

### Experimentation

How fast a function grows can make a *very* significant difference, as exemplified in [this code available to download](./code/projects/GrowthMagnitudes.zip).
In it, we "experiment" to see how fast factorial, exponential, cubic, quadratic, linearithmic, linear and logarithmic functions can produce an integer that is larger than `int.MaxValue`, whose value is $2,147,483,647$.

For example, the test for exponential growth is as follows:


```{download="./code/projects/GrowthMagnitudes.zip"}
!include`snippetStart="// Exponential",snippetEnd="// Cubic"` code/projects/GrowthMagnitudes/GrowthMagnitudes/Program.cs
```

C#'s default `Math.Pow` method returns a `double` (because, as you will see, producing something an `int` cannot hold goes *very fast*), so we cast it back to an `int`, in a `checked` environment so that C# will raise an exception if an overflow occurs.
Our `while(true)` loop *will* terminate, since we are bound to produce a value overflowing, and then we simply display the value our input reached: in this case, it was enough to "feed" the value $31$ to the exponential function to make it go over `int.MaxValue`.

[Download the project](./code/projects/GrowthMagnitudes.zip) to see how fast other magnitude produce a value exceeding `int`'s capacity, and do not hesitate to edit this code to have all input values starting at 0 to "feel" the difference it makes in terms of time!

# The Example of Integers

## Abstraction and Representation

To measure the time and space consumption of programs, we make some simplifying assumptions:

- Hardware is discarded: we compare programs assuming they run on the same platform, and do *not* consider if a program would be "better" on parallel hardware. 
- Constants are discarded: if a program is twice as slow as another one, we still consider them to be in the same order of magnitude^[This is captured by the "constant factor" property of the big O notation.].
- *Representations* are in general discarded, as programs are assumed to use the same: for example, if the implementation of the `int` datatype is "reasonable" and the same for all programs, then we can discard it.

## How integers are represented

Compare the following three ways of representing integers:

Name | Base | Examples | Bits to represent $n$ | 
--- | :---: | ---------- | ----- | 
Unary (Tallies) | 1 | III, IIIIIII, IIIIIIII, … | $O(n)$ |
Binary | 2 | 01011, 10011101, 101101010, … | $O(\log_2(n))$ |
Decimal | 10 | 123, 930, 120,439, … | $O(\log_{10}(n))$ |

Actually, it takes roughly [$\log_2(n) / \log_2(b)$ digits](https://math.stackexchange.com/a/4490764) to represent the number $n$ in base $b$, except if $b = 1$.

And indeed we can confirm that for $b = 10$, we have

$$\log_2(n) / \log_2(b) = \log_{10}(n)$$

by [changing the base](https://en.wikipedia.org/wiki/List_of_logarithmic_identities#Changing_the_base) of the logarithm.

## Why it (almost) does not matter

Now, imagine that we have a program manipulating integers in base $b$.
Converting numbers in base $b'$ result in numbers that use $\log_2(b') / \log_2(b)$ more (or less!) space.
For example, going from base $10$ to base $2$ means that $b = 2$ and $b' = 10$, hence we need $\log_2(10) / \log_2(2) = 3.322 / 1$ times more space to store and manipulate the integers.
This corresponds intuitively to 32 bits being able to store at most a 10-digit number (2,147,483,647).

If our program in base $b$ uses $O(g(n))$, it means that a program performing the same task, with the same algorithm, but using integers in base $b'$, would require $O((\log_2(b) / \log_2(b')) \times g(n))$.
By adapting the constant factor principle of the big O notation, we can see that this is a negligible factor that can be omitted.

However, if the $b'$ base is 1, then the new program will use $O(n \times g(n))$: if $g(n)$ is greater than linear, this will make a difference!
Of course, unary representation is "not" reasonable, so we will always assume that our representations are related by some constant, making the function order of magnitude insensible to such details.

You can have a look at [the complexity of various arithmetic functions](https://en.wikipedia.org/wiki/Computational_complexity_of_mathematical_operations#Arithmetic_functions) and see that the representation is not even discussed, as those results are insensible to them, provided they are "reasonable".

# Types of Bounds

## Foreword

When considering order of magnitude, we are always *asymptotic*, i.e., we consider that the input will grow for ever.
The Big-O notation above furthermore corresponds to the *worst case*, but two other cases are sometimes considered:

- Best case,
- Average case.

The first type of study requires to understand the algorithm very well, to understand what type of input can be easily processed. The second case requires to consider all possible inputs, and to know the distribution of cases.

The reason why worst case is generally preferred is because:

- Worst case gives an upper bound that is in practise useful,
- Best case is considered unreliable as it can easily be tweaked, and may not be representative of the algorithm's resource consumption in general,
- Average case is difficult to compute, and not necessarily useful, as worst and average complexity are often the same.

## Examples

### Linear search algorithm

The [linear search algorithm](https://princomp.github.io/lectures/data/search#finding-a-particular-value) look for a particular value in an array. The version that exit exit prematurely the loop when the target value is found has the following complexity:

- The **best case** is if the target is the very first value, in this case, the time complexity is $O(c)$.
- The **worst case** is if the target is the very last value, in this case the time complexity is $O(n)$ where $n$ is the size of the array.
- The **average case** is $O(n)$.

Note that the space usage of this algorithm is $O(c)$, it requires only one variable if we do not copy the array.

### Matrix Multiplication

Consider the ["schoolbook algorithm for multiplication"](https://en.wikipedia.org/wiki/Computational_complexity_of_matrix_multiplication#Schoolbook_algorithm)
