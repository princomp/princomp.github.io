using System;

class Program
{
  static void Main(string[] args)
  {
    PQueue<int, string> myQueue = new PQueue<int, string>(
      5
    );
    try
    {
      myQueue.MinPriority();
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.Message);
    }

    /*
     * https://en.wikipedia.org/wiki/Emergency_Severity_Index
     * Level 1: Resuscitation
     * Level 2: Emergent
     * Level 3: Urgent
     * Level 4: Semi-Urgent
     * Level 5: Non-urgent
    */
    myQueue.Add(1, "Cardiac arrest");
    Console.WriteLine(myQueue);
    int minP = myQueue.MinPriority();
    Console.Write(
      "Most urgent priority is at index "
        + minP
        + " with "
        + myQueue.Peek()
        + ".\n"
    );
    myQueue.Add(3, "High fever with cough");
    myQueue.Add(2, "Asthma attack");
    myQueue.Add(5, "Prescription refill ");
    myQueue.Add(4, "Simple laceration");
    Console.WriteLine(myQueue);

    try
    {
      myQueue.Add(3, "Abdominal pain");
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.Message);
    }

    Console.Write(
      "Removing most urgent: " + myQueue.Extract() + ".\n"
    );
    Console.Write(
      "Removing most urgent: " + myQueue.Extract() + ".\n"
    );

    Console.WriteLine(myQueue);
    myQueue.Add(5, "Suture removal");
    Console.Write(
      "Removing most urgent: " + myQueue.Extract() + ".\n"
    );
    Console.Write(
      "Removing most urgent: " + myQueue.Extract() + ".\n"
    );
    Console.WriteLine(myQueue);

    Console.Write(
      "Removing most urgent: " + myQueue.Extract() + ".\n"
    );
    Console.Write(
      "Removing most urgent: " + myQueue.Extract() + ".\n"
    );
    try
    {
      Console.Write(
        "Removing most urgent: " + myQueue.Extract() + ".\n"
      );
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.Message);
    }
  }
}
