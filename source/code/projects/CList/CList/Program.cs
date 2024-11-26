using System;

class Program
{
    static void Main(string[] args)
    {
        /* First example. */
        CList<int> myList1 = new CList<int>();
        myList1.AddL(1);
        myList1.AddL(5);
        myList1.AddL(2);
        myList1.AddL(2);
        myList1.AddL(1);
        myList1.AddL(1);
        myList1.AddL(3);
        myList1.AddL(4);
        myList1.AddL(5);
        myList1.AddL(5);
        myList1.AddL(5);
        myList1.AddL(2);
        myList1.AddL(2);
        Console.WriteLine(myList1);
        Console.WriteLine("Greatest number of consecutive 1s:" + myList1.CountSuccessive(1));
        Console.WriteLine("Greatest number of consecutive 5s:" + myList1.CountSuccessive(5));
        Console.WriteLine("Greatest number of consecutive 2s:" + myList1.CountSuccessive(2));
        Console.WriteLine("Last index of 1:" + myList1.LastIndexOf(1));
        Console.WriteLine("Frequency of 1:" + myList1.Frequency(1));

        Console.WriteLine("Size is " + myList1.Size);
        Console.WriteLine("0th elem is " + myList1.Access(0));
        Console.WriteLine("2nd elem is " + myList1.Access(2));
        Console.WriteLine("Is 2 in my list? " + myList1.Find(2));
        Console.WriteLine("Is 3 in my list? " + myList1.Find(3));
        Console.WriteLine("Is 4 in my list? " + myList1.Find(4));
        Console.WriteLine("Is 5 in my list? " + myList1.Find(5));
        Console.WriteLine("Is 6 in my list? " + myList1.Find(6));
        myList1.Reverse();
        Console.WriteLine(myList1);
        myList1.RemoveAt(1);
        Console.WriteLine(myList1);


        myList1.RemoveI(2);
        Console.WriteLine("Removed the element on the second index.");
        Console.WriteLine(myList1);
        Console.WriteLine("0th elem is " + myList1.Access(0));
        Console.WriteLine("2nd elem is " + myList1.Access(2));

        Console.WriteLine("\n\n\n"); // Spacing…

        /* Second example. */
        CList<char> myList2 = new CList<char>();
        try
        {
            myList2.RemoveI(0);
        }
        catch
        {
            Console.WriteLine("Tried to acces an element at an index that doesn't exist.");
        }
        try
        {
            myList2.RemoveF();
            Console.WriteLine("Sucessfully removed the first element.");
            myList2.RemoveL();
            Console.WriteLine("Sucessfully removed the last element.");
            Console.WriteLine(myList2.Access(0));
        }
        catch
        {
            Console.WriteLine("Tried to access an element that doesn't exist.");
        }

        myList2.AddF('a');
        myList2.AddL('z');
        Console.WriteLine(myList2);
        Console.WriteLine(myList2.Access(0));
        Console.WriteLine(myList2.Access(1));
        try
        {
            Console.WriteLine(myList2.Access(2));
        }
        catch
        {
            Console.WriteLine("Tried to access an element that doesn't exist.");
        }
    }
}