#  Some Notes on Complexity

Have a look at the [Big-O complexity chart](https://www.bigocheatsheet.com/):

![Big-O Complexity Chart](https://www.bigocheatsheet.com/img/big-o-complexity-chart.png)

A function [has an order](https://en.wikipedia.org/wiki/Big_O_notation#Orders_of_common_functions), it can be for example

- constant (O(c)),
- logarithmic (O(log n)),
- linear (O(n)),
- [linearithmic](https://en.wikipedia.org/wiki/Time_complexity#Quasilinear_time) (O(n log n)),
- quadratic (O(n^2)),
- cubic (O(n^3)),
- exponential (O(c^n)),
- factorial (O(n!)).

This can make a *very* significant difference, as exemplified in the following code:

```
!include code/snippets/complexity.cs
```
