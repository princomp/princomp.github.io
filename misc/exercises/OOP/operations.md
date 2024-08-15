---
tags:
  - oop/operations
aliases:
  - OOP - Operations
  - Object Oriented Programming - Operations
---

## Warm-up Exercises

## Questions

#. How do you make reference to a public property Name outside of the class. 
  - [ ] *Name
  - [ ] +Name
  - [x] .Name
  - [ ] neither of these

#. In C#, you should think of the class’s properties as the class’s attributes.

  - [x] Yes
  - [ ] No

#. The property notation allows the client to directly manipulate the private instance variable.

  - [ ] Yes
  - [x] No

#. Consider the code:
```cs
public void SetName(string tempAccountName)
{
name = tempAccountName; // store the account name
}
```
Which of the following statements is false?
- [ ] The first line of each method declaration is the method header.
- [ ] The method’s return type specifies the type of data the method returns to its caller
after performing its task.
- [ ] The return type void indicates that when SetName() completes its task, it does not
return any information to its calling method.
- [x] All methods require at least one parameter to provide data to perform tasks.

#. A return type of _____ is specified for a method that does not return a value.
- [ ] int
- [ ] double
- [x] void
- [ ] None of the above.

#. Methods are called by writing the name of the method followed by _____ enclosed in parentheses.
- [ ] a condition
- [x] argument(s)
- [ ] a counter
- [ ] None of the above.

#. The parameter list in the method header and the arguments in the method call must agree in:
- [ ] Number
- [ ] Type
- [ ] Order
- [x] All of the above

#. Suppose method1 is declared as
```cs
public void method1(int a, float b, string c)
```
Which of the following methods does not overload method1?
- [x] void method2(int a, float b, char c)
- [ ] int method1(float a, int b, string c)
- [ ] float method1(int a, float b)
- [ ] string method1(string a, float b, int c)

## Problems