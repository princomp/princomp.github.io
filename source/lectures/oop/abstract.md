---
tags:
- oop
---

# Abstract Classes

## Motivation

Consider the following situation:

- We want to implement a class for students, and one for employees.
- We realize that those class overlap heavily: they both need properties for an id, a name, an emergency phone number, an address, etc., identical methods to e.g., implement an automated alert system, etc.
- However, they do not overlap perfectly: for example, students will have a major but employees won't, and employee will have an hourly wage but students won't. Also, some checks will be different: while both students and employees will have an id, the former will always start with the letter 'S', and the latter with the letter 'E'.
- So we really do need two different classes, but would like for them both to inherit a "Person" class that implements all the overlapping properties, attributes and methods.
- **But** we **do not** want persons "objects" to be created: a "person" in isolation does not make sense in our model, we only want to implement students or employees, not "persons".

The mechanism used to obtain this behavior (being able to inherit from a class while disallowing instantiating it) is achieved using the `abstract` keyword.

## Example

Consider a (shortened) version of the example above. We start by implementing an *abstract* `Person` class:

```
!include code/projects/AbstractClass/AbstractClass/Person.cs
```

Note that the `Id` property is *also* marked as `abstract`: this means that the derived class will have to re-implement this property's setter.
Then, we can implement the `Student` and `Employee` classes by inheriting from the `Person` class:

```
!include code/projects/AbstractClass/AbstractClass/Employee.cs
!include code/projects/AbstractClass/AbstractClass/Student.cs
```

Using this code, the statement

```
Person test = new Person();
```

would return the quite clear error message "Cannot create an instance of the abstract type or interface 'Person'".

Furthermore, the following exemplifies the expected behavior:

```
!include code/projects/AbstractClass/AbstractClass/Program.cs
```

The statement `Morgan.Id = "E8194";` will raise exception, but `Morgan.Id = "S8194";` will execute without throwing an error.
