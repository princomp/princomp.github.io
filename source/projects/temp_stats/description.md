---
tags:
- datatypes/collections
- oop/objects
- debugging/exceptions
---

# Description

## Purpose

This project is designed to teach you how to manipulate exceptions, properties, and arrays.
It reinforces your understanding of class design and implementation while introducing the handling of exceptions.

## Challenge

### In short

Develop a class that helps gather data about temperature statistics. Your class will allow to compute the mean, median and (optionally) mode of arrays of temperatures (in Fahrenheit), and raise exceptions if the data is incorrectly entered.

### In more details

#. Your goal is to design and implement a `TempStats` class containing two attributes and several methods (some of which may and should be implemented using properties).
#. You *must* develop a `Program` class with a `Main` method to test your `TempStats` class, but **note that this `Program` class will not be part of your grade**.
#. An object in your `TempStats` must hold two attributes: a (`string`) description, and an array of temperatures (in Fahrenheit). The description *must* be implemented using automatic properties.
#. The array of temperatures *must be* sorted: if at any point during creation or later modification the array were to become not sorted, your class should throw an exception.
#. The temperatures in the array *must be* between -128.6 and 134.1 (the [lowest](https://en.wikipedia.org/wiki/Lowest_temperature_recorded_on_Earth) and [highest](https://en.wikipedia.org/wiki/Highest_temperature_recorded_on_Earth) temperatures ever recorded on Earth): if at any point during creation or later modification of the array the temperatures were to exceed that range, your class should throw an exception.
#. Finally, your class should have two methods, one to compute the mean of the values in the array, and one to compute the median. Both methods can be implemented as properties.


## Submission

Please, follow our [guideline on project submission](https://princomp.github.io/projects/submission).
In particular, make sure you write your name and the date in a delimited comment at the beginning of your file.

## Example

Here is an example of a `Program.cs` `Main` method:

```
double[] data = { 12.8, 39, 47, 91.7 };
TempStats test = new TempStats(data, "Temperatures recorded in Augusta, GA");
test.Description += " between 2024/02 and 2024/03";
Console.WriteLine("Description: " + test.Description);
Console.WriteLine("Median: " + test.Median);
Console.WriteLine("Average: " + test.Average);

try
{
    double[] hottest = { 1000000 };
    TempStats tooHot = new TempStats(hottest, "Too hot");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    double[] coldest = { -1000000 };
    TempStats tooCold = new TempStats(coldest, "Too cold");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    double[] improper = { 10, -5, 100 }; // This data is not sorted.
    TempStats notSorted = new TempStats(improper, "Not Sorted");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
```

Executing it with a properly implemented `TempStats` class should give something along the lines of:

```text
Description: Temperatures recorded in Augusta, GA between 2024/02 and 2024/03
Median: 43
Average: 47.625
Specified argument was out of the range of valid values.
Parameter name: That is hotter than the hottest ever recorded on Earth!
Specified argument was out of the range of valid values.
Parameter name: That is colder than the coldest ever recorded on Earth!
Your data is not sorted.

Press any key to continue...
```

## Bonuses

- Implement a method to display the values and the description nicely.
- Implement a method to display the values *converted to Celcius* nicely.
- Accept arrays sorted in increasing *or* decreasing order. That is, the array `3.5, -10, -15` should be accepted.
- Implement a method (or property) to compute [the mode](https://en.wikipedia.org/wiki/Mode_(statistics)) of the temperatures. Note that the mode is not always unique: in that case, an exception should be raised.
