---
title: Project Rubric
---

# Project 2 Rubric

Below are the rubrics used to grade each phase of Project 2. It is advised to use these rubrics as a way to check your work, along with the solution for the corresponding phase.

## Phase 1

| Criteria                                                                         | Points                                                                                                                                                                       |
|----------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **In**correct filename (lname_fname.zip, not lname_fname.zip.zip for instance)   | -0.5pt                                                                                                                                                                       |
| **In**correct file (archive zipped, not just the .cs file)                       | -0.5pt (if the student did not share their .cs code at all, then your grading ends here)                                                                                     |
| Name and date in a delimited comment **not** at the very beginning of their code | -0.5pt (If they forgot the date, their name, if the comment is in-line, that is `//` and not `/* ... */`, or if it is not the very first thing in the file, they get -0.5pt) |
| If the program does not compile                                                  | Stop here. No points.                                                                                                                                                        |
| Correctly declared the attributes                                                | +1pt (-0.5pt per incorrect name and datatype)                                                                                                                                |
| Correctly implemeted the getters                                                 | +1pt                                                                                                                                                                         |
| Correctly implemented the setters                                                | +1pt                                                                                                                                                                         |
| Correctly implemented `LevelUp`                                                  | +1pt (-0.5pt per error in method)                                                                                                                                            |
| Correctly implemented `TakeDamage`                                               | +1pt                                                                                                                                                                         |
| Correctly implemented a `ToString`                                               | +1pt (Grade generously on this section)                                                                                                                                      |
| Correctly implemetented the empty and populated Constructors                     | +1pt (0.5pt per method)                                                                                                                                                      |
| **Total (with Bonus)**                                                           | **7**                                                                                                                                                                        |

### Additional Info

- For every attribute with an improper name or datatype, take 0.5pt off the 1pt (that is, 2 mistakes result in a 0)
- If the getter or setters are correct w.r.t. the name / datatype of the attribute as implemented by the student, please do not take points off.

## Phase 2

| Criteria                                                                         | Points                                                                                                                                                                       |
|----------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **In**correct filename (lname_fname.zip, not lname_fname.zip.zip for instance)   | -0.5pt                                                                                                                                                                       |
| **In**correct file (archive zipped, not just the .cs file)                       | -0.5pt (if the student did not share their .cs code at all, then your grading ends here)                                                                                     |
| Name and date in a delimited comment **not** at the very beginning of their code | -0.5pt (If they forgot the date, their name, if the comment is in-line, that is `//` and not `/* ... */`, or if it is not the very first thing in the file, they get -0.5pt) |
| If the program does not compile                                                  | Stop here. No points.                                                                                                                                                        |
| Constructors implemented w/ default values                                       | +1pt (0.5pt if everything is correct except default values, otherwise -0.5pt per mistake)                                                                                    |
| Correctly implemeted `AddExp`/`Heal`                                             | +1pt                                                                                                                                                                         |
| Correctly retrieved `name` value                                                 | +0.5pt                                                                                                                                                                       |
| Correctly retrieved `attack` value                                               | +0.5pt                                                                                                                                                                       |
| Correctly retrieved `defense` value                                              | +0.5pt                                                                                                                                                                       |
| Inputs are correctly validated upon entry                                        | +1.5pts (-0.5pt per mistake)                                                                                                                                                 |
| Created `Fighter` object with values                                             | +1pt                                                                                                                                                                         |
| Correctly implemetented constructor w/ random `attack`/`defense`                 | +1pt (0pts if random is not used; no deductions if only name, attack, and defense are assigned)                                                                              |
| **Total (with Bonus)**                                                           | **7**                                                                                                                                                                        |

## Phase 3

| Criteria                                                                         | Points                                                                                                                                                                       |
|----------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **In**correct filename (lname_fname.zip, not lname_fname.zip.zip for instance)   | -0.5pt                                                                                                                                                                       |
| **In**correct file (archive zipped, not just the .cs file)                       | -0.5pt (if the student did not share their .cs code at all, then your grading ends here)                                                                                     |
| Name and date in a delimited comment **not** at the very beginning of their code | -0.5pt (If they forgot the date, their name, if the comment is in-line, that is `//` and not `/* ... */`, or if it is not the very first thing in the file, they get -0.5pt) |
| **If the program has major compile errors**                                      | Stop here. No points.                                                                                                                                                        |
| **If the program has minor compile errors**                                      | Fix errors and continue (or ask Instructor to review)                                                                                                                        |
| Random constructor implemented                                                   | +1pt                                                                                                                                                                         |
| Creates random opponent                                                          | +0.5pt (No points if random constructor isn't used)                                                                                                                          |
| Retrieves validated attack from user                                             | +0.5pt (No points if any mistakes)                                                                                                                                           |
| Randomly generates opponent attack                                               | +0.5pt (No points if any mistakes)                                                                                                                                           |
| Correctly defines attack structure                                               | +2pts (+0.5pt per correct condition)                                                                                                                                         |
| Heals/Adds Exp when opponent is defeated                                         | +1pt (+0.5pt per)                                                                                                                                                            |
| Exits loop and displays rounds beaten when player is defeated                    | +0.5pt                                                                                                                                                                       |
| Modified ToString                                                                | +1pt                                                                                                                                                                         |
| Added heavy attack move w/ proper attack structure additions                     | +2pts                                                                                                                                                                        |
| **Total (with Bonus)**                                                           | **9** (Max Points is 8, even if all bonus points are completed)                                                                                                              |