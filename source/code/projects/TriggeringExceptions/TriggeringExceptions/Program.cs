using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter a number");
            int uInput = int.Parse(Console.ReadLine());
            int[] t = { 10 };
            int div = 0 / (uInput -1);
            int tAcces = t[uInput];
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("IndexOutOfRangeException");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("DivideByZeroException");
        }
        catch (FormatException)
        {
            Console.WriteLine("FormatException");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("ArgumentNullException");
        }
    }
}
