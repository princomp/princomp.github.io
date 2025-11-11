using System;

class Program
{
    static void Main()
    {
        // We can call our 
        // "Test" method directly:
        ExampleActions.Test();

        // Or we can store it
        // in a variable and then call it.

        /* An action is a 
         * method that has no parameters and 
         * does not return a value.
         * https://learn.microsoft.com/en-us/dotnet/api/system.action?view=net-9.0        
         */

        Action test_variable = ExampleActions.Test;
        test_variable();

        // Similarly with arguments:
        ExampleActions.Display(3);
        Action<int> display_variable = ExampleActions.Display;
        display_variable(10);

        // We can even have actions
        // from classes that uses generic
        // type parameters.

        int[] arrayT = { 20, 30, 40 };
        ExampleActions<int>.DisplayArray(arrayT);

        Action<int[]> display_array_variable = ExampleActions<int>.DisplayArray;
        display_array_variable(arrayT);

        // Passing an Action as an argument:
        CallingAction.Demo(ExampleActions.Test);
    }
}