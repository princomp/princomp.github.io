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


        int[] arrayS = { 1, 2, 4, 10, 13, 17 };
        int[] arrayNS = { 12, 98, 120, 15 };
        int[] arrayExample = { 1, 10, 12, 129, 190, 220, 230, 310, 320, 340, 400, 460 };

        Console.WriteLine("Array sorted: " + Sorted(arrayS));
        Console.WriteLine("Array sorted: " + Sorted(arrayNS));
        Console.WriteLine("Array sorted: " + Sorted(arrayExample));

        bool Sorted(int[] aP)
        {
            if (aP == null) return false;
            else return SortedH(aP, 0);
        }

        bool SortedH(int[] aP, int currentIndex)
        {
            if (aP.Length == currentIndex+1) return true;
            else if (aP[currentIndex] > aP[currentIndex+1]) return false;
            else return SortedH(aP, currentIndex + 1);
        }


        Console.Write("BinFind: " + BinFind(arrayExample, 10));

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
