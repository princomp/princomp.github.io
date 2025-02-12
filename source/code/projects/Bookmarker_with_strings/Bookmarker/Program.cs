using System;

class Program
{
  static void Main()
  {
        string title, tPages, cPages;
        /* 
         * To trigger failure to create the object, 
         * test with the following values:
         */
        // "Random", "Test", "0"    to get "Input string was not in a correct format."
        // "Random", "-12",  "0"    to get "The total number of pages cannot be negative."
        // "Random", "12",   "Test" to get "Input string was not in a correct format."
        // "Random", "12",   "15"   to get "You cannot have read more than the total number of pages!
        // "Random", "12",   "-12"  to get "You cannot have read a negative number of pages!"
        /*
         * To trigger error when calling the "Read" method, try, 
         * test with the following values, after having created an object
         * using "Test", "10", "5"
         */
        // "6"    to get "You cannot have read more than the total number of pages!"
        // "-3"   to get "Input string was not in a correct format."
        // "Test" to get "Input string was not in a correct format."
        /*
         * An additional test would be to add, for example
         *             book1.TPages = "3";
         * after
         *             Console.WriteLine(book1);
         * to make sure that setting the number of page to an "invalid" 
         * value would trigger the error
         * "The total number of pages cannot be less than the current page."        
         */

        try
        {
            Console.WriteLine("Enter the title of the book.");
            title = Console.ReadLine();
            Console.WriteLine("Enter the total number of pages.");
            tPages = Console.ReadLine();
            Console.WriteLine("Enter the page you stopped your reading at.");
            cPages = Console.ReadLine();
            Bookmarker book1 = new Bookmarker(title, tPages, cPages);
            Console.WriteLine(book1);
            Console.WriteLine("How many pages did you read?");
            book1.Read(Console.ReadLine());
            Console.WriteLine(book1);
}
        catch (Exception ex)
        { Console.WriteLine(ex.Message); }

  }
}
