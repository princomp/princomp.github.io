---
tags:
  - datatypes/collections
---

# One-Dimensional Arrays

## Multiple Choices

#. What is the correct way of creating an array of `int` of size 5 named `myArray`?

    - [x] `int[] myArray = new int[5];`
    - [ ] `int[] myArray = int[5];`
    - [ ] `int[5] myArray = new int[];`
    - [ ] `int[4] myArray = new int[];`
    - [ ] `int myArray = new int[5];`
    - [ ] `int[] myArray = new int[4];`
    - [ ] `int[] myArray = new int(5);`
    - [ ] `int[] myArray = int[4];`
    
#. Consider the following code:

    ```
    int[] grades = {10, 20, 5, 15};
    Console.WriteLine(grades[2]);
    ```

    What will it display?
    
    - [x] 5
    - [ ] Nothing
    - [ ] 20
    - [ ] 15
    - [ ] grades
    - [ ] grades[2]
    - [ ] 10

#. Consider the following code:

    ```
    char[] grades = {'A', 'B', 'C', 'D', 'F'};
    int i = 0;
    while(i < grades.Length){
        i++;
        Console.WriteLine(grades[i]);
    }
    ```

    Something is wrong with it, can you tell what?
    
    - [x] There will be an "Index was outside the bounds of the array." error.
    - [ ] The array is not properly initialized.
    - [ ] The loop is infinite
    - [ ] `grades.Length` is not declared.
    

## Warm-up Exercises

### Syntax

#. Write a statement that creates a 10-element **int** array named `numbers`.

    <details>
    <summary>Solution</summary>

    ```cs
    int[] numbers = new int[10];
    ```
    </details>

#. Write a statement that creates and initializes a double array with the values 12.5, 89.0 and 3.24.

    <details>
    <summary>Solution</summary>

    ```cs
    double[] question = {12.5, 89.0, 3.24};
    ```
    </details>

#. In the following, what is the value of the size declarator? What is the value of the index?

    ```cs
    int[] numbers;
    numbers = new int[8];
    numbers[4] = 9;
    ```

    <details>
    <summary>Solution</summary>
    The size declarator is 8, the subscript, or index, is 4.
    </details>

#. What is "array bounds checking"? When does it happen?

    <details>
    <summary>Solution</summary>
    It is when C# makes sure that you're not using a subscript outside the allowed range. It happens at run time.
    </details>

#. Is there an error with the following code? If you think there is one, explain it, otherwise draw the content of the myIncomes array once those statements have been executed.

    ```cs
    double[] myIncomes = new double[5];
    myIncomes[1] = 3.5;
    // No income on day two.
    myIncomes[3] = 5.8;
    myIncomes[4] = 0.5;
    myIncomes[5] = 1.5;
    ```

    <details>
    <summary>Solution</summary>
    The subscripts are off. They should go from 0 to 4.
    </details>

#. What would be the size of the test array after the following statement has been executed?

    `int[] test = {3, 5, 7, 0, 9};`

    <details>
    <summary>Solution</summary>
    5
    </details>

#. What is wrong with the following array declaration?

    ```cs
    int[] books = new int[-1];
    ```
    <details>
    <summary>Solution</summary>
    The size declarator cannot be negative.
    </details>

#. Suppose we have an array named `temp` that has been declared and initialized. How can we know the number of elements in this array?

    <details>
    <summary>Solution</summary>
    By using the `Length` field: `temp.Length`
    </details>

#. What is the value of `count` and the content of `number` once the following has been executed?

    ```cs
    int count=2;
    int[] number={3, 5, 7};
    number[count--] = 8;
    number[count]--;
    ```

    <details>
    <summary>Solution</summary>
    `count` is 1. `numbers` is 3, 4, 8.
    </details>


#. Describe what the following code would do.

    ```cs
    int[] record = { 3, 8, 11 };
    int accumulator = 0;
    foreach (int i in record)
    accumulator += i;
    ```

    <details>
    <summary>Solution</summary>
    Declare and initialize an int array with the values 3, 8, and 11, and then sum those values in an accumulator variable.
    </details>

