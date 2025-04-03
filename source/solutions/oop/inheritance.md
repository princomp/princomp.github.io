---
tags:
- oop/uml
- oop/objects
---

# Inheritance (Solutions)

## Questions

#. What is the keyword used to call the constructor from the base class?

    - [ ] `this`.
    - [ ] the name of the base class.
    - [x] `base`
    - [ ] `over`
    - [ ] `inherits`

#. Suppose your are given an `ElectricDevice` class and a `WallDecor` class. You would like to write a `Clock` class that represents at the same time an electric device and a wall decor. This is possible only if the `ElectricDevice` and `WallDecor` classes are…

    - [ ] Sealed
    - [x] Interfaces
    - [ ] Protected
    - [ ] Constructors

#. A method with header `public virtual void Test(int a, out int b)` will…

    - [ ] Return a value
    - [x] Set the value of `b`
    - [x] Require two arguments
    - [x] Be overrideable

#. A method with header `public abstract string Test()` will…

    - [ ] Have an empty body
    - [x] Need to be inside an `abstract` class
    - [x] Not be overriden

## Problems

#. Consider the diagram representing the "Room", "ClassRoom", "Office" classes and their relations.

  !include uml/cla/RoomClassroomOffice.md

  Suppose you are given an implementation of the `Room` class, such that 

  ```
  !include`snippetStart="// Question 1",snippetEnd="// Refer to Classroom.cs for a solution"` code/projects/RoomClassroomOffice/RoomClassroomOffice/Program.cs
  ```

  displays

  ```text
  UH 243
  ```

  #. Write an implementation of the `ClassRoom` class. Your `ToString` method should display the room's building and number, in addition to whether it has AV set-up.

      <details><summary>Solution</summary>
      ```
      !include code/projects/RoomClassroomOffice/RoomClassroomOffice/Classroom.cs
      ```
      </details>

  #. Write a `SameBuilding` static method to be placed inside the `Room` class such that

      ```
      !include`snippetStart="// Question 2",snippetEnd="// Refer to Room.cs for a solution.",dedent=4` code/projects/RoomClassroomOffice/RoomClassroomOffice/Program.cs
      ```
      Would display "true" and "false".
      
      <details><summary>Solution</summary>
      ```
      !include`snippetStart="// (not on UML diagram)",snippetEnd="// Note that since we are inside the class,"` code/projects/RoomClassroomOffice/RoomClassroomOffice/Room.cs
      ```
      </details>


#. Consider the diagram representing the "Room", "BedRoom", "BathRoom" classes and their relations.

    !include uml/cla/RoomBedBath.md
    
    #. Write an implementation of the `SurfaceArea` property for the `Room` class, assuming you are given an implementation of the `Width` and `Length` properties.
    
        <details><summary>Solution</summary>
        ```{download="code/projects/RoomBedBath.zip"}
        !include`snippetStart="// SurfaceArea property",snippetEnd="// Constructor"` code/projects/RoomBedBath/RoomBedBath/Room.cs
        ```
        </details>
    
    #. Check the statements that would compile, assuming that `rTest` is a `Room` object, `beTest` is a `BedRoom` object, and `baTest` is a `BathRoom` object.
        
        - [ ] `rTest.Capacity = 12;`
        - [x] `baTest.Width = 12;`
        - [ ] `beTest.capacity = 3;`
        - [ ] `rTest.SurfaceArea = -2;`
        - [ ] `baTest.Capacity = 3;`
        - [ ] `beTest.Shower = true;`
        - [x] `Console.WriteLine(baTest.ToString());`
        
    #. Write a complete implementation of the `BedRoom` class.
    
        - Your `Capacity` property should use the `capacity` attribute, and throw an exception if the argument given is strictly less than 1.
        - Your `ToString` method should complement the `Room`'s `ToString` by appending to its `string` the capacity (in person) of the `BedRoom` object.
        
        <details><summary>Solution</summary>
        ```{download="code/projects/RoomBedBath.zip"}
        !include code/projects/RoomBedBath/RoomBedBath/BedRoom.cs
        ```
        </details>

    #. Write the `ToString` method of the `BathRoom` class, knowing that a disclaimer should be part of the `string` returned if the `BathRoom` has a shower or a bathtub but no hot water.
  
        <details><summary>Solution</summary>
        ```{download="code/projects/RoomBedBath.zip"}
        !include`snippetStart="// ToString method",snippetEnd="// End of ToString method"` code/projects/RoomBedBath/RoomBedBath/BathRoom.cs
        ```
        </details>
        

#. Consider the diagram representing the "Article", "Book" classes and their relations.

      !include uml/cla/Article.md

    #. Write a (partial) implementation of the `Article` abstract class:

        #. Write an implementation for the `price` attribute: you can either use a getter and a setter (as pictured in the UML diagram), or a property. However, in both cases, setting the price to a negative value should result in an `ArgumentOutOfRangeException` exception being thrown.
        #. Write an *abstract* `ShippingCosts()` method.

        <details><summary>Solution</summary>
        ```
        !include code/projects/Article/Article/Article.cs
        ```
        </details>

        
    #. Now, assume given a complete implementation of the `Article` abstract class. Write a **complete** implementation of the `Book` class (header included), containing:
        #. An implementation of the `Title` property using auto-properties.
        #. A `Book` constructor that passes the `idP` and `priceP` arguments to the `Article` constructor. The `titleP` argument should be assigned to the `Title` property.
        #. A `ShippingCosts()` method that returns either 5.0, or 10% of the Book's price, whichever is smallest.
    
        <details><summary>Solution</summary>
        ```
        !include code/projects/Article/Article/Book.cs
        ```
        </details>
    
    #. Write statements that, if placed in a `Main` method, would
        #. Create a `Book` with `Id` "AAA001", `price` $12.5, titled "What it's like to be a bird".
        #. Display (nicely) its shipping costs.
        #. Display its `Id` (as retrieved from the object).

        <details><summary>Solution</summary>
        ```{download="code/projects/Article.zip"}
        !include code/projects/Article/Article/Program.cs
        ```
        </details>

