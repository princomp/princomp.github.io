---
tags:
  - oop/operations
aliases:
  - OOP - Operations
  - Object Oriented Programming - Operations
---

## Warm-up Exercises

#. Consider the following partial class definition:
```cs
public class Book
{
	private string title;
	private string author;
	private string publisher;
	private int copiesSold;
}
```
1. Write a statement that would create a `Book` object.
2. Write a "getter" and a "setter" for the `title` attribute.
3. Write a constructor for the `Book` class taking at least one argument.

<details>
<summary>Solution for Part 1</summary>

```cs
Book myBook = new Book();
```
</details>
<details>
<summary>Solution for Part 2</summary>

```cs
public string GetTitle()
{
	return title;
}

public void SetTitle(titleP)
{
	title = titleP;
}
```
</details>
<details>
<summary>Solution for Part 3</summary>

```cs
public Book(string titleP, string authorP)
{
	title = titleP;
	author = authorP;
}
```
</details>

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

#. Write a get method for an instance variable named `total` of type **int**.

<details>
<summary>Solution</summary>

```cs
public int GetTotal()
{
	return total;
}
```
</details>

#. Write a getter for an attribute of type **string** named `myName`.

<details>
<summary>Solution</summary>
```cs
public string GetMyName()
{
	return myName;
}
```
</details>

#. Write a setter for an attribute of type **int** named `myAge`.

<details>
<summary>Solution</summary>
```cs
public void SetMyAge(int age)
{
	myAge = age;
}
```
</details>

#. Assuming name is a **string** instance variable, there is a problem with the following setter. Fix it.
```cs
public int SetName1(string var){
	name = var;
}
```

<details>
<summary>Solution</summary>

```cs
public int SetName1(string nameVar)
{
	name = nameVar;
}
```
</details>

#. Is it possible to have more than one constructor defined for a class? If yes, how can C# know which one is called?

<details>
<summary>Solution</summary>
Yes, C# can identify which constructor is called based on that constructor's method signature, that is, the combination of parameters associated with it.
</details>

#. What is the name of a constructor method? What is the return type of a constructor?

<details>
<summary>Solution</summary>
The name of a constructor method is the name of the class that contains it, and a constructor's return type *is* the class that contains it.
</details>

#. Write a constructor for a `Soda` class with one **string** attribute called `name`.

<details>
<summary>Solution</summary>

```cs
public Soda(string nameP)
{
	name = nameP;
}
```
</details>

#. What is the "default" constructor? Do we always have the possibility of using it?

<details>
<summary>Solution</summary>
The default constructor is one without any parameters. The only case in which it may not be called is if it has not been explicitly defined while other constructors have been defined.
</details>

#. Why would one want to define a constructor for a class?

<details>
<summary>Solution</summary>
By defining a constructor for a class, one can specify which values to assign to the instance variables upon instantiation.
</details>


## Problems