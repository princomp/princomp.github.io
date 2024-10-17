---
tags:
- oop
---

# Inheritance

## Motivation

- One of the benefit of Object-Oriented Programming is to re-use the same class to handle multiple instantiations. This saves the programmer having to repeat or copy the same code again and again.
- But classes can *themselves* re-use code from other classes: this similarly saves the programmer from having to copy the same code again and again.
- Consider for example that a programmer has to write a class for cars, a class for bikes, and a class for planes.
    - All classes will share some attributes: they will all need, for example, an attribute for their number of wheels, one for their passenger capacity, one for their average speed, one for their average price per mile, and so on.
    - All classes may also share some method: typically, how the number of wheels can be accessed, or how to convert their price per mile to a price per kilometer.
    - However, some attributes will be proper to some classes: fork length makes sense only for bikes^[We use "bike" to refer to both bicycles and motorcycles.], maximum altitude only makes sense for planes, trunk size only make sense for cars, etc.
    - This is an example of *inheritance*: the programmer will implement one class for vehicle containing all the shared attributes and methods, and will have the class for e.g., bikes, *inherits* from the vehicle class.
- The most general class is called *the base class* (or superclass). The most particular class is called *the derived class* (or subclass).

## Vehicle & Bike Example

Consider the following class:

!include uml/Vehicle.md
    
with the following implementation:

```
!include code/projects/Vehicle/Vehicle/Vehicle.cs
```

and say that we want to extend it to accommodate bikes. Bikes have, in addition to a color and a cost per mile, a fork length.
Note that no other vehicle have a fork length, so it does not make sense to add this attribute to the `Vehicle` class.

A possible implementation is as follows:

```
!include code/projects/Vehicle/Vehicle/Bike.cs
```

Note:

- The `: Vehicle` on the first line, that make `Bike` a *derived class* from `Vehicle`. Any `Bike` object will have all the attributes and properties of the `Vehicle` class, in addition to its methods. For example, we can have:

    ```
    Bike test2 = new Bike();
    test2.Color = "Green";
    ```
    
    and the `Vehicle` `Color` accessor will be used, since `Bike` does not have an accessor for `Color`.

- Implicitly, the `Bike()` constructor starts by calling the `Vehicle()` constructor, so that `Color` and `costPerMile` are actually set to `"undefined"` and `-1M`, respectively.
- That `SetCPM` into the `Bike()` constructor actually refers to the `SetCPM` method in the `Vehicle` class. A way of being more explicit would have been to write `base.SetCPM` instead of `SetCPM`. In either case, the value `-1M` is overriden by `0.15M`.
- The `: base(cP, cpmP)` instructs to call the 

    `Vehicle(string cP, decimal cpmP)`

    constructor, passing it the values `cP` and `cpmP`.
- The `override` keyword "discards" the `Vehicle` `ToString` method to replace it with a custom `ToString` method for the `Bike` class. Note that we can still access what the `Vehicle` method returns using `base.ToString()`. Note that, in this particular, we have no choice but to call this base `ToString` method, since we have no way of accessing `costPerMile` from the `Bike` class: this attribute is private to the `Vehicle` class, and has no getter.

The inheritance is represent in UML as follows:

!include uml/Bike.md

Note that inheritance can be "chained", as `Bike` could itself be the base class for a `Bicycle` class that could have e.g. a `saddleType` attribute (noting that a motorbike does not have a saddle, but a seat).
We could then obtain a code as follows:

```
!include code/projects/Vehicle/Vehicle/Bicycle.cs
```

Note that `SetCPM` inside the no-args constructor actually calls a `SetCPM` method inside `Bike`, but since there is no such method, it fallback to the `SetCPM` method from the `Vehicle` class.
If there was a `SetCPM` method in both the `Bike` and the `Vehicle` method, we could not force access to the `Vehicle` method^[Actually, we could, if you read [this post](https://stackoverflow.com/a/32562464), but it is considered bad practice.].
