---
tags:
- oop/uml
- oop/objects
---

# Properties (Solutions)

## Questions

#. What is the right syntax for an automatic property? *Select all that apply.*

    - [x] `public int Width { get; set; }`
    - [x] `public int Width { set; get; }`
    - [ ] `public int Width { Set; Get; }`
    - [ ] `public int Width { Get; Set; }`
    - [ ] `public int Width { set(); get();}`
    - [ ] `public int Width { get(); set();}`

#. Which of the following statements is *false*?

    - [ ] Properties can be static.
    - [x] `get` and `set` accessors must always have bodies.
    - [ ] Properties have headers.
    - [ ] `get` and `set` accessors correspond to "getter" and "setter" methods for attributes.

#. Consider the following implementation of a class called `Pet`:

    ```
    class Pet{
        private string name;
        public string Name{
            get;
            set { name = value; }
        }
    }
    ```
    This code will give a compilation error. Why?

    - [x] The `set` accessor has a body, but the `get` accessor does not.
    - [ ] The instance variable for `name` is declared, but no value is assigned.
    - [ ] `value` is not a keyword and hasn't been declared, so it is meaningless here.
    - [ ] The access modifier for `name` is `private`, but it should be `public`.


### Circle Example

For the following questions, imagine you've implemented a `Circle` class, with the attribute `private decimal diameter;` and a "getter" and "setter" method for that attribute. You've created an object in this `Circle` class called `myCircle`. If you were to implement the class with properties instead:

#. What would calling the `get` accessor do?

    - [x] Return the value of `diameter`
    - [ ] Assign a value to `diameter`

#. What would calling the `set` accessor do?

    - [ ] Return the value of `diameter`
    - [x] Assign a value to `diameter`

#. The statement `myCircle.GetDiameter();` would have to be rewritten. How would you rewrite it?

    - [x] `myCircle.Diameter;`
    - [ ] `myCircle.diameter;`
    - [ ] `Diameter.myCircle;`
    - [ ] `myCircle = Diameter;`

#. The statement `myCircle.SetDiameter(5.0m);` would also need to be rewritten. How would you rewrite it?

    - [ ] `myCircle.diameter = 5.0m;`
    - [ ] `Diameter.myCircle(5.0m);`
    - [x] `myCircle.Diameter = 5.0m;`
    - [ ] `myCircle.diameter(5.0m);`

You would now like to add a `Color` property of type `string` to your `Circle` class.

#. How would you declare the instance variable?

    - [ ] `public color string;`
    - [ ] `public string Color;`
    - [ ] `private string Color;`
    - [x] `private string color;`

#. How would you format the property header?

    - [ ] `public string color;`
    - [x] `public string Color;`
    - [ ] `private Color string;`
    - [ ] `private string color;`

#. What would the `get` accessor's body look like, in its most basic possible form?

    - [ ] `color;`
    - [ ] `color = value;`
    - [x] `return color;`
    - [ ] `string color;`

#. What would the `set` accessor's body look like, in its most basic possible form?

    - [ ] `color;`
    - [x] `color = value;`
    - [ ] `return color;`
    - [ ] `string color;`

#. In the `Main` method, you would like to assign the value `"yellow"` to `color`. Which statement would do that?

    - [ ] `yellow.myCircle;`
    - [x] `myCircle.Color = "yellow";`
    - [ ] `myCircle.yellow = Color;`
    - [ ] `myCircle = "yellow";`

### Plant Example

For the next  questions, consider the following implementation of a class called `Plant`:

```
class Plant{
    private string species;
    public string Species
        {get;} = "Helianthus annus";
    private static bool hasChloroplasts;
    public static bool HasChloroplasts
        {get;} = true;
}
```

#. Will this code compile? Why or why not?

    - [ ] No, because there are no `set` accessors, and properties must have one.
    - [ ] No, because a property cannot be assigned a default value.
    - [ ] No, because a `get` accessor must always have a body.
    - [x] Yes, because properties are *not* required to have `set` accessors.
    - [ ] Yes, because a default value must be assigned for each property.

Suppose you've created an object in the `Plant` class called `myPlant`.

#. In the Main method, what would the statement

    ```Console.Write(myPlant.Species);```

    do?

    - [x] Display the current value of `species`, `"Helianthus annus"`.
    - [ ] Rename the `myPlant` object to `Species`.
    - [ ] It won't do anything--the code for the class doesn't compile.
    - [ ] It won't do anything--the property is write-only.

#. The `HasChloroplasts` property is `static`. What does this mean? *Select all that apply.*

    - [ ] Every object in the `Plant` class has its own `HasChloroplasts` property.
    - [x] The property is shared across the class and all of its instances.
    - [x] The property can be accessed without creating a `Plant` object.
    - [ ] The property's value cannot be changed from the default.

#. The statement `myPlant.Species = "Coffea arabica";` would not compile. Why not?

    - [ ] The syntax is wrong.
    - [ ] Only a `static` property's default value can be changed.
    - [ ] The code for the class doesn't compile.
    - [x] The property only has a `get` accessor, so it is read-only.

