---
tags:
- oop/uml
- oop/objects
---

# Inheritance (Solutions)

## Questions

#. What is the keyword used to call the constructor from the base class?

  - [ ] `this`.
  - [ ] the name of the base class.
  - [x] `base`
  - [ ] `over`
  - [ ] `inherits`


## Problem

Consider the following diagram:

!include uml/cla/RoomClassroomOffice.md

Suppose you are given an implementation of the `Room` class, such that 

```
!include`snippetStart="// Question 1",snippetEnd="// Refer to Classroom.cs for a solution"` code/projects/RoomClassroomOffice/RoomClassroomOffice/Program.cs
```

displays

```text
UH 243
```

#. Write an implementation of the `ClassRoom` class. Your `ToString` method should display the room's building and number, in addition to whether it has AV set-up.

    <details><summary>Solution</summary>
    ```
    !include code/projects/RoomClassroomOffice/RoomClassroomOffice/Classroom.cs
    ```
    </details>

#. Write a `SameBuilding` static method to be placed inside the `Room` class such that

    ```
    !include`snippetStart="// Question 2",snippetEnd="// Refer to Room.cs for a solution.",dedent=4` code/projects/RoomClassroomOffice/RoomClassroomOffice/Program.cs
    ```
    Would display "true" and "false".
    
    <details><summary>Solution</summary>
    ```
    !include`snippetStart="// (not on UML diagram)",snippetEnd="// Note that since we are inside the class,"` code/projects/RoomClassroomOffice/RoomClassroomOffice/Room.cs
    ```
    </details>
