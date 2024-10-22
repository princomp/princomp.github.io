---
tags:
- oop
---

#  Polymorphism

## Motivation

[Inheritance](./lectures/oop/inheritance) provides another very useful mechanism: [(subtype) *polymorphism*](https://en.wikipedia.org/wiki/Polymorphism_(computer_science)#Subtyping).
In a nutshell, the idea is that if a `Pyramid`^[Technically, a "rectangular pyramid", if we require the pyramid to have a rectangle as its base.] class extends the `Rectangle` class, then a `Pyramid` object can *still access all the `Rectangle`'s public methods, properties and attributes*. Indeed, a `Pyramid` *is a* `Rectangle`: this is precisely what polymorphism means.

While the example below is abstract, it can be easily instantiated to e.g., a `Cat` class inheriting from a `Pet` class or a `Pyramid` class inheriting from a `Rectangle` class.

## Inheriting Attributes, Properties and Methods

Consider the following two classes:

```
!include code/projects/Polymorphism1/Polymorphism1/Class.cs
```

Then, 

- Any `Class1` object has an attribute `attribute1`, a property `Property1` and a method `SetAttribute1`.
- Any `Class2` object has the attribute, property and method of a `Class1` object, and *in addition*, it has a `Property2` property.

This means that the following code is valid:

```
!include code/projects/Polymorphism1/Polymorphism1/Program.cs
```

Note, however, that `object1.Property2 = "Test";` would not compile, since *an object from `Class1` cannot access the attributes, properties and methods of `Class2`*.
Stated differently, an object in `Class2` *is a(n object in)* `Class1`, but the converse is not true: an object in `Class1` *is not* an object in `Class2`.

## Polymorphism and References

Note that a `Class1` object can be created using a `Class2` constructor, since an object in `Class2` *is a(n object in)* `Class1`.
Formally, we can write:

```
Class1 object3 = new Class2();
```

and then manipulate `object3` like any other *object from `Class1` (it is, in a way, "truncated").
In particular, we can use

```
object3.Property1 = "Test";
```

but `object3.Property2 = "Test";` would not compile *since we would be trying to access a property of `Class2` with a `Class1` object.
Remember that an object in `Class1` *is not* an object in `Class2`, and that the way we declared it, `object3` *is* a `Class1` object.

## Solving Ambiguity

Now, consider the following class implementation and usage:

```
!include code/projects/Polymorphism2/Polymorphism2/Class.cs
```

```
!include code/projects/Polymorphism2/Polymorphism2/Program.cs
```

`Console.WriteLine(object1.Test());` will display "Class1": there is no ambiguity, since `object1` is a `Class1` object, it can access only the methods in its class.
However, the situation is less clear for `Console.WriteLine(object2.Test());`: since `object2` is "at the same time" a `Class1` and a `Class2` object, which method will be called? 
In this case, "Class2" will be displayed since C# prefers the "closest" method available (that is, the one in the same class as the calling object). However, a warning will be issued by the compiler because the `Test` method in `Class2` "hides" the inherited method `Test` from `Class1`.

A much better code explicitly instructs C# to *override* `Class1`'s `Test` method with `Class2`'s `Test` method. 
However, this further requires `Class1`'s `Test` method to explicitly give permission to be overriden, using the `virtual` keyword:

```
!include code/projects/Polymorphism3/Polymorphism3/Class.cs
```

This program will also display, as expected, 

```text
Class1
Class2
```

but this time the compiler will not complain: there is no ambiguity, as `Class2`'s `Test` method must explicitly take precedence when an object in `Class2` is calling a `Test` method.
