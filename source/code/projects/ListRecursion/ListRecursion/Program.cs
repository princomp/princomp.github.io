using System;
using System.Collections.Generic;

class Program
{
  static void Main(string[] args)
  {
        void CountDown(int n)
        {
            if(n == 0){ Console.WriteLine($"{n}: Blast off!"); }
            else { Console.WriteLine($"{n}…");
                CountDown(n - 1);
            }
        }
        CountDown(10);
        //CountDown(-1);
        void Violent()
        {
            Violent();
        }
        // Violent();

        int[] arrayExample = { 1, 10, 12, 129, 190, 220, 230, 310, 320, 340, 400, 460 };

        Console.Write(BinFind(arrayExample, 12));

        bool BinFind(int[] aP, int target)
        {
            return BinFind(aP, 0, aP.Length, target);
        }

        bool BinFind(int[] aP, int start, int end, int target) {
            int mid = (start + end) / 2;
            if (target == aP[mid]) { return true; }
            else if (target < aP[mid]) { return BinFind(aP, mid + 1, end, target); }
            else if (target > aP[mid]) { return BinFind(aP, start, mid + 1, target); }


        }


        bool foundSoFar = false;

        int target = 340;

        int start = 0;
        int end = arrayExample.Length - 1;
        int mid;
        while (start <= end && !foundSoFar)
        {
            mid = (start + end) / 2;
            /*
             * This is integer division: if start + end is odd,
             * then it will be truncated. In our example, 
             * (0 + 11) / 2 gives 5.
             */
            Console.WriteLine("The middle index is " + mid + ".");
            if (target == arrayExample[mid])
            {
                foundSoFar = true;
            }
            else if (target > arrayExample[mid])
            {
                start = mid + 1;
                Console.WriteLine("I keep looking right.");
            }
            else
            {
                end = mid - 1;
                Console.WriteLine("I keep looking left.");
            }
        }
        Console.WriteLine("Found the value: " + foundSoFar + ".");

        Console.WriteLine();
    }
}
