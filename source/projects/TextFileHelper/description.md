---
tags:
- IO/file
- debugging/validation
- debugging/exceptions
---

# Description

## Purpose

This project is designed to teach you how to manipulate files and exceptions.
It reinforces your understanding of class input/output operations on files and forces you to be creative with a limited toolbox.

## Challenge

### In short

Develop a static class to perform simple operations on files: display its content, display its content without the comments, reverse its content, concatenate two files, and finally (for more experienced programmers), determine if the content of the file is balanced (as defined below).

### In more details

Your goal is to design and implement a static `TextFileHelper` class containing 5 methods (the fifth one being optional):

#. A `Display` method that takes a `string` as argument and display the file located at the corresponding path if it exists, displays an error message otherwise.
#. A `DisplayNoComment` method that takes a `string` and acts as the `Display` method, except that every line starting with the `#` character is ignored.
#. A `Concat` method that takes three `string` arguments, `arg1`, `arg2` and `arg3` and write at `arg3` a file containing the text stored in `arg1` followed by the text stored in `arg2`, if both files exist and if `arg3` does not exist, and that displays an error message otherwise.
#. A `Reverse` method that takes two `string` arguments, `arg1` and `arg2`, and write at `arg2` the content of the file located at `arg1`, reversed (that is: last line of `arg1` is first of `arg2`, etc., but the content of the lines themselves is identical). If `arg1` does not exists or if a file is already present at `arg2`, then the method should display an error message.
#. (optional) A `Balanced` method that takes a `string` argument and returns `true` if the file located at the corresponding path is balanced, `false` otherwise. A file is *balanced* if every `(` character has a matching `)` character coming after it. We give below some examples of balanced and un-balanced files.

| ⚠ Warning |
|:---------------------------|
| You are allowed to use only `StreamReader`'s `ReadLine` and constructor, `StreamWriter`'s `WriteLine` and constructor, and the usual `Console`, `char`, `string` and `array` methods, lists, arrays, conditionals, etc. In particular, *do not* use the Linq library. `AppDomain`, `Path` and `File` methods can be used as in class or in the example below. |

## Submission

Feel free to download the project [illustrated below](./code/projects/TextFileHelper.zip) to help you getting started.
You will need to either write the required methods or to comment out the code between "// START commenting here" and "// END commenting here" before you can compile it.

Please, follow our [guideline on project submission](https://princomp.github.io/projects/submission).
In particular, make sure you write your name and the date in a delimited comment at the beginning of your file.

## Example

Here is an example of a `Program.cs` `Main` method, that creates four test files and illustrates some of the desired functionalities:

```
!include code/projects/TextFileHelper/TextFileHelper/Program.cs
```

Executing it with the properly implemented `TextFileHelper` missing methods should give something along the lines of:

```text
*****
* Testing Display
*****
This is the first demo file
# This line starts with an "#").
(An isolated parenthesis
*****
* Testing DisplayNoComment
*****
This is the first demo file
(An isolated parenthesis
*****
* Testing Reverse
*****
(An isolated parenthesis
# This line starts with an "#").
This is the first demo file
*****
* Testing Concat
*****
This is the first demo file
# This line starts with an "#").
(An isolated parenthesis
(This is the second demo file
)There are parenthesis in it, but no pound ("#") character on the first line.
*****
* Testing Balanced
*****
0 = (0 = )43 = (47 = )0 = (30 = )ex0 is balanced: False
ex1 is balanced: True
ex2 is balanced: False
ex3 is balanced: True

```

Note that it is ok if you cannot reproduce this output *exactly*.

## Bonuses

- Write the `Balanced` method.
- Handle gracefully exceptions if files do not exist,
- Give to `Concat` and `Reverse` an optional `bool` argument that allows overriding the file whose path is given as a last argument.
