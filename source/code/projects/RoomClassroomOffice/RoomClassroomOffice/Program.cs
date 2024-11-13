using System;

class Program
{
  static void Main(string[] args)
  {
    // Question 1
    Room test = new Room("UH", 243);
    Console.WriteLine(test);
    // Refer to Classroom.cs for a solution
    // Question 2
    Office test1 = new Office("UH", 127, "706 737 1566");
    ClassRoom test2 = new ClassRoom("UH", 243, true);
    Office test3 = new Office("AH", 122, "706 729 2416");
    Console.WriteLine(Room.SameBuilding(test1, test2));
    Console.WriteLine(Room.SameBuilding(test2, test3));
    // Refer to Room.cs for a solution.
  }
}
