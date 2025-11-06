using System;
using System.Collections.Generic;


static class Displaying<T> where T : IComparable<T>
    {
    public static void DisplayHeader(List<T> aList, int start, int stop)
        {
            for (int i = start; i < stop; ++i)
                Console.Write("[{0,2}]", i);
            Console.WriteLine();
        }

        public static void Display2(List<T> aList, int start, int stop)
        {
            for (int i = start; i < stop; ++i)
            {
                if (i == start || i == (start - 1 + stop) / 2)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("{0,4}", aList[i]);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else if (i == (stop - 1))
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("{0,4}<==", aList[i]);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else
                    Console.Write("{0,4}", aList[i]);
            }

            Console.WriteLine();
        }
        public static void Display3(List<T> aList, int start, int stop, int pivotPos)
        {
            for (int i = start; i < stop; ++i)
            {
                if (i < pivotPos)
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("{0,4}", aList[i]);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else if (i == pivotPos)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("{0,4}", aList[i]);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else if (i > pivotPos)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("{0,4}", aList[i]);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
            }
            Console.WriteLine();
        }

        /*
         * Black 0, DarkBlue 1, DarkGreen 2, DarkCyan 3, DarkRed 4, DarkMagenta 5, DarkYellow 6, Gray 7, DarkGray 8, 
         * Blue 9, Green 10, Cyan 11, Red 12, Magenta 13, Yellow 14, White 15  	
         */
        public static void DisplayEvery(List<T> aList, int start, int stop, int ith)
        {
            for (int i = start; i < stop; ++i)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                int colorValue = 10 + (i % ith);
                if (colorValue == 9 || colorValue == 4 || colorValue == 5)
                    Console.ForegroundColor = ConsoleColor.White;

                Console.BackgroundColor = (ConsoleColor)colorValue;
                Console.Write("{0,4}", aList[i]);

                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;

            }
            Console.WriteLine();
        }
        public static void Display(List<T> aList, int start = 0, int end = -1)
        {
            if (end == -1)
                end = aList.Count;

            for (int i = start; i < end; i++)
                Console.Write("{0,4}", aList[i]);
            Console.WriteLine();
        }
        public static void DisplayOne(List<T> aList, int pos, int start = 0, int end = -1)
        {
            if (end == -1)
                end = aList.Count;

            for (int i = start; i < end; i++)
            {
                if (pos != i)
                    Console.Write("{0,4}", aList[i]);
                else
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("{0,4}", aList[i]);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
            }
            Console.WriteLine();
        }
    }
