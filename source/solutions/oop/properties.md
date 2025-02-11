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


## Problems

#. Consider the following implementation of a `Rectangle` class.

  !include code/snippets/rectangle.cs

  #. Write a `Main` method that

      #. Creates an object,
      #. Sets its width to 5,
      #. Sets its length to 10,
      #. Displays its area.

  #. Write an implementation of the `Rectangle` class *using only properties* (included for the `ComputeArea()`).
  #. Write a `Main` method that performs the same tasks as above, but using the properties.

      <details><summary>Solution</summary>
      <!-- If we want to load the code from a file, we can use: -->
      ```
      !include code/projects/RectangleReferences/Rectangle/Rectangle.cs
      ```
      <!-- If we want to give the code directly, we can use: -->
      ```
      using System;

      class Rectangle
      {
        private int length;
        public int Length
        { get; set;}
        // etc
      }
      ```
      </details>
