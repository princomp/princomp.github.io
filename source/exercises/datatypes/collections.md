---
tags:
  - datatypes/collections
aliases:
  - Datatype - Collections
---

## Warm-up Exercises

#. Write a statement that creates a 10-element **int** array named `numbers`.

<details>
<summary>Solution</summary>

```cs
int[] numbers = new int[10];
```
</details>



#. Suppose we are given an **int** array `dailyPushUp` with 7 elements. Write a piece of code that displays the value of the elements stored in the array `dailyPushUp`.

<details>
<summary>Solution</summary>

```cs
for (int j = 0; j < 7; j++)
	Console.WriteLine(dailyPushUp[j]);
```
</details>

#. Write a statement that creates and initializes a double array with the values 12.5, 89.0 and 3.24.

<details>
<summary>Solution</summary>

```cs
double[] question = {12.5, 89.0, 3.24};
```
</details>

#. Assuming we have two **int** arrays of the same size, `firstA` and `secondA`, write a program that copies the content of `firstA` into `secondA`.

<details>
<summary>Solution</summary>

```cs
for (int k =0; k < firstA.Length; k++)
	secondA[k] = firstA[k];
```
</details>

#. Write a static methos (header included) that takes as an argument an **int** array, and display on the screen the value of each element of that array.

<details>
<summary>Solution</summary>

```cs
public static void p(int[] a){
	foreach (int k in a) Console.WriteLine(k);
}
```
</details>

#. Write a static method (header included) that takes as an argument an **int** array, and stores the value 10 in each element of that array.

<details>
<summary>Solution</summary>

```cs
public static void z(int[] a){
	for (int j = 0; j < a.Length; j++) a[j] = 10;
}
```
</details>

#. Write code that displays the first and last element of an array.

<details>
<summary>Solution</summary>

```cs
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Console.WriteLine( $"First element: { numbers[0] }" );
Console.WriteLine( $"Last element: { numbers[numbers.Length - 1] }" );
```
</details>

#. Write code that displays every element in an array.

<details>
<summary>Solution</summary>

```cs
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

for ( int i = 0; i < numbers.Length; i++ )
{
	Console.WriteLine( numbers[i] );
}
```
</details>

#. Write code that displays every element in an array in reverse order.

<details>
<summary>Solution</summary>

```cs
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

for ( int i = (numbers.Length - 1) ; i >= 0 ; i-- )
{
	Console.WriteLine( numbers[i] );
}
```
</details>

#. Write code that displays every other element in an array (every even index).

<details>
<summary>Solution</summary>

```cs
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

for (int i = 0; i < numbers.Length; i += 2)
   {
	   Console.WriteLine( numbers[i] );
   }
```
</details>

#. Write code that displays every integer array value that is equal or greater than x, where x is some integer value.

<details>
<summary>Solution</summary>

```cs
int x = 6; // Value chosen arbitrarily. You can use different values to test this program.
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

for (int i = 0; i < numbers.Length; )
{
	if ( numbers[i] >= x )
	{
		Console.WriteLine( numbers[i] );
	}
}
```
</details>

#. Write code that displays every value in an integer array, so that each value is multiplied by itself before being displayed.

<details>
<summary>Solution</summary>

```cs
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

for ( int i = 0; i < numbers.Length; i++ )
{
	Console.WriteLine( numbers[i] * numbers[i] );
}
```
</details>

#. Write code that displays every unique value of a sorted array. This array could be, for example, 1 1 1 4 4 5 8 9 11 such that values are increasing but value can occur multiple times.

<details>
<summary>Solution</summary>

```cs
int[] numbers = {1, 1, 1, 4, 4, 5, 8, 9, 11};

for ( int i = 0 ;  i < numbers.Length ; i++ )
{
	if ( i > 0 && numbers[i] != numbers[i - 1] )
	{
		Console.WriteLine( numbers[i] );
	}
}

```
</details>

#. Given some positive number n, write code that first declares an array of length n, then sets its contents to sequentially increasing values 1, 2, 3, ..., n.

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

#. Given an array and some value x, write code that sets the value of every array element to x.

<details>
<summary>Solution</summary>

