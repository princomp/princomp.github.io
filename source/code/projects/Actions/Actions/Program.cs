using System;

class Program
{
  static void Main()
  {
    // We can call our methods directly:
    ExampleActions.Test();
    ExampleActions.Display(3);
    ExampleActions<int>.DisplayArray(
      new int[] { 20, 30, 40 }
    );

    // Or we can store them
    // in variables and then call them:

    Action test_variable = ExampleActions.Test;
    test_variable();

    Action<int> display_variable = ExampleActions.Display;
    display_variable(10);

    Action<int[]> display_array_variable =
      ExampleActions<int>.DisplayArray;
    display_array_variable(new int[] { 10, 20, 30 });

    // Passing an action as an argument:
    CallingAction.Demo(ExampleActions.Test);
    CallingAction.DemoT(ExampleActions.Display);

    // Done passing an action.
  }
}
