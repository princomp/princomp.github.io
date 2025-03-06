---
tags:
  - oop
---

## Warm-up Exercises

## Questions

#. Explain the meaning/purpose of a constructor.
  <details><summary>Solution</summary>
    A constructor is used to instantiate or "construct" an object from the class that contains it.
  </details>

#. Consider a fragment of longer C# code, see below.
```cs
public void SetNumber(int tempNumber)
{ name = tempNumber; } // store the account name
``` 
#. Which of the following statements is false? 
- [ ] the method returns no value
- [ ] name is a local instance variable
- [x] the parameter tempNumber is of string type
- [ ] the method can be used outside of the class it is defined in

#. C# is an object oriented language that has roots in:
- [ ] C
- [ ] C++
- [ ] Java
- [x] All above.

#. Fill in the blanks:
	"A class asserts that every object created using it should have _________ (i.e., 'data') and _________ (i.e., 'operations')."

<details>
<summary>Solution</summary>
attributes, methods
</details>

#. Give two access modifiers.

<details>
<summary>Solution</summary>
private, public, internal
</details>

#. What is the purpose of the keyword `new`?

<details>
<summary>Solution</summary>
The keyword "new" is used for instantiating an object.
</details>

#. What does the keyword `return` do?

<details>
<summary>Solution</summary>
The keyword "return" ends the execution of a method and, if the method has a non-void return type, returns a value of that type.
</details>

#. What does it mean to say that instance variables have a default initial value? How is that different from the variables we have been manipulating in the `Main` method?

<details>
<summary>Solution</summary>
Instance values have a default initial value if they are assigned a value specified within the class definition. Variables in the "Main" method will only default to the value specified by their type.
</details>



## Problems

#. You are going to design a class named `Triangle`. A triangle only has three angles, but knowing the value of only two angles is sufficient to determine the value of the third, since they always add up to 180°. Hence, it is sufficient to have only two **double** attributes, `angle1` and `angle2`. We want to define several methods:
* a no-arg constructor that sets the value of `angle1` to 60.0 and the value of `angle2` to 60.0,
* another constructor that takes two arguments, and assigns to `angle1` the value of the first argument, and to `angle2` the value of the second argument,
* getters for `angle1` and `angle2`,
* a method that computes and returns the value of the third angle, that we name `ComputeAngle3`,
* a method that rotates the triangle: the value of the first angle should become the value of the second angle, and the value of the second angle should become the value of the third angle.

1. Write the UML diagram for the `Triangle` class.
2. Write the full, compilable implementation of the `Triangle` class.

<details>
<summary>Solution for Part 1</summary>
| Triangle |
| --------------------------------------------------- |
| - angle1 : double |
| - angle2 : double |
| ============================= |
| + Triangle() |
| + Triangle(angle1P : double, angle2P : double) |
| + ComputeAngle3() : double |
| + RotateTriangle() : void |
</details>

<details>
<summary>Solution for Part 2</summary>

```cs
class Triangle
{
    private double angle1, angle2;

    public Triangle()
    {
        angle1 = 60.0;
        angle2 = 60.0;
    }

    public Triangle(double angle1P, double angle2P)
    {
        angle1 = angle1P;
        angle2 = angle2P;
    }

    public double GetAngle1()
    {
        return angle1;
    }
    public double GetAngle2()
    {
        return angle2;
    }

    public double ComputeAngle3()
    {
        return 180 - (angle1 + angle2);
    }

    public void RotateTriangle()
    {
        double angle3 = ComputeAngle3();
        angle1 = angle2;
        angle2 = angle3;
    }
    
}
```
</details>