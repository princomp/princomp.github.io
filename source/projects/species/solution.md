# Solution

## Simplest Solution

A possible solution is shared [in this archive](./code/projects/Species.zip)

Note that

- in the `Animal` class, a `EpsilonD` constant was added to test if a double is "almost" 0,
- in the `Bat` class, a `FlightSpeed` property was added to facilitate testing the validity of its value,
- in the `Bat` class, objects are created even if the number of mammary glands is not 2 or 4, but a message is displayed,

This solution completes the "(easy) The ToString() methods return the information nicely formatted, as above." bonus, and a solution to the "(medium) You explain briefly (in comment) why the SoundProduced method is not given as an abstract static method in the Mammal class." can be as follows:

> In short, static methods cannot be inherited or overridden in C#, and that is why they cannot be abstract.
> This is discussed in some details in [this stack exchange post](https://stackoverflow.com/questions/3284/why-cant-i-have-abstract-static-methods-in-c).
> A change was recently introduced in .NET 6, that [makes static abstract members in interface possible](https://learn.microsoft.com/en-us/dotnet/core/compatibility/core-libraries/6.0/static-abstract-interface-methods), but it is limited to interfaces, and abstract static methods cannot be added to abstract classes.

## Possible misconceptions

Some additional possible misconceptions are discussed [in this project](./code/projects/Properties_errors.zip).
