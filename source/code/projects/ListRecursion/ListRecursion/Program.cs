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

        Console.Write(BinFind(arrayExample, 10));

        bool BinFind(int[] aP, int target)
        {
            return BinFindH(aP, 0, aP.Length, target);
        }

        bool BinFindH(int[] aP, int start, int end, int target) {
            int mid = (start + end) / 2;
            if (start > end) { return false; }
            else
            {
                if (target == aP[mid]) { return true; }
                else if (target > aP[mid]) { return BinFindH(aP, mid + 1, end, target); }
                else { return BinFindH(aP, start, mid -1, target); }
            }
        }


    }
}
