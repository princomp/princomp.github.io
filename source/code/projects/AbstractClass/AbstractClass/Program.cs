using System;

class Program
{
  static void Main()
  {
        // Person test = new Person(); // Cannot create an instance of the abstract type or interface 'Person'
        Employee Harley = new Employee();
        Harley.Id = "E8190";

        Student Morgan = new Student();
        try
        {
            Morgan.Id = "E8194";
        }
        catch
        {
            Console.WriteLine("We cannot set the Id of a student to a string not starting with 'S'!");
        }
        Morgan.Id = "S8194";
    }
}
