using System;
using System.Collections.Generic;

static class Sorting<T> where T : IComparable<T>
    {

        // Insertion Algorithm
        public static void InsertionSort(List<T> listP)
        {
            int swapOperations = 0;
        // Can be ignored, is simply here
        // to count number of time we 
        // swap values.
        Console.WriteLine("----------- Insertion Sort -------");
            Displaying<T>.DisplayHeader(listP, 0, listP.Count);

            T current;
            int slot;
            for (int bar = 1; bar < listP.Count; bar++)
            {
                current = listP[bar];
                for (slot = bar; slot > 0 && current.CompareTo(listP[slot - 1]) < 0; slot--)
                {
                    swapOperations++;
                    listP[slot] = listP[slot - 1];
                }
                listP[slot] = current;
            }

            Displaying<T>.Display(listP);
            Console.WriteLine("Count = {0}", swapOperations);
        }
    // Done with insertion Algorithm

    // Helper methods for Heapsort
    private static void Swap(List<T> listP, int lhs, int rhs)
    {
        T temp = listP[lhs];
        listP[lhs] = listP[rhs];
        listP[rhs] = temp;
    }

    private static int LeftChild(int i)
    {
        return 2 * i + 1;
    }
    // Done with helper methods for Heapsort

    // Heapsort Algorithm
    public static void Heapsort(List<T> listP)
    {
        Console.WriteLine(" --- Starting HeapSort ----");
        Heapsort(listP, listP.Count);
    }

    private static void Heapsort(List<T> listP, int N)
    {
        Displaying<T>.DisplayHeader(listP, 0, listP.Count);
        Displaying<T>.Display(listP);

        for (int i = N / 2; i >= 0; i--) /* BuildHeap */
            PercDown(listP, i, N);
        Console.WriteLine("-- Max Heap is built --");
        Displaying<T>.Display(listP);
        for (int i = N - 1; i > 0; i--)
        {
            Swap(listP, 0, i); /* DeleteMax */
            PercDown(listP, 0, i);
            Displaying<T>.Display(listP);
        }
    }

    private static void PercDown(List<T> listP, int i, int N)
    {
        int Child;
        T current;

        for (current = listP[i]; LeftChild(i) < N; i = Child)
        {
            Child = LeftChild(i);
            if (Child != N - 1 && listP[Child].CompareTo(listP[Child + 1]) < 0)
                Child++;
            if (current.CompareTo(listP[Child]) < 0) // current < listP[child]
                listP[i] = listP[Child];
            else
                // if current >= listP[child] we *do not* 
                // swap: we are constructing a *max* heap!
                break;
        }
        listP[i] = current;
    }

    // Done with heapsort Algorithm





    // ================================================================================
    //
    //    Bubble Algorithm
    //
    // ================================================================================
    public static void BubbleSort(List<T> listP)
        {
            int count = 0;
            Console.WriteLine("----------- Bubble Sort --- Green - bubbled to correct spot starting at end");
            Displaying<T>.DisplayHeader(listP, 0, listP.Count);
            Displaying<T>.Display(listP);

            for (int i = listP.Count - 1; i >= 0; i--)
            {
                for (int j = 0; j < listP.Count - 1; j++)
                {
                    if (listP[j].CompareTo(listP[j + 1]) > 0)
                        Swap(listP, j, j + 1);
                    count++;
                }
                Displaying<T>.DisplayOne(listP, i, 0, i + 1);
            }

            Displaying<T>.Display(listP);
            Console.WriteLine("Count = {0}", count);
        }

        // ================================================================================
        //
        //    ShellSort Algorithm
        //
        // ================================================================================        public static void ShellSort(List<T> listP)
        public static void ShellSort(List<T> listP)
        {
            int swapNum = 0;
            Console.WriteLine();
            Console.Write("      ");
            Displaying<T>.DisplayHeader(listP, 0, listP.Count);

            int slot;
            T tmp;
            for (int gap = listP.Count / 3 + 1; gap > 0; gap /= 2)                  // determines increment sequence
            {
                Console.Write("{0}     ", gap);
                Displaying<T>.Display2(listP, 0, listP.Count);
                for (int next = gap; next < listP.Count; next++)
                {              // goes thru array by steps
                    tmp = listP[next];
                    for (slot = next; slot >= gap && tmp.CompareTo(listP[slot - gap]) < 0; slot -= gap) // slides tmp until in place
                    {
                    ++swapNum;
                        listP[slot] = listP[slot - gap];

                    }
                    listP[slot] = tmp;
                }
            }
            Console.WriteLine("Count = {0}", swapNum);
        }

        // gaps must be sorted larger to smaller
        public static void ShellSort(List<T> listP, int[] gaps)
        {
            Console.Write("---- ShellSort -----");
            T tmp;
            int slot;
            int count = 0;
            Console.WriteLine();
            Console.Write("      ");
            Displaying<T>.DisplayHeader(listP, 0, listP.Count);
            Console.Write("      ");
            Displaying<T>.Display(listP);
            foreach (int gap in gaps)                  // determines increment sequence
            {
                Console.Write("{0}     ", gap);
                for (int next = gap; next < listP.Count; next++)
                {              // goes thru array by steps
                    tmp = listP[next];
                    for (slot = next; slot >= gap && tmp.CompareTo(listP[slot - gap]) < 0; slot -= gap) // slides tmp until in place
                    {
                        ++count;
                        listP[slot] = listP[slot - gap];

                    }
                    listP[slot] = tmp;
                }
                Displaying<T>.DisplayEvery(listP, 0, listP.Count, gap);
            }
            Console.WriteLine("Number of shifts = {0}", count);
        }

        public static void ShellSort(List<T> listP, List<int> IncrementList)
        {
            T tmp;
            int slot;
            int count = 0;

            Console.Write("      ");
            Displaying<T>.DisplayHeader(listP, 0, listP.Count);
            Console.Write("      ");
            Displaying<T>.Display2(listP, 0, listP.Count);

            for (int incNumber = IncrementList.Count - 1; incNumber >= 0; incNumber--)
            {
                int gap = IncrementList[incNumber];

                for (int next = gap; next < listP.Count; next++)
                {              // goes thru array by steps
                    tmp = listP[next];
                    for (slot = next; slot >= gap && tmp.CompareTo(listP[slot - gap]) < 0; slot -= gap) // slides tmp until in place
                    {
                        ++count;
                        listP[slot] = listP[slot - gap];
                    }
                    listP[slot] = tmp;
                    //                    Console.WriteLine("Count = {0}", count);
                }
                Console.Write("{0,3}   ", gap);
                Displaying<T>.Display2(listP, 0, listP.Count);
            }
            Console.WriteLine("Count = {0}", count);
        }

  

        // ================================================================================
        //
        //    QuickSort Algorithm
        //
        // ================================================================================
        public static void QuickSort(List<T> listP, int stopOn = 3)
        {
            Console.WriteLine("-------- QuickSort ---------");

            QuickSort(listP, 0, listP.Count - 1, stopOn);
            Console.WriteLine("After QuickSort but before it calls InsertionSort");
            Displaying<T>.Display(listP);
            Console.WriteLine();
            InsertionSort(listP);
        }

        private static T median3(List<T> listP, int left, int right)
        {
            Console.Write("\tIn median3: {0}  {1}  {2}", listP[left], listP[(left + right) / 2], listP[right]);
            int center = (left + right) / 2;
            if (listP[center].CompareTo(listP[left]) < 0)
                Swap(listP, left, center);
            if (listP[right].CompareTo(listP[left]) < 0)
                Swap(listP, left, right);
            if (listP[right].CompareTo(listP[center]) < 0)
                Swap(listP, center, right);

            Swap(listP, center, right);
            return listP[right];
        }


        public static void QuickSort(List<T> listP, int left, int right, int stopOn)
        {
            if (Math.Abs(left - right) < stopOn)
                return;
            else
            {
                Console.Write("QuickSort({");
                for (int j = left; j <= right; j++)
                {
                    Console.Write("{0}", listP[j]);
                    if (j != right)
                        Console.Write(", ");
                }
                Console.Write("}");
                Console.WriteLine(", {0}, {1})", left, right);


                Console.WriteLine();
                T pivot = median3(listP, left, right);
                Console.Write("{0}", new String(' ', left * 4));
                Displaying<T>.Display2(listP, left, right + 1);
                int i = left; //, j = right;
                for (int j = right; i < j;)
                {
                    while (listP[++i].CompareTo(pivot) < 0) ;
                    while (pivot.CompareTo(listP[--j]) < 0) ;
                    if (i < j)
                        Swap(listP, i, j);
                    else
                        break;
                }
                Swap(listP, i, right);  // Move pivot back
                Console.Write("{0}", new String(' ', left * 4));
                Displaying<T>.Display3(listP, left, right + 1, i);

                QuickSort(listP, left, i - 1, stopOn);  // sort small partition
                QuickSort(listP, i + 1, right, stopOn); // sort large partition
            }
        }

        // ================================================================================
        //
        //    Selection Sort Algorithm
        //
        // ================================================================================
        public static void SelectionSort(List<T> listP)
        {
            SelectionSort(listP, 0, listP.Count - 1);
        }

        private static void SelectionSort(List<T> listP, int low, int high)
        {
            T temp;
            for (int i = low; i <= high; ++i)
            {
                T min = listP[i];       // smallest element so far
                int min_index = i;      // index of smallest

                for (int j = i + 1; j <= high; ++j)
                    if (listP[j].CompareTo(min) < 0)
                    {
                        min = listP[j];
                        min_index = j;
                    }

                if (i != min_index)
                {
                    temp = listP[i];
                    listP[i] = min;
                    listP[min_index] = temp;
                }
            }
        }



        // ================================================================================
        //
        //    Merge Sort Algorithm
        //
        // ================================================================================
        public static void RecMergeSort(List<T> listP)
        {
            RecMergeSort(listP, 0, listP.Count);
        }

        private static void RecMergeSort(List<T> array, int start, int end)
        {
            if (end - start <= 1) return;
            int middle = start + (end - start) / 2;

            RecMergeSort(array, start, middle);
            RecMergeSort(array, middle, end);
            Merge(array, start, middle, end);
        }

        public static void MergeSort(List<T> listP)
        {
            Displaying<T>.Display(listP);
            for (int i = 1; i <= listP.Count / 2 + 1; i *= 2)
                for (int j = i; j < listP.Count; j += 2 * i)
                    Merge(listP, j - i, j, Math.Min(j + i, listP.Count));
        }

        private static void Merge(List<T> listP, int start, int middle, int end)
        {
            List<T> merge = new List<T>(end - start); //T[end-start];
            for (int j = 0; j < end - start; ++j)
                merge.Add(default(T));
            int l = 0, r = 0, i = 0;
            while (l < (middle - start) && r < (end - middle))
            {
                if (listP[start + l].CompareTo(listP[middle + r]) < 0)
                    merge[i++] = listP[start + l++];
                else
                    merge[i++] = listP[middle + r++];
            }

            while (r < end - middle)
                merge[i++] = listP[middle + r++];

            while (l < middle - start)
                merge[i++] = listP[start + l++];

            for (int k = 0; k < merge.Count; k++)
                listP[start++] = merge[k];
        }
    }
