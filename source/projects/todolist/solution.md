# Solution

## Simplest Solution

A possible solution, using arrays but not resizing them, is as follows:

```
!include code/projects/TodoList_Array/TodoList/Program.cs
```

You can [download it here](./code/projects/TodoList_Array.zip)

## Using Classes 

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