```cs
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = x;
}
```
</details>

#. Given an array, an `oldValue`, and a `newValue`; write code that replaces every occurrence of oldValue in the array with newValue.

<details>
<summary>Solution</summary>

```cs
for ( int i = 0; i < myArray.Length; i++ )
{
    if ( myArray[i] == oldValue )
    {
        myArray[i] = newValue;
    }
}
```
</details>

#. Write code that squares every value in an integer array.
Example: Given array [2,3,4] the result is [4,9,16]

<details>
<summary>Solution</summary>

```cs
int[] myArray = { 2, 3, 4 };

for ( int i = 0; i < myArray.Length; i++ )
{
    myArray[i] *= myArray[i];
}
```
</details>

#. Given an array of integers, replace each element with the product of the array elements divided by the current element.
Example: Given array [1,2,3,4] the result is [24,12,8,6]

<details>
<summary>Solution</summary>

```cs
// Get the product of the array elements
int product = 1;
for ( int i = 0; i < myArray.Length; i++)
{
    product *= myArray[i];
}

// Replace each array element with the value resulting from the array product divided by that array element
for ( int i = 0; i < myArray.Length; i++ )
{
    myArray[i] = product / myArray[i];
}
```
</details>

#. Write code that checks if a value occurs in an array at least one time. The result should be Boolean true if the values exists somewhere in the array, and false otherwise.

<details>
<summary>Solution</summary>

```cs
int[] array = { 1, 2, 3, 4, 5 }; // Values chosen arbitrarily
int value = 3; // Arbitrary value

bool exists = false;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == value)
    {
        exists = true;
        break;
    }
}
```
</details>

#. Given two arrays, determine if there exists a value that occurs in both arrays. If such value exists, the result should be true and false otherwise.

<details>
<summary>Solution</summary>

```cs
bool valueInCommon;

for (int i = 0; i < array1.Length; i++)
{
    for (int j = 0; j < array2.Length; j++)
    {
        if (array1[i] == array2[j])
        {
            valueInCommon = true;
            break;
        }
    }
}
```
</details>

#. Given an array and two values x and y, write code that checks if the array contains at least one of the values, x or y. the result should be true if either value occurs somewhere in the array and false otherwise.

<details>
<summary>Solution</summary>

```cs
bool eitherExists = false;

for (int i = 0; i < array.Length; i++)
{
    eitherExists = array[i] == x || array[i] == y;
    if (eitherExists)
    {
        break;
    }
}
```
</details>

#. Given an array and two values x and y, write code that checks if the array contains both values x and y. The result should be true when both values occur somewhere in the array and false otherwise.

<details>
<summary>Solution</summary>

```cs
int[] array = { 1, 2, 3, 4, 5, 6, 7 };
int x = 0, y = 6;

bool xExists = false, yExists = false, bothExist = false;

for (int i = 0; i < array.Length; i++)
{
    if (!xExists && array[i] == x)
    {
        xExists = true;
    }

    if (!yExists && array[i] == y)
    { 
        yExists = true;
    }

    if (xExists && yExists)
    {
        bothExist = true;
        break;
    }
```
</details>

#. Given two arrays arrayA and arrayB, write code to check if every element in arrayB exists somewhere in arrayA in any order. Display result as true or false.

<details>
<summary>Solution</summary>

```cs
bool AContainsB(int[] arrayA, int[] arrayB)
{

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
    return containsB;
}
```
</details>

#. Given two arrays arrayA and arrayB, write code to check if arrayA contains arrayB. The elements must appear in the same order in both arrays. Display result as true or false.
Note: array lengths maybe different — do not assume equal length.

<details>
<summary>Solution</summary>

```cs
bool AContainsB(int[] arrayA, int[] arrayB)
{
    // Check if arrayB is empty or bigger than arrayA
    if (arrayB.Length <= 0 || arrayA.Length < arrayB.Length)
    {
        return false;
    }
    
    // If arrayB is valid, continue.
    bool ArrayBInA = false;
    int i = 0;

    do
    {
        if (arrayA[i] == arrayB[0])
        {
            for (int j = 1; j < arrayB.Length; j++)
            {
                if (arrayA[i + j] != arrayB[j])
                {
                    ArrayBInA = false;
                    break;
                }
                else
                {
                    ArrayBInA = true;
                }
            }
        }
        i++;
    }while (!ArrayBInA && i < arrayA.Length - arrayB.Length);

    return ArrayBInA;
}
```
</details>

