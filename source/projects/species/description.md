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
- The constructors in the `Animal` and `Mammal` classes are *protected*: simply declare them using `protected Animal(string conservationStatusP, double populationP, string wikiLinkP){…}`.

**Pay attention to details**, and note that population is represented with a `double` as it represents _thousands_ of individuals.

In addition, you code should be such that:

- The characters for the `conservationStatus` should be [one of the IUCN Red List of Threatened Species](https://en.wikipedia.org/wiki/Conservation_status#IUCN_Red_List_of_Threatened_Species) code: `EX`, `EW`, `CR`, `EN`, `VU`, `NT`, `CD`, `LC`, `DD`, or `NE`. Your `SetConservationStatus` method should throw an exception if any other value is passed, and your `Animal` constructor should call the `SetConservationStatus` method.
- An exception should be thrown if `Population` is greater than $0$ and `conservationStatus` is set to `EX` (which stands for Extinct). An exception should also be thrown for negative values, except if `conservationStatus` is set to `DD` (data deficient).
- An exception will be raised if the url for the `WikiLink` property does not start with `https://en.wikipedia.org/wiki/`.
- The `ExpandConservationStatus` method should "expand" the conservation status code, as given at <https://en.wikipedia.org/wiki/Conservation_status#IUCN_Red_List_of_Threatened_Species> and below.
- `MammaryGlands` should not accept any value not listed at <https://en.wikipedia.org/wiki/Mammary_gland#General> under "Total".
- For `Felis` and `Bat`, the `SoundProduced` methods should simply display on the screen "mew, meow, purr, hiss, trill, caterwaul, growl" and "screech, squeak, eek", respectively ([source](https://en.wikipedia.org/wiki/List_of_animal_sounds)).
- For each relevant class, the `ToString` method should display all the attributes and properties.

Your code should be such that the following:

```
using System;

class Program
{
  static void Main()
  {
    // Helper string, to display more nicely
    string sep = "\n\n" + new String('*', 20) + "\n\n";

        /*
         * The following are given as indications that
         * both Animal and Mammal should be implemented as
         * abstract classes. Creating an object
         * in those classes should give you errors.
         */

        // Animal test = new Animal("EX", 12, "https://en.wikipedia.org/wiki/test");
        // Should return the error
        // Error CS0144: Cannot create an instance of the abstract type or interface 'Animal' (CS0144) (Species)
        // if uncommented.

        // Mammal AfricanPygmyHedgehog = new Mammal("LC", 1000000, "https://en.wikipedia.org/wiki/Four-toed_hedgehog", 2);
        // Should return the error
        // Error CS0144: Cannot create an instance of the abstract type or interface 'Mammal' (CS0144) (Species)
        // if uncommented.

        /*
         * We now create a couple of objects from proper species.
         * The following should not return exceptions.
         */

        /*
         * We start with objects in the Felis class:
         */
        Felis JungleCat = new Felis("LC", 10, "https://en.wikipedia.org/wiki/Jungle_cat", "uniformly sandy, reddish-brown or grey fur without spots");
        Console.Write(JungleCat + sep);
        // Population is estimated, cf. https://www.aloki.hu/pdf/1804_58735890.pdf for more details.
        Felis HouseCat = new Felis("LC", 6e5, "https://en.wikipedia.org/wiki/Cat", "solid, tabby, pointed, tuxedo, calico, or tortoiseshell");
        Console.Write(HouseCat + sep);
        Felis PallasCat = new Felis("LC", 58, "https://en.wikipedia.org/wiki/Pallas%27s_cat", "light grey with black zigzags and stripes");
        Console.Write(PallasCat + sep);
        /*
         * We now have Bat objects:
         */
        Bat AnjouanMyotis = new Bat("DD", -1, "https://en.wikipedia.org/wiki/Anjouan_myotis", 2, 0);
        Console.Write(AnjouanMyotis + sep);
        Bat BlackEaredFlyingFox = new Bat("VU", .4, "https://en.wikipedia.org/wiki/Black-eared_flying_fox", 2, 22); //Flight speed given in mph
        Console.Write(BlackEaredFlyingFox + sep);
        Bat DesmodusDraculae = new Bat("EX", 0, "https://en.wikipedia.org/wiki/Desmodus_draculae", 2, 0);
        Console.Write(DesmodusDraculae + sep);


        /*
        * Finally, one Reptile object:
        */
        Reptile BallPython = new Reptile("NT", .1, "https://en.wikipedia.org/wiki/Ball_python", false);
        Console.Write(BallPython + sep);
        /*
         * We now test our improper values handling.
         */
        try
        {
            Felis test1 = new Felis("INVALID CODE", 1, null, null);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        try
        {
            Felis test2 = new Felis("EX", 10, "https://en.wikipedia.org/wiki/whatever", null);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        try
        {

            Felis test3 = new Felis("EX", 0, "http://sketchy-website.com/", null);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        try
        {

            Bat test4 = new Bat("LC", -10, null, 0, 12);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        try
        {
            Bat test5 = new Bat("LC", 10, "https://en.wikipedia.org/wiki/whatever", 3, 0);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

```

should display (something along the lines of)

```text
| Population           | 10 000
| Conservation Status  | LC
| Wikipedia Link       | https://en.wikipedia.org/wiki/Jungle_cat
| Mammary Glands       | 8
| Fur pattern          | uniformly sandy, reddish-brown or grey fur without spots
| Sound(s) produced    | mew, meow, purr, hiss, trill, caterwaul, growl


********************

| Population           | 600 000 000
| Conservation Status  | LC
| Wikipedia Link       | https://en.wikipedia.org/wiki/Cat
| Mammary Glands       | 8
| Fur pattern          | solid, tabby, pointed, tuxedo, calico, or tortoiseshell
| Sound(s) produced    | mew, meow, purr, hiss, trill, caterwaul, growl


********************

| Population           | 58 000
| Conservation Status  | LC
| Wikipedia Link       | https://en.wikipedia.org/wiki/Pallas%27s_cat
| Mammary Glands       | 8
| Fur pattern          | light grey with black zigzags and stripes
| Sound(s) produced    | mew, meow, purr, hiss, trill, caterwaul, growl


********************

| Population           | -1 000
| Conservation Status  | DD
| Wikipedia Link       | https://en.wikipedia.org/wiki/Anjouan_myotis
| Mammary Glands       | 2
| Flight speed         | 0
| Sound(s) produced    | screech, squeak, eek


********************

| Population           | 400
| Conservation Status  | VU
| Wikipedia Link       | https://en.wikipedia.org/wiki/Black-eared_flying_fox
| Mammary Glands       | 2
| Flight speed         | 22
| Sound(s) produced    | screech, squeak, eek


********************

| Population           | 0
| Conservation Status  | EX
| Wikipedia Link       | https://en.wikipedia.org/wiki/Desmodus_draculae
| Mammary Glands       | 2
| Flight speed         | 0
| Sound(s) produced    | screech, squeak, eek


********************

| Population           | 100
| Conservation Status  | NT
| Wikipedia Link       | https://en.wikipedia.org/wiki/Ball_python
| Ossified Scales      | False


********************

A conservation status is 2 characters long.
Population cannot be non-zero if conservation status is not EX.
Submission link (http://sketchy-website.com/) does not start with "https://en.wikipedia.org/wiki/".
Population cannot be negative unless conservation status is DD.
Number of mammary glands cannot be odd, unless it is 13, 25 or 27.
```

## Submission

Please, follow our [guideline on project submission](https://princomp.github.io/projects/submission).
In particular, make sure you write your name and the date in a delimited comment at the beginning of your file.

<!--

## Bonuses

This project is already challenging *as is*, but bonus will be given if: (to be written)


- (easy) Except in the `Species` class, make it so that the `GetContact()` methods cannot be overridden,
- (medium) Your `Main` method exhibits many test cases and illustrates your classes' features nicely,
- (hard) A mechanism is implemented to either export the attributes of an `Species` object into a file or to load it from a file.


Wikipedia accepts any prefix (xx.wikipedia etc.)
-->
