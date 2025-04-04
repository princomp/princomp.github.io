---
tags:
- datatypes/strings
---

# Strings (Solutions)

## Warm-up Exercises

#. Assuming that `myLastName` and `myFirstName` are two string variables that have been initialized, write a statement that concatenates them, with a space and a comma in-between, and assign the resulting string to a variable named `fullName`. For instance, if the value of `myLastName` is "Holbertonand", and the value of `myFirstName` is "Betty", then the value of `fullName` after your operation should be ["Holbertonand, Betty"](https://en.wikipedia.org/wiki/Betty_Holberton).

	<details>
	<summary>Solution</summary>
	`string fullName = $"{myLastName}, {myFirstName}";`
	</details>


## Questions

#. What is string interpolation?

	<details>
	<summary>Solution</summary>
	String interpolation is the use of specialized syntax (`$` and curly braces) to include variables within a string.
	</details>

#. What is the difference, if any, between the `WriteLine` and `Write` methods?

	<details>
	<summary>Solution</summary>
	The `WriteLine` method appends a newline character to the end of the argument passed into it while `Write` does not.
	</details>

#. Assume we have a variable whose name is `myVariable`, whose type is `string`, and whose value is "My message". What would be displayed on the screen by the following statement?

	`Console.WriteLine($"Here is my variable: {myVariable}");`

	<details>
	<summary>Solution</summary>
	"Here is my variable: My message"
	</details>

#. Is the name myVariable the same as myvariable? If not, why?

	<details>
	<summary>Solution</summary>
	The variable names myVariable and myvariable are different because variable names are case sensitive.
	</details>

## Problems

#. Write down, on a piece of paper, a program that:

	#. Declares a `string` variable named `userName`.
	#. Displays on the screen: `Please, enter your name, followed by the enter key: `.
	#. Reads a `string` value from the keyboard and assigns the value to the `userName` variable.
	#. Declares an `int` variable named `number`.
	#.  Displays on the screen: `Please, enter your area code, followed by the enter key: `.
	#. Reads an `int` value from the keyboard and assigns the value to the `number` variable.
	#. Declares a `string` variable named `id` and initializes it with the string referenced by the `userName` variable, followed by the number entered by the user. (Note: you can cocatenate a `string` and an `int` using the `+` sign.)
	#. Displays on the screen: `Your id is `, followed by the content of the `id` variable.

	Here is an example of execution, where the user input is underlined, and hitting "enter" is represented by ↵:

	```
	Please, enter your name, followed by enter:
	C͟l͟é͟m͟e͟n͟t͟ ↵
	Please, enter your area code, followed by enter:
	8͟2͟8͟ ↵
	Your ID is Clément828
	Press any key to continue . . .
	```

	<details>
	<summary>Solution</summary>

	```
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

	#. Declare a `string` variable named `favoriteColor`
	#. Display on the screen a message asking the user his or her favorite color
	#. Read the value entered by the user and store it in the `favoriteColor` variable.

	You can combine some of the statements if you want, but do not display on the screen any information that was not explicitly asked.

	<details>
	<summary>Solution</summary>

	```
	string favoriteColor;

	Console.Write("Please enter your favorite color: ");
	favoriteColor = Console.ReadLine();
	```
	</details>
