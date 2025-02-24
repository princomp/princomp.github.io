using System;

static class Calculator
{
    public static int Square(int p)
    {
        if (p > 46341 || p < -46341) throw new OverflowException();
        else return p * p;
    }
    public static int Divide(int dividend, int divisor)
    {
        if (divisor == 0) throw new ArgumentOutOfRangeException();
        else return dividend / divisor;
    }
}

class Program
{

    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter a value");
            int uInput = int.Parse(Console.ReadLine());
            Console.Write("Your value squared is " + Calculator.Square(uInput) + ".\n");
        }
        catch(OverflowException)
        {
            Console.WriteLine("Your value squared will not fit in an int!");
        }
        // The following catch block catch exceptions thrown by int.Parse:
        catch (ArgumentNullException)
        {
            Console.WriteLine("No argument provided.");
        }
        catch (FormatException)
        {
            Console.WriteLine("The string does not contain only number characters.");
        }
        finally
        {
            Console.WriteLine("Thanks!");
        }
    }
}
