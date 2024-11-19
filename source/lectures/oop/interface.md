---
tags:
- oop
---

# Interfaces

## Motivation

Imagine you want to represent a variety of devices, and comes up with the following UML diagram:

!include uml/cla/Devices.md

Note that it is possible to gather that e.g., the `Instructions()` method in the `Abacus` class is overriding the `Instructions()` method in the `ComputingDevice` class because it has the same signature: this can be the case only because it is overriding the inherited abstract method.

Your abstract classes are "completely abstract", in the sense that all of their properties and methods are abstract, but it serves your purpose just well:

- you do not want "ComputingDevices" to exist in isolation, but you want any class representing a computing device such as the [Abacus](https://en.wikipedia.org/wiki/Abacus), the [Pascaline](https://en.wikipedia.org/wiki/Pascal%27s_calculator) or the [Turing Tumble](https://en.wikipedia.org/wiki/Turing_Tumble) to have an *Instruction per seconds* property, and a method to display instructions. 
- similarly, you want any "ElectronicalDevice" to have properties pertaining to their voltage and frequency, as well as a method to display a safety notice.

A class that is "completely abstract" actually forces you to enforce a series of constraints and is a good way of making sure that you are consistent e.g., with the naming of your methods, the accessibility of your properties, or the return type of your methods.

You implement it as follows:

```
!include code/projects/Devices/Devices/ComputingDevice.cs
```
```
!include code/projects/Devices/Devices/Abacus.cs
```
```
!include code/projects/Devices/Devices/ElectricalDevice.cs
```
```
!include code/projects/Devices/Devices/USWashingMachine.cs
```
```{download="./code/projects/Devices.zip"}
!include code/projects/Devices/Devices/Program.cs
```

Then, you would like to add a "Computer" class, but face an issue: classes can inherit only from one class directly, but of course a computer is _both_ an electrical device **and** a computing device.
A solution is to switch to *interfaces*.

## Explanations

Interfaces are completely abstract classes: they do not implement anything, they simply force classes inheriting from them (we actually say _that realizes them_) to implement certain features.

### In Diagram

Interfaces are prefixed by the `«Interface»` mention, and have all their properties and methods marked as abstract (so, in *italics*).
A class can "inherits" from multiple interface (we say that it **realizes** multiple interfaces), and this is marked with an arrow with an open triangle end and a dashed line^[Note that, this time, since our code below does **not** override the methods and properties, there really is no need to repeat them the derived classes.].

!include uml/cla/DevicesInterfaces.md

### An Implementation

Implementing such interfaces and their realization could be done as follows:

```
!include code/projects/DevicesInterfaces/DevicesInterfaces/ComputingDevice.cs
```
```
!include code/projects/DevicesInterfaces/DevicesInterfaces/ElectricalDevice.cs
```
```
!include code/projects/DevicesInterfaces/DevicesInterfaces/Computer.cs
```
```{download="./code/projects/DevicesInterfaces.zip"}
!include code/projects/DevicesInterfaces/DevicesInterfaces/Program.cs
```

Note that

- in the `ComputingDevice` and `ElectricalDevice`,
    - `abstract class` has been replaced by `interface`,
    -  there is no need for the `abstract` keyword (all is abstract already!),
    - there is no need for the `public` keyword (everything _has_ to be public),
- in the `Computer` realization,
    - the class *realizes* two interfaces, simply separated by a comma:
    
        ```
        Computer: ElectricalDevice, ComputingDevice
        ```
    - there is no need for the `override` keyword,

## A More Complicated Example
    
!include uml/cla/Shape.md

[in this archive](./code/projects/Shape.zip)
