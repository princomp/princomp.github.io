---
tags:
- oop/uml
- oop/objects
---

# Properties (Solutions)

## Questions

#. What is the right syntax for an automatic property?

  - [x] `public int Width { get; set; }`
  - [x] `public int Width { set; get; }`
  - [ ] `public int Width { Set; Get; }`
  - [ ] `public int Width { Get; Set; }`
  - [ ] `public int Width { set(); get();}`
  - [ ] `public int Width { get(); set();}`


## Problem

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

