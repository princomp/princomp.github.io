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

There are additionaly some very useful [properties of the big O notation](https://www.geeksforgeeks.org/dsa/properties-of-asymptotic-notations/):

- Reflexivity: $f(n) = O(f(n))$,
- Transitivity: $f(n) = O(g(n))$ and $g(n) = O(h(n))$ implies $f(n) = O(h(n))$,
- Constant factor: $f(n) = O(g(n))$ and $c > 1$ implies $c\times f(n) = O(g(n))$,
- Sum rule: $f(n) = O(g(n))$ and $h(n) = O(k(n))$ implies $f(n) + h(n) = O(\max (g(n), k(n))$,
- Product rule: $f(n) = O(g(n))$ and $h(n) = O(k(n))$ implies $f(n) \times h(n) = O(g(n) \times k(n))$,
- Composition rule: $f(n) = O(g(n))$ and $g(n) = O(h(n))$ implies $f(g(n)) = O(h(n))$.

$$
\begin{aligned}
f(n) & = O(f(n)) && \text{Reflexivity}\\
f(n) & = O(f(n)) && \text{Reflexivity}
\end{aligned}
$$

$$
\begin{array}{rll}
E \psi &= H\psi & \text{Expanding the Hamiltonian Operator} \\
&= -\frac{\hbar^2}{2m}\frac{\partial^2}{\partial x^2} \psi + \frac{1}{2}m\omega x^2 \psi & \text{Using the ansatz $\psi(x) = e^{-kx^2}f(x)$, hoping to cancel the $x^2$ term} \\
&= -\frac{\hbar^2}{2m} [4k^2x^2f(x)+2(-2kx)f'(x) + f''(x)]e^{-kx^2} + \frac{1}{2}m\omega x^2 f(x)e^{-kx^2} &\text{Removing the $e^{-kx^2}$ term from both sides} \\
& \Downarrow \\
Ef(x) &= -\frac{\hbar^2}{2m} [4k^2x^2f(x)-4kxf'(x) + f''(x)] + \frac{1}{2}m\omega x^2 f(x) & \text{Choosing $k=\frac{im}{2}\sqrt{\frac{\omega}{\hbar}}$ to cancel the $x^2$ term, via $-\frac{\hbar^2}{2m}4k^2=\frac{1}{2}m \omega$} \\
&= -\frac{\hbar^2}{2m} [-4kxf'(x) + f''(x)] \\
\end{array}
$$

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


This can make a *very* significant difference, as exemplified in the following code:

```
!include code/projects/GrowthMagnitudes/GrowthMagnitudes/Program.cs
```