### Displaying Arrays

#. Write code that displays the first and last element of an array.

    <details>
    <summary>Solution</summary>

    ```cs
    int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

    Console.WriteLine($"First element: {numbers[0]}");
    Console.WriteLine($"Last element: {numbers[numbers.Length - 1]}");
    ```
    </details>

#. What will be displayed at the screen by the following code?

    ```cs
    int[] values = new int[6];
    for (int i = 0 ; i < 6 ; i++)
        values[i] = (i * 2 );
        
    foreach (int j in values)
        Console.WriteLine(j);
    ```

    <details>
    <summary>Solution</summary>
    0
    2
    4
    6
    8
    10
    </details>

#. Suppose we are given an **int** array `dailyPushUp` with 7 elements. Write a piece of code that displays the value of the elements stored in the array `dailyPushUp`.

    <details>
    <summary>Solution</summary>

    ```cs
    for (int j = 0; j < 7; j++)
        Console.WriteLine(dailyPushUp[j]);
    ```
    </details>

#. Write code that displays every element in a `numbers` array of integers.

    <details>
    <summary>Solution</summary>

    ```cs
    for ( int i = 0; i < numbers.Length; i++ )
    {
        Console.WriteLine(numbers[i]);
    }
    ```
    </details>

#. Write code that displays every element in a `numbers` array of integers in reverse order.

    <details>
    <summary>Solution</summary>

    ```cs
    for ( int i = (numbers.Length - 1) ; i >= 0 ; i-- )
    {
        Console.WriteLine(numbers[i]);
    }
    ```
    </details>

#. Write code that displays every other element in a `numbers` array of integers (that is, every even index).

    <details>
    <summary>Solution</summary>

    ```cs
    for (int i = 0; i < numbers.Length; i += 2)
    {
        Console.WriteLine(numbers[i]);
    }
    ```
    </details>

#. Given an array `numbers` and a variable `x`, write code that displays every value in `myArray` that is equal to or greater than `x`.

    <details>
    <summary>Solution</summary>

    ```cs
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] >= x)
        {
            Console.WriteLine(numbers[i]);
        }
    }
    ```
    </details>

### Filling Arrays

#. Given some positive number `n`, write code that first declares an array of length `n`, then sets its contents to sequentially increasing values 1, 2, 3, ..., n.

    <details>
    <summary>Solution</summary>

    ```cs
    int[] nums = new int[n];

    for ( int i = 0 ; i < n ; i++ )
    {
        nums[i] = i + 1;
    }
    ```
    </details>   
    
#. Given an array `myArray` and some value `x`, write code that sets the value of every array element to `x`.

    <details>
    <summary>Solution</summary>

    ```cs
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = x;
    }
    ```
    </details>

#. Write code that displays every unique value of a sorted array. This array could be, for example, 1 1 1 4 4 5 8 9 11 such that values are increasing but value can occur multiple times.

    <details>
    <summary>Solution</summary>

    ```cs
    int[] numbers = {1, 1, 1, 4, 4, 5, 8, 9, 11};

    for (int i = 0 ;  i < numbers.Length ; i++)
    {
        if (i > 0 && numbers[i] != numbers[i - 1])
        {
            Console.WriteLine(numbers[i]);
        }
    }
    ```
    </details>

## Warm-up Exercises -- Calculating With Arrays
    
#. Write a program that computes the sum of values stored in a `numbers` array of integers

    <details>
    <summary>Solution</summary>

    ```cs
    int sum = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }
    
    Console.WriteLine($"The sum is {sum}.");
    ```
    </details>

#. Given an array of integers, and two integer variables `oldValue` and `newValue`; write code that replaces every occurrence of `oldValue` in the array with `newValue`.

    <details>
    <summary>Solution</summary>

    ```cs
    for (int i = 0; i < myArray.Length; i++ )
    {
        if (myArray[i] == oldValue)
        {
            myArray[i] = newValue;
        }
    }
    ```
    </details>