#. What modification to the `Plant` class would allow the statement `myPlant.Species = "Coffea arabica";` to compile?

    - [ ] Remove the default value, `"Helianthus annus"`.
    - [x] Add `set;` to the `Species` property.
    - [ ] Add `set;` to the `HasChloroplasts` property.
    - [ ] Make the entire class `static`.
    - [ ] Change the access modifier for `species` from `private` to `public`

## Problems

#. Consider the following implementation of a `Rectangle` class:
  
    ```
    !include code/snippets/rectangle.cs
    ```
  
    #. Write a `Main` method that

        #. Creates a `Rectangle` object,
        #. Sets its width to 5,
        #. Sets its length to 10,
        #. Displays its area.
        <details><summary>Solution</summary>```
        using System;
        class Program
        {
            public static void Main()
            {
                Rectangle test = new Rectangle(); // 1
                test.SetWidth(5); // 2
                test.SetLength(10); // 3
                Console.WriteLine(test.ComputeArea()); // 4
            }
        }
        ```
        </details>

    #. Write an implementation of the `Rectangle` class *using only properties* (included for the `ComputeArea()`).
    <details><summary>Solution</summary>```
    class Rectangle{
      public int Length{get; set;}
      public int Width{get; set;}
      public int Area{get{return Length * Width;}}
    }
    ```
    </details>
    #. Write a `Main` method that performs the same tasks as above, but using the properties you just defined.
    <details><summary>Solution</summary>```
    using System;
    class Program
    {
        public static void Main()
        {
            Rectangle test = new Rectangle(); // 1
            test.Width = 5; // 2
            test.Length = 10; // 3
            Console.WriteLine(test.Area); // 4
        }
    }
    ```
    </details>
    

#. Implement a `SDCard` class to represent SD cards. Add attributes to your answer if needed.

    #. Implement a `Nickname` `string` property using automatic properties.
    <details><summary>Solution</summary>```
    public string Nickname {get; set;}
    ```
    </details>
    #. Implement a `Capacity` `int` property whose setter raises an `ArgumentException` exception if the value passed as argument is not 8, 16, 32, 64 or 128.  The getter should simply return the value stored.
    <details><summary>Solution</summary>```
    private int capacity;
    public int Capacity {
        set {
            if (value == 8 || value == 16 || value == 32 || value == 64 || value == 128)
                capacity = value;
            else
                throw new ArgumentException();
         }
         get { return capacity; }
    }
    ```
    </details>
    #. Implement a `CapacityInGb` `int` property with only a getter, that returns the `Capacity` times 8.
    <details><summary>Solution</summary>```
    public int CapacityInGb {
        get {return capacity * 8;}
    }
    ```
    </details>
    #. Implement a `ToString` method that returns a `string` containing the nickname of the SD card, its capacity in gigabytes (GB, from question 2.), and its capacity in gigabits (Gb, from question 3.).    
    <details><summary>Solution</summary>```
    public override string ToString(){
        return "Name: " + Nickname + "\nCapacity: " + Capacity + "GB" + "\nCapacity in Gb: " + CapacityInGb + "Gb";
    }
    ```
    </details>


    <details><summary>Solution</summary>
    A complete solution gives:

    ```{download="code/projects/SDCard.zip"}
    !include code/projects/SDCard/SDCard/SDCard.cs
    ```

    And a possible test program is:

    ```{download="code/projects/SDCard.zip"}
    !include code/projects/SDCard/SDCard/Program.cs
    ```
    </details>

#. In this problem, we will implement a `Weather` class recording a location and a temperature (in Fahrenheit). Add attributes to your answers if needed.

    #. Implement a `Location` `string` property using automatic properties. Its default value should be "Unknown".
    <details><summary>Solution</summary>```
    public string Location { get; set; } = "Unknown";
    ```
    </details>
    #. Implement a `Temperature` `double` property. If the value passed as an argument to the setter is less than -128.6 or greater than 134.1, then the setter should raise an `ArgumentOutOfRangeException` exception.
    The getter simply returns the value stored.
    <details><summary>Solution</summary>```
    public double Temp
    {
        set
        {
            if (value < -128.6 || value > 134.1) throw new ArgumentOutOfRangeException();
            else { temp = value; }
        }
        get { return temp; }
    }
    ```
    </details>
    #. Implement a `TempInC` `double` property with only a getter that returns the temperature in Celsius, using the following formula: $°C = (°F - 32) ÷ (9/5)$.
    <details><summary>Solution</summary>```
    public double TempInC
    {
        get
        {
            return (Temp - 32) / (9 / 5);
        }
    }
    ```
    </details>
    #. Implement a `ToString` method that returns a `string` containing the location and the temperature both in Celsius and Fahrenheit.
    <details><summary>Solution</summary>```
    public override string ToString()
    {
        return Location + ": " + Temp + "°F (" + TempInC + "°C)";
    }
    ```
    </details>
