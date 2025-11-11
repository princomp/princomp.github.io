---
tags:
- datatypes
---

# Actions

## Motivation

[Higher-order programming](https://en.wikipedia.org/wiki/Higher-order_programming) allows to manipulate for example methods themselves. 
This can be useful for many purposes, and is called ["delegates"](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/) in C#.
We explain its basics below, and refer to [the sorting lecture](./lectures/misc/sorting) for an example of how it can be used.

## Action -- In short

[An *action* is](https://learn.microsoft.com/en-us/dotnet/api/system.action?view=net-9.0)

> a  method that has no parameters and does not return a value.

An "Action<T>" is a method that has a single parameter (of type `T`) and does not return a value.

Here are for example three actions:

```
!include code/projects/Actions/Actions/ExampleActions.cs
```

- `Test`, `Display` and `DisplayArray` all have `void` as their return type,
- `Test` does not take any argument,
- `Display` takes an `int` as an argument,
- `DisplayArray` takes "an array of `T`" (that is, a [generic type](./lectures/oop/generic_types) as an argument.

We can call those easily:

```
!include`snippetStart="// We can call our methods directly:", snippetEnd="// Or we can store them"` code/projects/Actions/Actions/Program.cs
```

We can also store them into variables and then call them:

```
!include`snippetStart="// in variables and then call them:", snippetEnd="// Passing an Action as an argument:"` code/projects/Actions/Actions/Program.cs
```

As we can see, `ExampleActions.Display` is of type `Action<int>` since the `Display` method takes an `int` as argument.

## Action as Parameter

Method can take actions as parameter:

```
!include code/projects/Actions/Actions/CallingAction.cs
```

and then can be passed an action as an argument:

```
!include`snippetStart="// Passing an action as an argument:", snippetEnd="// Done passing an action."` code/projects/Actions/Actions/Program.cs
```
