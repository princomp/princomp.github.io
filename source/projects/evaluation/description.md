---
tags:
- oop
---

# Description

## Purpose

This project is designed to teach you how to interpret and implement a simple UML specification involving multiple classes.
It involves inheritance, polymorphism, properties, exception handling and `String` methods.

## Challenge

### In short

Develop multiple classes to organize the evaluations for courses. 
Evaluations can be of different natures (project, in-class exam, finale exam), have different weights and be marked as optional.

### In more details

We want to implement the classes pictured in the UML diagram.

!include uml/cla/Evaluation.md

Remembering  that:

- Static methods are u͟n͟d͟e͟r͟l͟i͟n͟e͟d͟,
- Abstract methods are *in italics*.

Your code should be such that the following:

```
!include code/projects/Evaluation/Evaluation/Program.cs
```

should display (something along the lines of)

```text
********************

Submission link (https://sketchy-url.com/totallyLegitProject) does not start with "https://lms.augusta.edu/d2l/lms/".
Parameter name: https://sketchy-url.com/totallyLegitProject

********************

Course:         CSCI 1302
Weight:         5,00 ٪
Contact:        Check the LMS submission folder.
Link:           https://lms.augusta.edu/d2l/lms/dropbox/user/folder_submit_files.d2l?db=230223&grpid=0&isprv=0&bp=0&ou=474653

********************

Course:         CSCI 1302
Weight:         5,00 ٪
Contact:        Check the LMS submission folder.
Link:           https://lms.augusta.edu/d2l/lms/dropbox/user/folder_submit_files.d2l?db=232525&grpid=0&isprv=0&bp=0&ou=474653

********************

Course:         CSCI 1302
Weight:         25,00 ٪
Contact:        Contact the CSCI 1302 instructor.
Room:           University Hall 243

********************

Course:         CSCI 1302
Weight:         25,00 ٪
Contact:        Contact the CSCI 1302 instructor.
Room:           Same as class meeting room.

********************

Course:         CSCI 1302
Weight:         40,00 ٪
Contact:        Contact the CSCI 1302 instructor.
Room:           Check the Registrar's exam schedules for CSCI 1302.

********************

Your list of non-bonus evaluations sums up to 100%: True

********************

Evaluations are for different classes.

********************
```

**Pay attention to details** in the code above. For example, your code should be such that:

- An exception will be raised if the url for the project's submission link does not start with "https://lms.augusta.edu/d2l/lms/",
- For exams (in-class or finale exam), the room should be displayed if it is provided, otherwise, "Same as class meeting room." should be displayed if the exam in in-class, and "Check the Registrar's exam schedules for " (followed by the course property) should be displayed if the exam is the final exam,
- For all string attributes and properties, `null` or empty strings should *not* make the program crash,
- The *static* `IntegrityTest` method should take as input a list of evaluations, and returns `true` if all the evaluations belong to the same course and the weights of the evaluations that are not bonuses adds to 1, `false` if the evaluations all belong to the same course but the weights of the evaluations that are not bonuses do not add to 1, and raise an exception otherwise,
- `Final` and `InClass` do *not* have `ToString()` methods, and yet displaying information about them still return information about the room.

## Submission

Please, follow our [guideline on project submission](https://princomp.github.io/projects/submission).
In particular, make sure you write your name and the date in a delimited comment at the beginning of your file.

## Bonuses

This project is already challenging *as is*, but bonus will be given if:

- (easy) The `GetContact()` method cannot be overridden,
- (medium) Your `Main` method exhibits many test cases and illustrates your classes' features nicely,
- (hard) A mechanism is implemented to either export the attributes of an `Evaluation` object into a file or to load it from a file.
