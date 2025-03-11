---
tags:
  - datatypes
---
## Warm-up Exercises

#. Explain Boolean type `bool` and the meaning of logical operations AND (&&), OR (||) and negation (!). Provide a small example.
<details>
<summary>Solution</summary>

The Boolean data type holds either of the two values `true` or `false`. The AND and OR operators are used to evaluate multiple conditions. The AND returns `true` if all conditions are true, and the OR operator returns `true` if at least one of them is true. The negation operator changes a Boolean value into its opposite.	  

Example:
```
bool b1 = true, b2 = false;
	
Console.Write(b1 && !b2); // outputs true
Console.Write(b1 || b2); // outputs true
```
</details>

#. Declare a variable of type `int`, with value 3.​

<details>
<summary>Solution</summary>

```
int num = 3;
```
</details>

## Questions

#. Write a statement that initializes a variable named `myHeightInMeters` to your height in meters. What should be the datatype of `myHeightInMeters`, and why?

<details>
<summary>Solution</summary>

`decimal myHeightInMeters = 1.74m;`
The datatype should be `decimal` because a person's height in meters most likely needs the precision afforded by the decimal type. 
</details>
 
#. What is wrong with the following? Will the error(s) appear at compilation time, or at execution time?

```cs
int age;
Console.WriteLine("Please enter your age:");
age = Console.ReadLine();
```
<details>
<summary>Solution</summary>
	
`Console.ReadLine()` returns a value of type `string`, which cannot be stored in an integer variable. This results in a compile time error.
</details>

#. What is the difference, if any, between 3 and "3"?
<details>
<summary>Solution</summary>
3 is an integer value, and "3" is a string value.
</details>



## Problems

#. Declare and initialize 3 variables:
1. Each variable should have a different data type
2. Choose an appropriate name and value for each variable
Then display the value of each variable on the screen.

<details>
<summary>Solution</summary>

```cs
int number = 5;
string name = "Samuel";
float weight = 120.65f;

Console.WriteLine($"number: {number}");
Console.WriteLine($"name: {name}");
Console.WriteLine($"weight: {weight} kg");
```
</details>

[[collections]]
[[strings]]
[[numerical]]

