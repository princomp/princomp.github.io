---
tags:
- datatypes/strings
---

## Warm-up Exercises

#. Assuming that myLastName and myFirstName are two string variables that have been initialized, write a statement that concatenates them, with a space and a comma in-between, and assign the resulting string to a variable named fullName. For instance, if the value of myLastName is "Holbertonand", and the value of myFirstName is "Betty", then the value of fullName after your operation should be "Holbertonand, Betty".

<details>
<summary>Solution</summary>
`Console.Write($"{myLastName}, {myFirstName}");`
</details>


## Questions

#. What is string interpolation?

<details>
<summary>Solution</summary>
String interpolation is the use of variables in within a string.
</details>

#. What is the difference, if any, between the `WriteLine` and `Write` methods?

<details>
<summary>Solution</summary>
The WriteLine method appends a newline character to the end of the argument passed into it while Write does not.
</details>

#. Assume we have a variable whose name is `myVariable`, whose type is **string**, and whose value is "My message". What would be displayed at the screen by the following statement?

`Console.WriteLine($"Here is my variable: {myVariable}");`

<details>
<summary>Solution</summary>
"My message"
</details>

#. Is the name myVariable the same as myvariable? If not, why?

<details>
<summary>Solution</summary>
The variable names myVariable and myvariable are different because variable names are case sensitive.
</details>



## Problems

#. Write down, on a piece of paper, a program that:

1. Declares a string variable named `userName`.

2. Displays on the screen `Please, enter your name, followed by enter: `.

3. Reads a string value from the keyboard and assigns the value to the `userName` variable.

4. Declares an int variable named `number`.

5. Displays on the screen `Please, enter your area code, followed by enter: ` .

6. Reads an int value from the keyboard and assigns the value to the number variable.

7. Declares a string variable named `id` and initializes it with the string referenced by the `userName` variable, followed by the number entered by the user (you can concatenate a string and an int using the \` sign).

8. Displays on the screen, `Your id is ` and the content of the id variable.

Here is an example of execution, where the user input is underlined, and hitting “enter” is represented by ↵:

```
Please, enter your name, followed by enter:
Clément ↵
Please, enter your area code, followed by enter:
828 ↵
Your ID is Clément828
Press any key to continue . . .
```

<details>
<summary>Solution</summary>

```cs
string userName;

Console.WriteLine("Please enter your name, followed by enter.");
userName = Console.ReadLine();

int number;

Console.WriteLine("Please enter your area code, followed by enter.");
number = int.Parse(Console.ReadLine());

string id = userName + number;

Console.WriteLine("Your ID is " + id);
```
</details>

#. Write a series of statements that:
	a) Declare a **string** variable named `favoriteColor`
	b) Display on the screen a message asking the user his or her favorite color
	c) Read the value entered by the user and store it in the `favoriteColor` variable.
You can combine some of the statements if you want, but do not display on the screen any information that was not explicitly asked.

<details>
<summary>Solution</summary>

```cs
string favoriteColor;

Console.Write("Please enter your favorite color: ");
favoriteColor = Console.ReadLine();
```
</details>