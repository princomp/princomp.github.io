---
tags:
- datatypes/collections
---

# Simple I/O (Solutions)

## Questions

#. The method `ReadLine()` reads a whole line and interprets its content as an integer (`int`) type.

	- [ ] Yes
	- [x] No

#. A _____ can be used in repetition structures (such as loops) to indicate the end of data entry.

	- [ ] Property
	- [ ] `using` directive
	- [ ] Sentinel value
	- [x] None of the above.

#. In C#, what is the "escape character"? Why is it useful?

	<details>
	<summary>Solution</summary>
	The escape character is `\`. It is useful for telling the compiler that the following character should be interpreted as something other than text, such as a newline in the case of `\n`.
	</details>

#. In C#, what is the name of the method used to read input from the user?

	<details>
	<summary>Solution</summary>
	`Console.ReadLine()`
	</details>

## Problems

#. Write a program that performs the following steps:

	#. Asks user to enter any number between 1 and 100
	#. Multiplies the number user enters by 2
	#. Displays the result of the calculation on the screen

	Here is an example of execution, where the user input is underlined, and hitting "enter" is represented by ↵:


	```
	Hello user!

	Please enter a number between 1 and 100: 3͟2͟↵

	32 multiplied by 2 is 64!
	```

	Run your program a few times and use different numbers in range 1-100 to verify the program works as intended.

	<details>
	<summary>Solution</summary>

	```
	Console.WriteLine("Hello user!");
	Console.Write("Please enter a number between 1 and 100: ");
	double input = double.Parse(Console.ReadLine());
	Console.WriteLine($"{input} multiplied by 2 is {input * 2}!");
	```

	</details>

#. Write statements that prompt the user to enter their favorite food and store the input value in a variable.

	<details>
	<summary>Solution</summary>

	```
	Console.Write("Enter your favorite food:");
	string uInput = Console.ReadLine();
	```
	</details>

#. Write statements that prompt the user to enter 3 numbers, and then return their average.

	<details>
	<summary>Solution</summary>

	```
		decimal[] nums = new decimal[3];
		Console.WriteLine("Please enter 3 numbers.");

		for (int i = 1; i < 4; i++)
		{
			Console.Write($"\n{i}: ");
			nums[i] = Console.ReadLine();
		}
		Console.WriteLine($"\n"The average of these numbers is: {(nums[0] + nums[1] + nums[2]) / 3});
	```
	</details>

#. Write statements that prompt the user to enter a positive number, and then output all the odd numbers between 0 and that number.​

	<details>
	<summary>Solution</summary>

	```
		Console.Write("Please enter a positive number: ");
		int uInput = int.Parse(Console.ReadLine());

		for (int i = 0; i <= uInput; i++)
		{
			if (i % 2 == 1)
				Console.Write(i + " ");
		}
	```

	</details>

#. Write a series of statements that: 

	#. Declare an `int` variable named `userAge`,
	#. Display on the screen a message asking the user to enter his or her age,
	#. Read the value entered by the user and store it in the `userAge` variable.

	You can add statement(s) performing intermediate steps if you want.

	<details>
	<summary>Solution</summary>

	```
		int userAge;
		Console.Write("Please enter your age: ");
		userAge = int.Parse(Console.ReadLine());
	```
	</details>
