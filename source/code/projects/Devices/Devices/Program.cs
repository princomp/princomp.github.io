using System;

class Program
{
  static void Main()
  {
    Abacus test0 = new Abacus(1.5, "Wood");
    test0.Instructions();
    USWashingMachine test1 = new USWashingMachine(120, 50);
    test1.SafetyNotice();
  }
}
