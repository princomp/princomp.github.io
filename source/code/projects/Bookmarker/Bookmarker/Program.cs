using System;

class Program
{
  static void Main()
  {
        string title, tPages, cPages;
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
