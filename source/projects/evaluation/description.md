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

!include uml/Evaluation.md

Remembering  that:

- Static methods are u͟n͟d͟e͟r͟l͟i͟n͟e͟d͟,
- Abstract methods are *in italics*.

Your code should be such that the following:

```
include code/projects/evaluation/Program.cs
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

## Submission

Please, follow our [guideline on project submission](https://princomp.github.io/projects/submission).
In particular, make sure you write your name and the date in a delimited comment at the beginning of your file.

## Bonuses
