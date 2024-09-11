---
tags:
  - oop/objects
aliases:
  - OOP - Objects
  - Object-Oriented Programming - Objects
---

## Warm-up Exercises

## Questions

#. In C# each class you create becomes a new type and you can create objects of this type.

  - [x] Yes
  - [ ] No

#. What is "an instance of the class"?

<details>
<summary>Solution</summary>
An instance of a class is an object created using the class as a blueprint. 
</details>

#. Write a statement that creates a new object from the `Rectangle` class.

<details>
<summary>Solution</summary>
`Rectangle myRectangle = new Rectangle();`
</details>

#. Do different objects from the same class share an instance variable?

<details>
<summary>Solution</summary>
No, each object contain instance variables separate from those of other objects.
</details>

#. Suppose we have a `Circle` class containing
```cs
public void SetRadius(double RadiusArgument)
{
	radius = RadiusArgument;
}
```
Write a statement that creates a `Circle` object, and one statement that sets its radius to 3.5.

<details>
<summary>Solution</summary>
Circle circle1 = new Circle();
circle1.SetRadius(3.5);
</details>


## Problems