---
tags:
  - oop/structures
  - datatypes
---

## Problem

Consider the "regular" implementation of the `Rectangle` class:

```
using System;
class Rectangle
{
    private int length;
    public int Length
    {
        get { return length; }
        set { if (value < 0) { throw new ArgumentNullException(); } else length = value; }
    }

    private int width;
    public int Width
    {
        get { return width; }
        set { if (value < 0) { throw new ArgumentNullException(); } else width = value; }
    }

    public Rectangle(int wP, int lP)
    {
        Width = wP;
        Length = lP;
    }

    public override string ToString()
    {
        return $"Width: {Width}\nLength: {Length}";
    }
}
```

And try to answer the following questions.

<details><summary>Solution</summary>
A possible solution to those questions is [available](./code/projects/RectangleReferences.zip). 
</details>


#. Write a `Draw` method that takes one *optional* `char` parameter and draw a rectangle of the calling object's width and length using that character if provided, `*` otherwise.
If your method is correctly implemented, then

    ```
    Rectangle r0 = new Rectangle(3, 2);

    r0.Draw();
    r0.Draw('%');
    ```

    should display
    
    ```text
    ***
    ***

    %%%
    %%%
    ```
    
    <details><summary>Solution</summary>
    A possible solution is:
    ```
    public void Draw(char symb = '*')
    {
        string drawing = "";
        for (int i = 0; i < Length; i++)
        {
            for (int j = 0; j < Width; j++)
            {
                drawing += symb;
            }
            drawing += "\n";
        }
        Console.WriteLine(drawing);
    }
    ```
    </details>
    
#. Write a `Copy` method that does not take arguments, and return *a copy* of the calling object.
If your method is correctly implemented, then

    ```
    Rectangle original = new Rectangle(5, 10);
    Rectangle copy = original.Copy();
    Console.WriteLine("Original:\n" + original + "\nCopy:\n"+ copy + "\n");
    copy.Length = 12;
    Console.WriteLine("\nOriginal:\n" + original + "\nCopy:\n" + copy + "\n");
    ```

    should display

    ```text
    Original:
    Width: 5
    Length: 10
    Copy:
    Width: 5
    Length: 10


    Original:
    Width: 5
    Length: 10
    Copy:
    Width: 5
    Length: 12
    ```
    
    If the length of the original object changed after `copy.Length = 12;` was executed, then your method makes a *shallow* copy instead of a "deep" copy.
    
    <details><summary>Solution</summary>
    A possible solution is:
    ```
    public Rectangle Copy()
    {
        return new Rectangle(Width, Length);
    }
    ```
    </details>
    
#. Write an `Equals` method that return `true` if the calling object and the argument are both non-null rectangles with the same length and width, `false` otherwise.
If your method is correctly implemented, then

    ```
    Rectangle r1 = new Rectangle(5, 10);
    Rectangle r2 = new Rectangle(5, 10);
    Rectangle r3 = null;
    Rectangle r4 = r1;
    Rectangle r5 = new Rectangle(10, 5);

    Console.WriteLine(
        "r1 and r2 identical: " + r1?.Equals(r2)
        + "\nr1 and r3 identical: " + r1?.Equals(r3)
        + "\nr3 and r1 identical: " + r3?.Equals(r1)
        + "\nr3 and r3 identical: " + r3?.Equals(r3)
        + "\nr1 and r4 identical: " + r1?.Equals(r4)
        + "\nr1 and r5 identical: " + r1?.Equals(r5)
        );
      ```
      
      should display
      
      ```text
      r1 and r2 identical: True
      r1 and r3 identical: False
      r3 and r1 identical: 
      r3 and r3 identical: 
      r1 and r4 identical: True
      r1 and r5 identical: False
      ```
      
    <details><summary>Solution</summary>
    A possible solution is:
    ```
    public bool Equals(Rectangle rP)
    {
        if (rP == null) return false;
        return rP.Length == Length && rP.Width == Width;
    }
    ```
    </details>