#. Consider an array of char type. Implement code to check if the array values form a palindrome, i.e. it reads the same way forwards and backwards.

<details>
<summary>Solution</summary>

```cs
bool Palindrome(char[] myArray)
{
    int n = myArray.Length;
    for (int i = 0; i < (n / 2); i++)
    {
        if (myArray[i] != myArray[(n - 1) - i]) // The two sides of the word are not equal to each other.
        {
            return false;
        }
    } // Both sides of the word have been checked and are mirrors of each other.
    return true;
}
```
</details>

#. Given an integer array and an integer value x, find an array element whose value is largest while also being strictly less than x.
Example: Given array [1,2,6,7,3,9] and x = 8 the solution is 7.

<details>
<summary>Solution</summary>

```cs
int LargestUnderX(int[] a, int x)
{
    int largest = 0;
    if (a[0] < x)
    {
        largest = a[0];
    }

    for (int i = 1; i < a.Length; i++)
    {
        if (a[i] < x && a[i] > largest)
        {
            largest = a[i];
        }
    }

    return largest;
}
```
</details>

#. Write a program that computes the sum of values of a numeric array.

<details>
<summary>Solution</summary>

```cs
int Sum(int[] a)
{
    int sum = 0;

    for (int i = 0; i < a.Length; i++)
    {
        sum += a[i];
    }
    return sum;
}
```
</details>

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


## Questions

#. What sequence will appear on the output of this C# code? Which parameter of `SD(int[] A, int B)` method is passed by value? 
```cs
using System;
class Program
{
    static void SD(int[] A, int B)
    {
        A[2] += A[2];
        B /= B;
    }
    static void Main(string[] args)
    {
        int[] A = { 0, 1, 2, 3 };
        S(A, A[2]);
        Console.Write($"[{A[0]},{A[1]},{A[2]},{A[3]}]");
    }
}
```
<details><summary>Solution</summary>
  The sequence that appears in the output is 0, 1, 4, 3. The parameter int B is passed by value.
</details>

#. Which of the following correctly declares and creates a two-dimensional rectangular array of integers?
- [x] int[,] sum = new int[10, 40];
- [ ] int[][] sum = new int[25, 43];
- [ ] int sum[] = new int[20, 20];
- [ ] None of the above.

#. C# supports two types of two-dimensional arrays:
- [ ] quadrilateral and isosceles
- [x] jagged and rectangular
- [ ] jagged and round
- [ ] None of the above.

#. Consider the following code:

```cs
for (int y = 1; y <= 3; y++)
{
	for (int z = 1; z < 5; z++)
		Console.Write("Scene " + y + ", take " + z + ". " );
	Console.WriteLine();
}
```
- How many times does the outer loop iterate (i.e., how many scenes are shot)? 
- How many times does the inner loop iterates (i.e., how many takes for each scene)? 
- Finally, what is the total number of iteration of the nested loops (i.e., how many takes are made, total)?

<details>
<summary>Solution</summary>
3, 4, 12
</details>

#. Mark the pretest loops:
- [ ] do while
- [ ] switch
- [ ] while
- [ ] for
- [ ] if-else-if

<details>
<summary>Solution</summary>
for and while are the pretest loops
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


#. What is “array bounds checking”? When does it happen?

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

#. Suppose we have an array named temp that has been declared and initialized. How can we know the number of elements in this array?

<details>
<summary>Solution</summary>
By using the `Length` field: `temp.Length`
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


#. What is wrong with the following array declaration?

```cs
int[] books = new int[-1];
```
<details>
<summary>Solution</summary>
The size declarator cannot be negative.
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

1. Does words array contain "engine"? (true/false)
2. Does words array contain "day" at least 2 times? (true/false)
3. What is the position (index) of the word society? If it does not exist answer should be -1. Find the position of the first occurrence in case there are multiple matches.

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