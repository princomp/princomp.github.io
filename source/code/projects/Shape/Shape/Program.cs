using System;

class Program
{
    static void Main(){
        /* Black
         * DarkBlue
         * DarkGreen
         * DarkCyan
         * DarkRed
         * DarkMagenta
         * DarkMagenta
         * DarkYellow
         * Gray
         * DarkGray
         * Blue
         * Green
         * Cyan
         * Red
         * Magenta
         * Yellow
         * White
         * Black
         */
     

        Rectangle test0 = new Rectangle(5, 3, "Blue", false);
        Console.Write(test0);
        test0.Talk();
        test0.FlipRight();
        Console.Write(test0);
        test0.Talk();

        Rectangle test1 = new Rectangle(5, 3, "Cyan", true);
        Console.Write(test1);
        test1.Talk();
        test1.FlipRight();
        Console.Write(test1);
        test1.Talk();




    }
}