#. Write code that squares every value in an `myArray` integer array. For example, an array containing 2, 3, 4 would after the program contain 4, 9, 16.

    <details>
    <summary>Solution</summary>

    ```cs
    for ( int i = 0; i < myArray.Length; i++ )
    {
        myArray[i] *= myArray[i];
    }
    ```
    </details>
    

## Warm-Up Exercise -- Looking For Values

#. Given an array `myArray` and a value `val`, write code that checks if `myArray` contains `val`. The result should be `true` if `val` occur in `myArray` and `false` otherwise.

    <details>
    <summary>Solution</summary>

    ```cs
    bool valOccurs = false;

    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] == val)
        {
            valOccurs = true;
        }
    }
    ```
    </details>
    
#. Given an array `myArray` and two values `x` and `y`, write code that checks if `myArray` contains *either* `x` or `y`. The result should be `true` if `x` or `y` occur in `myArray` and `false` otherwise.

    <details>
    <summary>Solution</summary>

    ```cs
    bool eitherOccurs = false;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == val1 || array[i] == val2)
        {
            eitherOccurs = true;
        }
    }
    ```
    </details>

#. Given an array `myArray` and two values `x` and `y`, write code that checks if `myArray` contains *both* values `x` and `y`. The result should be `true` when both values occur and `false` otherwise.

    <details>
    <summary>Solution</summary>

    ```cs
    bool xOccurs = false, yOccurs = false, bothOccur = false;

    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] == x)
        {
            xOccurs = true;
        }

        if (myArray[i] == y)
        { 
            yOccurs = true;
        }
    }
    
    if (xOccurs && yOccurs)
    {
        bothOccur = true;
    }
    ```
    </details>

#. Given an integer `myArray` and a strictly positive integer value `x`, find an array element whose value is largest while also being strictly less than `x` and display it, or display 0 if there is no such value.
For example, in an array containing 1, 2, 6, 7, 3, 9 with x being 8, the solution is 7.

    <details>
    <summary>Solution</summary>

    ```cs
    int largest = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] < x && myArray[i] > largest)
        {
            largest = myArray[i];
        }
    }

    Console.WriteLine(largest);
    ```
    </details>

#. Consider an array of `char`. Implement code to check if the array values form a palindrome, i.e., it reads the same way forwards and backwards.

    <details>
    <summary>Solution</summary>

    ```cs
    bool palindromeSoFar = true;
    int n = myArray.Length;
    for (int i = 0; i < (n / 2); i++)
    {
        if (myArray[i] != myArray[(n - 1) - i]) // The two sides of the word are not equal to each other.
        {
            palindromeSoFar = false;
        }
    } // Both sides of the word have been checked and are mirrors of each other.
    ```
    </details>

   
## Warm-up Exercises -- Manipulating Two Arrays

#. Given two arrays `array1` and `array2`, write a program to determine if there exists a value that occurs in both arrays. If such value exists, the result should be `true` and `false` otherwise.

    <details>
    <summary>Solution</summary>

    ```cs
    bool valueInCommon = false;

    for (int i = 0; i < array1.Length; i++)
    {
        for (int j = 0; j < array2.Length; j++)
        {
            if (array1[i] == array2[j])
            {
                valueInCommon = true;
            }
        }
    }
    ```
    </details>

