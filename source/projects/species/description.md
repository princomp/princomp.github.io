---
tags:
- oop
---

# Description

## Purpose

This project is designed to teach you how to interpret and implement a simple UML specification involving multiple classes.
It involves inheritance, polymorphism, properties and exception handling.

## Challenge

### In short

Develop multiple classes to represent animal taxonomy.
Different animal species have different characteristics---for example, species that belongs to the mammal class will have mammal glands---but they also all share some common properties, like their conservation status or estimated population.
You need to develop at the same time a system to capture the similarities across species, and to be able to represent relevant attributes and characteristics for each species.

### In more details

We want to implement the classes pictured in the UML diagram (you can zoom in or, in your browser, right click and select "Open Image in New Tab", or access [its text version](./uml/cla/Species.txt)).

!include uml/cla/Species.md

Remembering  that:

- Static methods are u͟n͟d͟e͟r͟l͟i͟n͟e͟d͟,
- Abstract methods are *in italics*.

**Pay attention to details**, and to the following bug: the `SoundProduced` in `Mammal` should be static **and** abstract ([but unfortunately our UML drawing software does not allow this yet](https://github.com/mermaid-js/mermaid/issues/3001)).

In addition, you code should be such that:

- The characters for the `conservationStatus` should be [one of the IUCN Red List of Threatened Species](https://en.wikipedia.org/wiki/Conservation_status#IUCN_Red_List_of_Threatened_Species) code: `EX`, `EW`, `CR`, `EN`, `VU`, `NT`, `CD`, `LC`, `DD`, or `NE`. Your `SetConservationStatus` method should throw an exception if any other value is passed, and your `Animal` constructor should call the `SetConservationStatus` method.
- An exception should be thrown if `Population` is greater than $0$ and `conservationStatus` is set to `EX` (which stands for Extinct). An exception should also be thrown for negative values, except if `conservationStatus` is set to `DD` (data deficient).
- An exception will be raised if the url for the `WikiLink` property does not start with `https://en.wikipedia.org/wiki/`.
- The `ExpandConservationStatus` method should "expand" the conservation status code, as given at <https://en.wikipedia.org/wiki/Conservation_status#IUCN_Red_List_of_Threatened_Species> and below.
- `MammaryGlands` should not accept any value not listed at <https://en.wikipedia.org/wiki/Mammary_gland#General> under "Total".
- For `Felis` and `Bat`, the `SoundProduced` methods should simply display on the screen "mew, meow, purr, hiss, trill, caterwaul, growl" and "screech, squeak, eek", respectively ([source](https://en.wikipedia.org/wiki/List_of_animal_sounds)).
- For each relevant class, the `ToString` method should display all the attributes and properties.

<!--
Your code should be such that the following:



```
!include code/projects/Species/Species/Program.cs
```

should display (something along the lines of)

```text

```
-->


## Submission

Please, follow our [guideline on project submission](https://princomp.github.io/projects/submission).
In particular, make sure you write your name and the date in a delimited comment at the beginning of your file.

## Bonuses

This project is already challenging *as is*, but bonus will be given if:

<!--

- (easy) Except in the `Species` class, make it so that the `GetContact()` methods cannot be overridden,
- (medium) Your `Main` method exhibits many test cases and illustrates your classes' features nicely,
- (hard) A mechanism is implemented to either export the attributes of an `Species` object into a file or to load it from a file.


Wikipedia accepts any prefix (xx.wikipedia etc.)
-->
