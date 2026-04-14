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

#. Inheritance is …

    - [x] … a way of implementing a class by re-using another class' code.
    - [ ] … impossible to represent in a UML diagram.
    - [ ] … achieved using the `;` (semicolon) symbol.
    - [ ] … a way of connecting a *basic* class with a *derived* class.

    <details><summary>Comment</summary>
    The class inherited from is called the *base*, superclass or parent class, but not *basic*.
    </details>
    
#. Suppose your are given an `ElectricDevice` class and a `WallDecor` class. You would like to write a `Clock` class that represents at the same time an electric device and a wall decor. This is possible only if the `ElectricDevice` and `WallDecor` classes are…

    - [ ] Sealed
    - [x] Interfaces
    - [ ] Protected
    - [ ] Constructors

#. An abstract class…

    - [ ] … can be instantiated.
    - [x] … can contain a constructor.
    - [x] … can contain abstract and non-abstract methods.
    - [x] … is represented in a UML diagram by prefixing its name with \<\<Abstract\>\>.  
    
#. In a UML diagram, an abstract method is …

    - [ ] … underlined.
    - [ ] … impossible to distinguish from a non-abstract method.
    - [x] … necessarily part of an abstract class.
    - [x] … in italics.
    
#. A class `Student` inheriting from an abstract class `Person` …

    - [ ] … must override all of `Person`'s methods.
    - [x] … must implement all the methods marked `abstract` in `Student`.
    - [x] … can be instantiated.
    - [x] … is connected to `Person` using an open triangle end and a continuous line (⇽) on the UML diagram.
    - [ ] … is connected to `Person` using an open triangle end and a dashed line (◁┈) on the UML diagram.        

#. A method with header `public virtual void Test(int a, out int b)` will…

    - [ ] Return a value
    - [x] Set the value of `b`
    - [x] Require two arguments
    - [x] Be overrideable

#. A method with header `public abstract string Test()` will…

    - [ ] Have an empty body
    - [x] Need to be inside an `abstract` class
    - [x] Not be overriden

#. A method …

    - [ ] … can be accessed from any class if it is marked `protected`.
    - [ ] … can be accessed from its derived classes if it is marked `private`.
    - [ ] … is recursive if it terminates.
    - [x] … is recursive if it calls itself.
    - [x] … must be overridden if it is marked `abstract`.
    - [x] … cannot be overriden if it is marked `sealed`.

#. Give at least two differences between an abstract class and an interface.

    <details><summary>Solution</summary>
    A possible list includes:
    
    - An abstract class can contain `private` methods.
    - An abstract class is *inherited* by another class, while an interface is *realized* by another class.
    - An class can inherit from only one abstract class, but it can realize multiple interfaces.
    - Interfaces do not need to explicitly mark their methods and properties as public or abstract, since they are always public and abstract.
    - Abstract methods in an abstract class need to be explicitly overridden by methods in the class inheriting from them, while classes realizing interfaces need not to mark the methods as explicitely overriding methods from the interface.
    </details>

## Problems

#. Assume given the following class implementation:

    ```
    !include code/projects/Computer/Computer/Computer.cs
    ```
    
    Write a `Laptop` class that
    
    #. Inherits from `Computer`,
    #. Has one single (automatic) property, called `ScreenSize`, of type `int`,
    #. Has a constructor that takes 2 parameters of appropriate datatypes, and use them to set `brand` and `ScreenSize`,
    #. Has a `ToString` method that returns a `string` containing the brand and screen size.
    

        <details><summary>Solution</summary>
        ```{download="code/projects/Computer.zip"}
        !include code/projects/Computer/Computer/Laptop.cs
        ```
        </details>

#. Consider the diagram representing the "Room", "ClassRoom", "Office" classes and their relations.

    !include diag/cla/RoomClassroomOffice.md

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

    !include diag/cla/RoomBedBath.md
    
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

      !include diag/cla/Article.md

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