#. Given two arrays `arrayA` and `arrayB`, write code to check if every element in `arrayB` occurs in `arrayA`, then display the result as `true` or `false`.

    <details>
    <summary>Solution</summary>
    Using `while` loops:
    
    ```cs
    int i = 0;
    int j;
    bool containsB = true;
    bool containCurrentVal = false;
    while(i < arrayB.Length && containsB)
    {
        j = 0;
        containCurrentVal = false;
        while (j < arrayA.Length && !containCurrentVal)
        {
            if(arrayA[j] == arrayB[i])
            {
                containCurrentVal = true;
            }
            j++;
        }
        if (!containCurrentVal)
        {
            Console.WriteLine(arrayB[i] + " does not occur.");
            containsB = false;
        }
        else
        {
            containCurrentVal = false;
        }
        i++;
    }
    ```
       
    Using `break`:

    ```cs
    bool containsB = false;

    for (int i = 0; i < arrayB.Length; i++)
    {
        containsB = false;

        for (int j = 0; j < arrayA.Length; j++)
        {
            if (arrayA[j] == arrayB[i])
            {
                containsB = true;
                break;
            }
        }

        if (!containsB)
        {
            break;
        }
    }

    Console.WriteLine(containsB);
    ```
    </details>




## Questions (harder)


#. Given an array of positive integers, count how many even values occur in that array.

    <details>
    <summary>Solution</summary>

    ```cs
    int count = 0;

    for (int i = 0; i < myArray.Length; i++) 
    {
        if (myArray[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
    ```
    </details>

#. Given an array and some value x, write code that computes the number of times x occurs in the array.

    <details>
    <summary>Solution</summary>

    ```cs
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (x == array[i])
        {
            count++;
        }
    }
    ```
    </details>

#. Write a program that computes the average of values of a numeric array.

    <details>
    <summary>Solution</summary>

    ```cs
    int ArrayAverage(int[] a)
    {
        int sum = 0;

        for (int i = 0; i < a.Length; i++)
        {
            sum += a[i];
        }

        return sum / array.Length;
    }
    ```
    </details>

#. Write a program that finds the largest value in an integer array.

    <details>
    <summary>Solution</summary>

    ```cs
    int LargestValue(int[] a)
    {
        if (a.Length == 1)
        {
            return a[0];
        }
        else
        {
            int largest = a[0];

            foreach (int i in a)
            {
                if (i > largest)
                {
                    largest = i;
                }
            }

            return largest;
        }
    }
    ```
    </details>

#. Write a program that finds the smallest value in an integer array.

    <details>
    <summary>Solution</summary>

    ```cs
    int SmallestValue(int[] a)
    {
        if (a.Length == 1)
        {
            return a[0];
        }
        else
        {
            int smallest = a[0];

            foreach (int i in a)
            {
                if (i < smallest)
                {
                    smallest = i;
                }
            }

            return smallest;
        }
    }
    ```
    </details>

#. Write a program that finds second smallest value in an array of integers.

    <details>
    <summary>Solution</summary>

    ```cs
    int SecondSmallestValue(int[] a)
    {
        int smallest = a[0];
        int secondSmallest = a[1];

        if (smallest > secondSmallest)
        {
            int temp = smallest;
            smallest = secondSmallest;
            secondSmallest = temp;
        }

        for (int i = 2; i < a.Length; i++)
        {
            if (a[i] < smallest)
            {
                secondSmallest = smallest;
                smallest = a[i];
            }
            else if (a[i] < secondSmallest && a[i] > smallest)
            {
                secondSmallest = a[i];
            }
        }

        return secondSmallest;
    }
    ```
    </details>

#. Write code that finds the index of the first occurrence of a value in an array. If the array does not contain the value, the result should be -1.

    <details>
    <summary>Solution</summary>

    ```cs
    int FirstOccurrence(int[] a, int v)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == v)
            {
                return i;
            }
        }
        return -1;
    }
    ```
    </details>

#. Write code that finds the index of the last occurrence of a value in an array. If the array does not contain the value, the result should be -1.

    <details>
    <summary>Solution</summary>

    ```cs
    int LastOccurrence(int[] a, int v)
    {
        for (int i = a.Length - 1; i > 0; i--)
        {
            if (a[i] == v)
            {
                return i;
            }
        }
        return -1;
    }
    ```
    </details>

