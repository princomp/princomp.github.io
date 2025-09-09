using System;

class Program
{
  static void Main(string[] args)
  {
    /* First example. */
    CQueue<int> myQueue1 = new CQueue<int>();
    Console.WriteLine(myQueue1);
    myQueue1.Enqueue(1);
    myQueue1.Enqueue(2);
    myQueue1.Enqueue(3);
    myQueue1.Enqueue(4);
    myQueue1.Enqueue(5);
    Console.WriteLine(myQueue1);
    Console.WriteLine(
      "Value dequeued: " + myQueue1.Dequeue()
    );
    Console.WriteLine(myQueue1);

    myQueue1.Enqueue(6);
    myQueue1.Enqueue(7);
    myQueue1.Enqueue(8);
    myQueue1.Enqueue(9);
    myQueue1.Enqueue(10);
    Console.WriteLine(myQueue1);

    Console.WriteLine(
      "Value dequeued: " + myQueue1.Dequeue()
    );
    Console.WriteLine(myQueue1);
    Console.WriteLine(
      "Value dequeued: " + myQueue1.Dequeue()
    );
    Console.WriteLine(myQueue1);
    myQueue1.Enqueue(11);
    myQueue1.Enqueue(12);
    myQueue1.Enqueue(13);

    try
    {
      myQueue1.Enqueue(14);
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.Message);
    }
    Console.WriteLine(myQueue1);
  }
}
