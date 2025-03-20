---
tags:
  - datatypes/numerical
---

# Numerical (Solutions)

## Warm-up Exercises

#. Write an explicit conversion from a `double` variable `myDoubleVar` to an `int` variable called `myIntVar`. You don't need to re-declare those variables. Assuming `myDoubleVar`'s value is `5.89`, what value would be stored in `myIntVar`?

  <details>
  <summary>Solution</summary>

  `myIntVar = (int)myDoubleVar;`

  The value stored in `myDoubleVar` would be `5`.
  </details>

#. Declare and initialize two integer variables, `x` and `y`. Choose any values you want. Then write necessary commands to display the result of the following 3 mathematical operations: addition, multiplication, and remainder (modulo) of `x` and `y`.

    An example of output, with `x` set to 5 and `y` set to 3:

    ```
    5 + 3 = 8
    5 * 3 = 15
    5 % 3 = 2
    ```

    An example of output, with `x` set to 4 and `y` set to 2:

    ```
    4 + 2 = 6
    4 * 2 = 8
    4 % 2 = 0
    ```

    <details>
    <summary>Solution</summary>

    ```
    int x = 6;
    int y = 8;

    Console.WriteLine($"{x} + {y} = {x + y}");
    Console.WriteLine($"{x} * {y} = {x * y}");
    Console.WriteLine($"{x} % {y} = {x % y}");
    ```
    </details>

#. Write a command that performs *implicit* conversion between two numeric datatypes. Then, write a command that performs *explicit* conversion between two numeric datatypes. Add a comment above both commands to clearly indicate which command is implicit and which one is explicit.

    <details>
    <summary>Solution</summary>

    ```
    // Implicit Conversion: from int to double
    int num = 23;
    double bigNum = num;

    // Explicit Conversion: from double to int
    double myDouble = 54.873
    int myInt = (int)myDouble;
    ```
    </details>

## Questions

#. What distinguishes the `decimal` datatype from other numeric types? What happens when a `decimal` value is used with the `C` format specifier?

    <details><summary>Solution</summary>

    The `decimal` type is the most precise of the numeric types, and it can be used with the `C` format specifier to display values representing amounts of currency.
    </details>

#. What can you learn from this UML class diagram?
  
    !include uml/cla/Contact.md

    <details><summary>Solution</summary>
        This diagram shows a class called "Contact", which contains a private variable of type `string` called "name" and two public methods. The method called "SetName" has a `void` return type and has a parameter of type `string` called "accountName". The method called "GetName" returns a `string` value and has no parameters.
      </details>

#. Can conversion between two number types change value of a number? Provide an example case.

    <details>
    <summary>Solution</summary>

    Yes. For example, when `float`s, `double`s, and `decimal`s are converted to `int`s, the value must be *truncated* (shortened). For example, the value `4.876f`, when converted to a `int`, will become 4.
    </details>

#. Assume you have an `int` variable named `myAge` whose value is `24`. What would be displayed on the screen by the following? 

    `Console.WriteLine($"{myAge * 2}");`

    <details>
    <summary>Solution</summary>
    `48`
    </details>

#. Give the values of a and b after the following four instructions have been executed.

    ```
    int a, b;
    a = 2;
    b = a * 2 + 1;
    a -= 1;
    ```

    <details>
    <summary>Solution</summary>
    The value of `a` is `1` and the value of `b` is `5`.
    </details>

#. Give the values of c and d after the following four instructions have been executed.

    ```
    int c = 3, d;
    d = 2 + c;
    c = d * 2;
    d += 2;
    ```

    <details>
    <summary>Solution</summary>
    The value of `c` is `10`, and the value of `d` is '7'.
    </details>

#. Is there an error in the following code? Explain the error or give the value of b after the second statement is executed.

    ```
    float a = 3.7f;
    int b = (int)a;
    ```

    <details>
    <summary>Solution</summary>
    The value of `b` is `3`.
    </details>

#. Is there an error in the following code? Explain the error or give the value of b after the second statement is
executed.

    ```
    decimal a = 1.6M;
    int b = (int)a + a;
    ```

    <details>
    <summary>Solution</summary>
    The code produces an error because the second statement performs a math operation resulting in a decimal value and attempts to assign said value to an integer variable.
    </details>

#. If one of the operator's operand is of type `float` and the other is of type `int`, what will be the type of the result of the operation?

    <details>
    <summary>Solution</summary>
    The result of the operation will be of type `float`.
    </details>

#. What is the return type of the operation 12.4 * 3?

    <details>
    <summary>Solution</summary>
    The return type of the operation is `float`.
    </details>

#. Give the values of `a` and `b` after the following four instructions have been executed.

    ```
    int a, b;
    a = 4;
    b = a * 3 + 1;
    a /= 2;
    ```

    <details>
    <summary>Solution</summary>
    The variable `a` has value 2, and the variable `b` has value 13.
    </details>

#. There is an error in the following code, at the second line. Explain the error and how you could fix this using a cast operator, without changing the datatype of the `b` variable.

    ```
    decimal a = 2.5M;
    int b = a / 2;
    ```

    <details>
    <summary>Solution</summary>
    Since the operation `a / 2` results in a `decimal` value, attempting to store it in an `int` variable results in an error. This can be fixed by casting the value of `a`, like so: `int b = (int)a / 2;`
    </details>

#. What is the return type of the operation 12.4 * 3?

    <details>
    <summary>Solution</summary>
    This will evaluate to a `double` value.
    </details>


## Problems

#. Write down, on a piece of paper, a fully compilable program that initializes an int variable named `persons` with the value 5, an `int` variable named `bottles` with the value 3, and a `double` variable named `litersPerBottle` with the value 1.5. Initialize a variable named `litersPerPerson` with the value resulting from a mathematical expression calculating the number of liters that each person would receive if split equitably, and make sure that this variable is of the type which can properly store the resulting value. Write a statement that displays its value.

    Place a delimited comment with your name and the date of writing at the top of the program.

    <details>
    <summary>Solution</summary>

    ```
    /*
     * Student Name
     * 2025/03/15
     */

    int persons = 5;
    int bottles = 3;
    double litersPerBottle = 1.5;

    double litersPerPerson = (bottles * litersPerBottle) / persons;
    Console.Write($"Each person would receive {litersPerPerson} liters.");
    ```

    </details>