#. Write code that counts the number of occurrences of a specified value in an array.

    <details>
    <summary>Solution</summary>

    ```cs
    int NumberOfOccurrences(int[] a, int v)
    {
        int count = 0;
        foreach (int i in a)
        {
            if (i == v)
            {
                count++;
            }
        }
        return count;
    }
    ```
    </details>

#. Write code to reverse the contents of an array.
Example: Array [1,4,3,2,5] should be [5,2,3,4,1] after being reversed

    <details>
    <summary>Solution</summary>

    ```cs
    void ReverseArray(int[] array)
    {
        for (int i = 0, j = array.Length - 1; i < j; i++, j--)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
    ```
    </details>

#. Write a program that combines two arrays of same data type into a single array. No values should be lost during the merge.

    <details>
    <summary>Solution</summary>

    ```cs
    string[] CombineArray(string[] array1, string[] array2)
    {
        string[] combined = new string[array1.Length + array2.Length];

        int i = 0;

        for (; i < array1.Length; i++)
        {
            combined[i] = array1[i];
        }

        for (int j = 0; j < array2.Length; j++)
        {
            combined[i + j] = array2[j];
        }

        return combined;
    }
    ```
    </details>


## Problems

#. Declare and initialize three arrays:

    - Choose different data type for each array
    - Make the arrays have different lengths: 3, 5, 10 elements respectively
    - Initialize each array with appropriate values of your choice (depends on the type)

    After you have declared and initialized the arrays, display on the screen

    - The first value from array 1 (0th index)
    - The last value from array 2 (4th index)
    - the first three values from array 3 (indexed 0 - 2)

    <details>
    <summary>Example Solution</summary>

    ```cs
    // Initialize arrays
    string[] names = { "Alice", Bob", "Charlie" };
    float[] tenths = { 0.1f, 0.2f, 0.3f, 0.4f, 0.5f };
    int[] evens = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

    // Display elements from arrays
    Console.WriteLine( names[0] ); // Displays: Alice
    Console.WriteLine( tenths[4] ); // Displays: 0.5 
    Console.WriteLine( evens[0] + " " + evens[1] + " " + evens[2] ); // Displays: 2 4 6
    ```
    </details>

#. Consider this array of words:

    ```
    string[] words = {"voice", "effect", "day", "orange", "appliance", "fly", "cloud", "degree", "engine", "society"};
    ```

    Write code to display an answer to the following questions. If the solution requires looping, use **foreach** loop when possible. Otherwise, use a **for** loop.

    #. Does words array contain "engine"? (true/false)
    #. Does words array contain "day" at least 2 times? (true/false)
    #. What is the position (index) of the word society? If it does not exist answer should be -1. Find the position of the first occurrence in case there are multiple matches.

    After you have implemented your code, change the array contents and make sure your code still works and does not crash.

    Here is another array of words to test your solution:

    ```
    string[] words = {"addition", "day", "start", "dock", "fowl", "fish", "seat", "day"};
    ```

    <details>
    <summary>Solution</summary>

    ```cs
    // Code for finding the word "engine" in the array
    bool foundEngine = false;

    for (int i = 0; i < words.Length; i++)
    {
        if (words[i] == "engine")
        {
            foundEngine = true;
        }
    }

    Console.WriteLine("Array contains \"engine\": " + foundEngine);

    // Code for finding the word "day" in the array at least twice
    bool foundDay2x = false;
    int dayCount = 0;

    for (int i = 0; i < words.Length; i++) 
    {
        if (words[i] == "day")
        {
            dayCount++;
        }
    }

    if (dayCount >= 2) 
    {
        foundDay2x = true;
    }

    Console.WriteLine("Array contains \"day\" twice: " + foundDay2x);

    // Code for finding the position of the word "society" in the array
    int societyPos = -1;

    for (int i = 0; i < words.Length; i++)
    {
        if (words[i] == "society")
        {
            societyPos = i;
            break;
        }
    }

    Console.WriteLine("Position of \"society\": " + societyPos);
    ```
    </details>
