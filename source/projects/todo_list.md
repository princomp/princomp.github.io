---
tags:
- control-structures
---

# Todo List

## Description

### Purpose

This project is designed to teach you how to devise, implement, and submit solutions to the simple programming problem of constructing a "todo list software".
It aims at making sure that you master the simple concepts of control structures and data manipulation before introducing more advanced concepts.

### Challenge

#### In short

Develop a simple program that asks the user to provide their todo list, and then tracks the completion of the items (or "tasks") on that list.

#### In more details

#. Your program should start by asking the user to provide items for their todo list, one by one.
#. Once the user is done providing the items, it should display the todo list, with a number associated to each item, and its status (done or not done).
#. Then, your program should ask the user to enter the number of the item they have just completed. There are three cases:

    #. If the user enters something that is not a number, your program should simply ask again.
    #. If the user enters an "invalid" number (that is, that does not correspond to the number of an item), your program should ask again.
    #. If the user enters the number of an item that is not done, its status should become "done".
#. Once the user entered the number of item, the updated todo list should be displayed, and the user should be asked for another number of an item.
#. Once the user completed all the items in the list, the program should display a celebratory message about being done.

### Example

Here is an example of execution, where the user input is u͟n͟d͟e͟r͟l͟i͟n͟e͟d͟, and hitting "enter" is represented by "⏎͟":

```text
What is on your todo list? Enter "done" when you are done.
M͟a͟k͟e͟ ͟s͟u͟r͟e͟ ͟m͟y͟ ͟I͟D͟E͟ ͟i͟s͟ ͟s͟t͟i͟l͟l͟ ͟w͟o͟r͟k͟i͟n͟g͟.͟⏎͟
What is on your todo list? Enter "done" when you are done.
C͟o͟m͟p͟i͟l͟e͟ ͟a͟ ͟s͟i͟m͟p͟l͟e͟ ͟"͟H͟e͟l͟l͟o͟ ͟W͟o͟r͟l͟d͟"͟ ͟p͟r͟o͟g͟r͟a͟m͟.͟⏎͟
What is on your todo list? Enter "done" when you are done.
S͟t͟a͟r͟t͟ ͟w͟o͟r͟k͟i͟n͟g͟ ͟o͟n͟ ͟t͟h͟i͟s͟ ͟p͟r͟o͟j͟e͟c͟t͟.͟⏎͟
What is on your todo list? Enter "done" when you are done.
d͟o͟n͟e͟⏎͟
Here is your current todo list:
| # | Status | Task |
| 1 |   ☐    | Make sure my IDE is still working.
| 2 |   ☐    | Compile a simple "Hello World" program.
| 3 |   ☐    | Start working on this project.
Enter the number of the task you completed.
N͟o͟t͟ ͟y͟e͟t͟.͟⏎͟
Enter the number of the task you completed.
1͟⏎͟
Here is your current todo list:
| # | Status | Task |
| 1 |   ☑    | Make sure my IDE is still working.
| 2 |   ☐    | Compile a simple "Hello World" program.
| 3 |   ☐    | Start working on this project.
Enter the number of the task you completed.
3͟⏎͟
Here is your current todo list:
| # | Status | Task |
| 1 |   ☑    | Make sure my IDE is still working.
| 2 |   ☐    | Compile a simple "Hello World" program.
| 3 |   ☑    | Start working on this project.
Enter the number of the task you completed.
4͟ ⏎͟
Enter the number of the task you completed.
2͟⏎͟
You're all done, congratulations!

Press any key to continue...
```

### Bonuses

- The behaviour of the program if the user enters the number of an item whose status is "done" is not specified above. Write (as a comment) in your program which behaviour you implemented, and test it.
- Complete the project without resizing arrays.
- Improve the way the todo list is displayed using [string formatting](./labs/OverflowAndUnderflow#optional-string-formatting).
- Display, along with the list of items, the completion rate: for example, after the user completed the first of their list of 4 items, the program should display "You are 25% done!".

### Submission

Please, follow our [guideline on project submission](./projects/submission).
In particular, make sure you write your name and the date in a delimited comment at the beginning of your file.

<!--

## Solution

### Simplest Solution

A possible solution, using arrays but not resizing them, is as follows:

```
!include code/projects/TodoList_Array/TodoList/Program.cs
```

You can [download it here](./code/projects/TodoList_Array.zip)

### Using Classes 

Another solution is to create a class for "todo list items" and to create an array of them.
That is, have a class file `Todo.cs` along the lines of

```
class Todo{
    public string Description{get; set;}
    public bool Status{get; set;}
}
```

and then to create and manipulate arrays of `Todo` objects, for example as follows:

```
Todo[] todoList = new Todo[100];
todoList[0] = new Todo();
todoList[0].Description = "My first item";
todoList[0].Status = false;
Console.Write(todoList[0].Description + (todoList[0].Status ? " done" : " not done"));
```
-->
