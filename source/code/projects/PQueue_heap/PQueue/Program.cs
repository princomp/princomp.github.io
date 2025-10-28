using System;

class Program
{
  static void Main(string[] args)
  {

        PQueue<int, int> heapEx = new PQueue<int, int>(7);
        for (int i = 6; i > 0; i--)
        {
            heapEx.Add(i, i);
            Console.WriteLine(heapEx);
        }
        heapEx.Add(-1, -1);
        Console.WriteLine(heapEx);

        // Let us extract three values.
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Lowest priority:" + heapEx.Extract());
            Console.WriteLine(heapEx);
        }
        Console.WriteLine(heapEx);

        /*
         * 
         * Level 1: Resuscitation
         * Level 2: Emergent
         * Level 3: Urgent
         * Level 4: Semi-Urgent
         * Level 5: Non-urgent
         */
        PQueue<int, string> myQueue = new PQueue<int, string>(5);
    myQueue.Add(3, "Abdominal pain ");
    Console.WriteLine(myQueue);

    }
}
