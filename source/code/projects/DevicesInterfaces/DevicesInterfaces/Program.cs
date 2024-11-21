using System;

class Program
{
  static void Main()
  {
    Computer test0 = new Computer(100000, 120, 50);
    test0.SafetyNotice();
    test0.Instructions();
  }
}
