---
tags:
- oop
- datatypes/collections
---

# Generic Type Parameter

## Introduction

Imagine that you want to write a method that takes as an argument an array and returns an array of the same type, but with the values reversed.
You may write the following code:

```
public class Helper{
    public static int[] Reverse(int[] arrayP)
    {
        int[] result = new int[arrayP.Length];
        int j = 0;
        for (int i = arrayP.Length - 1; i >= 0; i--)
        {
            result[j] = arrayP[i];
            j++;
        }
        return result;
    }
}
```

Then, this method could be used as follows:

```
int[] array1 = {0, 2, 3, 6};
int[] array1reversed = Helper.Reverse(array1);
```

And then `array1reversed` would contain 6, 3, 2, 0.

This method works as intended, but you can use it only with arrays of *integers*. 
If you want to use a similar method with arrays of, say, `char`, then you need to copy-and-paste the code above and to replace every occurrence of `int` by `char`.
This is not very efficient, and it is error-prone.

## Generic Types

There is a tool in C# to avoid having to be *too* specific, and to be able to tell the compiler that the method will work "with some type", called [generic type parameter](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-type-parameters), using the notation `<T>`.
In essence, `<T>` is affixed after the name of the method to signal that the method will additionally require to instantiate `T` with a particular type.

The previous method would become:

```{download="./code/projects/GenericType.zip"}
!include`snippetStart="// A generic way of reversing an array.", snippetEnd="// A generic way of describing an array."` code/projects/GenericType/GenericType/Helper.cs
```

where three occurrences of `int[]` were replaced by `T[]`, and `<T>` was additionally added between the name of the method and its parameters. This method is used as follows:

```{download="./code/projects/GenericType.zip"}
!include`snippetStart="// Using Reverse:", snippetEnd="// Using Description:"` code/projects/GenericType/GenericType/Program.cs
```

In essence, `Reverse<int>` tells C# that `Reverse` will be used with `T` being `int` (not `int[]`, as the method uses `T[]` for its argument and return type).
Note that to use *the same method* with `char`, we simply use `Reverse<char>`, and then we provide an array of `char` as parameters, and obtain an array of `char` in return.

## Implicitly Typed Local Variables

Sometimes, the body of the method needs to declare variable with the same type as `T`.
Indeed, imagine, for example, that we want to add to our `Helper` class a method that returns a `string` description of an array. 
We can write the following:

```
public static string Description(int[] arrayP)
{
    string returned = "";
    foreach (int element in arrayP)
    {
        returned += element + " ";
    }
    return returned;
}
```

but this method is specific to arrays of `int`, and we would have to write another one for `char`, for example.
Making the header generic is "easy", as we can use, as before:

```
public static string Description<T>(T[] arrayP)
```

but the body is problematic: what should be the type of the `element` variable in the header of the `foreach`? We can simply use `T`, or we can use *implicitly typed variable*.
This technique, that uses the keyword `var` essentially tells C# to … figure out the type of the variable.
In that case, since C# knows the type of the array you are passing, it can easily infer the type of its elements.

We can then rewrite the previous method as follows (using `T`, but simply replacing `T` with `var` gives another way):

```{download="./code/projects/GenericType.zip"}
!include`snippetStart="// A generic way of describing an array.", snippetEnd="// Done."` code/projects/GenericType/GenericType/Helper.cs
```

and use it with

```{download="./code/projects/GenericType.zip"}
!include`snippetStart="// Using Description:", snippetEnd="// Done."` code/projects/GenericType/GenericType/Program.cs
```

for example.

## Comparing

Last but not least, C# does not know if `T` has access to the `==` operator, but it will always assume that a `Equals` method is used: refer to [how arrays are compared](./lectures/misc/references#comparing-arrays) for an example.
