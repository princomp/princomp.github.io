---
tags:
- control-structures
---

# Description

## Purpose

This project is designed to teach you how to devise, implement, and submit solutions to the simple programming problem of constructing a software that collects the result of dice throws.
It aims at making sure that you master the simple concepts of control structures and data manipulation before introducing more advanced concepts.

## Challenge

### In short

Develop a simple program that asks the user how many sides their die has, how many times they will throw it, and what the results of those throws are, with user-input validation.

### In more details

#. Your program should start by asking the user how many sides their die has. The only valid values are 4, 6, 8, 10, 12 and 20.
#. Once the user is done providing this information, it should ask how many times they intend to throw the die. Of course, only a strictly positive number of throws is allowed.
#. Then, your program should ask the user to enter the result of their throws, one by one, knowing that the numbers entered should be between 1 and the number of sides of their die (both included).
#. Once the user entered all their throws, your program should display:

    #. A simple table summarizing their throws,
    #. The average of their throws.

## Submission

Please, follow our [guideline on project submission](https://princomp.github.io/projects/submission).
In particular, make sure you write your name and the date in a delimited comment at the beginning of your file.

## Example

Here is an example of execution, where the user input is u͟n͟d͟e͟r͟l͟i͟n͟e͟d͟, and hitting "enter" is represented by "⏎͟":

```text
How many sides does your die have?
Valid choices are 4, 6, 8, 10, 12 or 20.
5͟⏎͟
How many sides does your die have?
Valid choices are 4, 6, 8, 10, 12 or 20.
6͟⏎͟
You picked a 6 sided die.
How many times will you throw it?
-͟1͟⏎͟
How many times will you throw it?
3͟⏎͟
Enter the 3 throws, one by one, separated by new lines.
Enter throw #1. 5͟⏎͟
Enter throw #2. H͟o͟l͟d͟ ͟o͟n͟⏎͟
Enter throw #2. -͟1͟⏎͟
Enter throw #2. 1͟0͟⏎͟
Enter throw #2. 1͟⏎͟
Enter throw #3. 6͟⏎͟
You made the following throws:
| Value | Number of throws | 
|   1   | 1
|   2   | 0
|   3   | 0
|   4   | 0
|   5   | 1
|   6   | 1
Your average is 4.

Press any key to continue...
```

Note that it is ok if you cannot reproduce this output *exactly*. However, you should pay attention to the way it handles improper values, and try to reproduce this behavior.

## Bonuses

- Improve the way the statistics are displayed using [string formatting](./labs/OverflowAndUnderflow#optional-string-formatting).
- Display the smallest throw and the largest throw (in our example, 1 and 6 would be displayed).
- Display an actual error message when the user enters an incorrect value (for example, you could display "please enter a positive number of throws" if the user entered -1, and "please, enter a number" if the user enters "I don't know").
