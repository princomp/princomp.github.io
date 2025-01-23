---
tags:
- datatypes/collections
- oop/objects
- debugging/exceptions
---

# Description

## Purpose

This project is designed to teach you how to manipulate exceptions and properties.
It reinforces your understanding of class design and implementation while introducing the handling of exceptions.

## Challenge

### In short

Develop a class that helps the user track the progress in their reading of books.
Your class should allow users to track the book title, total page number, and the current page they stopped their reading at (as a bookmark!).

### In more details

#. Your goal is to design and implement a `Bookmarker` class containing three attributes and several methods (some of which may and should be implemented using properties).
#. You *must* develop a `Program` class with a `Main` method to test your `Bookmarker` class, and this `Program` class will be part of your grade.
#. An object in your `Bookmarker` must hold three attributes:

    - a title,
    - the total number of pages in the book,
    - the current page the user is reading.

    The title *must* be implemented using automatic properties.

#. The current page *must be* less than the total number of pages: if at any point during creation or later modification the current page were to become strictly larger than the total number of pages, your class should throw an exception.
#. The total number of pages *must be* strictly positive, but the current page can be positive (0 would be an acceptable value: it means the reader has not started yet).
#. Finally, your class should have two methods,

    - a `ToString` method that displays, in percentage, how much of the book was read, and how much of the book is left,
    - one to increment the number of page read by its argument.

## Submission

Please, follow our [guideline on project submission](https://princomp.github.io/projects/submission).
In particular, make sure you write your name and the date in a delimited comment at the beginning of your file.

## Example

Remember that *you* have to develop a `Program.cs` `Main` method that will test your class.
Executing your program with a properly implemented `Bookmarker` class should give something along the lines of:

```text
Enter the title of the book.
T͟e͟s͟t͟1͟⏎͟
Enter the total number of pages.
1͟0͟0͟⏎͟
Enter the page you stopped your reading at.
3̲7̲⏎͟
You have read 37,00% of "Test1".
You have 63,00% to go!
How many pages did you read since?
1͟2͟⏎͟
You have read 49,00% of "Test1".
You have 51,00% to go!

Press any key to continue...
```

If the user enters incorrect data, then the error should be thrown when the object is created (do *not* perform user-input validation in the `Main` method: incorrect data should be handled *by the class*, not by the `Main` method):


```text
Enter the title of the book.
T͟e͟s͟t͟2͟⏎͟
Enter the total number of pages.
-̲2̲4̲⏎͟
Enter the page you stopped your reading at.
1͟2͟⏎͟
The total number of pages cannot be negative.
```

```text
Enter the title of the book.
T͟e͟s͟t͟3͟⏎͟ ͟
Enter the total number of pages.
2͟5͟⏎͟
Enter the page you stopped your reading at.
3͟0͟⏎͟
You cannot have read more than the total number of pages!
```

```text
Enter the title of the book.
T͟e͟s͟t͟4͟⏎͟
Enter the total number of pages.
2͟5͟⏎͟
Enter the page you stopped your reading at.
1͟7͟⏎͟
You have read 68,00% of "Test4".
You have 32,00% to go!
How many pages did you read?
9͟⏎͟
You cannot have read more than the total number of pages!
```

Note that it is ok if you cannot reproduce this output *exactly*.

## Bonuses

- Implement a method to display the values and the description nicely.
- Implement a method to display the values *converted to Celcius* nicely.
- Accept arrays sorted in increasing *or* decreasing order. That is, the array `3.5, -10, -15` should be accepted.
- Implement a method (or property) to compute [the mode](https://en.wikipedia.org/wiki/Mode_(statistics)) of the temperatures. Note that the mode is not always unique: in that case, an exception should be raised.