#. Consider the diagram representing the "Shape", "Circle" and "Rectangle" classes, as well as their relations.

      !include diag/cla/Shapes.md

    #. Write the complete implementation of the `Shape` abstract class. The `ToString` method should simply return the string `"This shape is "`.
            
        <details><summary>Solution</summary>
        ```{download="code/projects/Shapes.zip"}
        !include code/projects/Shapes/Shapes/Shape.cs
        ```
        </details> 
            
    #. Write an implementation for the `Radius` property of the `Circle` class such that setting the radius to a negative value would result in an `ArgumentOutOfRangeException` (that you can shorten to `AOORE`) exception being thrown. Add an attribute if needed.
    
        <details><summary>Solution</summary>
        ```{download="code/projects/Shapes.zip"}
        !include`snippetStart="// Radius property",snippetEnd="// Diameter property"` code/projects/Shapes/Shapes/Circle.cs
        ```
        </details> 
        
    #. Write the `Diameter` property for the `Circle` class, which should return $2$ times the radius. Only the `get` should be provided: briefly explain why the `set` is missing.

        <details><summary>Solution</summary>
        ```{download="code/projects/Shapes.zip"}
        !include`snippetStart="// Diameter property",snippetEnd="// Rest of the class"` code/projects/Shapes/Shapes/Circle.cs
        ```
        
        The `set` is missing because `Diameter` must be at all time be equal to `Radius` times 2. There is no point in storing the diamater separately, since this information can be recovered, and since storing it would require to change the value of `Radius` every time it is updated.
        </details> 
        
    #. Write an implementation for the `ToString` method of the `Rectangle` class that returns a `string` containing what was returned by the `Shape`'s `ToString` method, the width, length and area of the calling object. For example, for a `Rectangle` with width 10 and length 5, it should be of the form "This shape is a rectangle (W: 10, L: 5, Area: 50)".

        <details><summary>Solution</summary>
        ```{download="code/projects/Shapes.zip"}
        !include`snippetStart="// ToString method",snippetEnd="// Equals method"` code/projects/Shapes/Shapes/Rectangle.cs
        ```
        </details> 
        
    #. Write the `Equals` method for the `Rectangle` class. It should return `true` if the calling object and the parameter have the same lengths and same widths, or if one can be obtained by rotating the other.

        <details><summary>Solution</summary>
        ```{download="code/projects/Shapes.zip"}
        !include`snippetStart="// Equals method",snippetEnd="// End of Equals method"` code/projects/Shapes/Shapes/Rectangle.cs
        ```
        </details> 
        
    #. Briefly explain how `Shape` could be converted into an interface and what would be the benefit(s) and disadvantage(s) of carrying out such a modification.
        
        <details><summary>Solution</summary>
        A `Shape` interface would be 
        
        - less code,
        - without the need to explicitly list the methods as `public` and `abstract`,
        - not capable of specifying what the beginning of the string returned by the `ToString` method should be, or to give any non-abstract method for that matter.
        
        Another benefit is that the `Rectangle` and `Circle` classes could realize multiple interfaces instead of only inheriting from the `Shape` class.
        
        Its implementation would be:
        
        ```
        interface Shape
        {
            double GetArea();
        }
        ```
        
        Note that our interface *cannot* have a `ToString` method, for a delicate reason that we explain now, but that was not supposed to be part of the answer. You cannot force the implementation of a `ToString` with an interface, as discussed for example [in this stack exchange post](https://stackoverflow.com/q/510341), where an alternative solution is provided (essentially: use an abstract class).

        You can convince yourself that this is the case by downloading and compiling the following two files:

        ```{download="code/projects/IToString.zip"}
        !include code/projects/IToString/IToString/IToString.cs
        ```
        
        ```{download="code/projects/IToString.zip"}
        !include code/projects/IToString/IToString/Demo.cs
        ```

        This code would indeed compile just fine, *even if `Demo` does not provide the implementation of a `ToString` method*.
        Of course, `Demo` already posses a `ToString` method, the one every class inherits.
        </details>
