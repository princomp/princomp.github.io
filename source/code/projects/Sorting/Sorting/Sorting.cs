using System;
using System.Collections.Generic;

static class Sorting<T>
  where T : IComparable<T>
{
    // Helper methods
    private static void Swap(List<T> listP, int lhs, int rhs)
    {
        T current = listP[lhs];
        listP[lhs] = listP[rhs];
        listP[rhs] = current;
    }

    public static bool IsSorted(List<T> listP)
    {
        bool isSorted = true;
        for (int i = 0; i < listP.Count - 1; i++)
        {
            if (listP[i].CompareTo(listP[i + 1]) > 0)
            {
                isSorted = false;
            }
        }
        return isSorted;
    }

    // Done with helpers method.

    // Insertion Algorithm
    public static void InsertionSort(List<T> listP)
    {
        T current;
        int slot;
        for (int bar = 1; bar < listP.Count; bar++)
        {
            current = listP[bar];
            for (
              slot = bar;
              slot > 0 && current.CompareTo(listP[slot - 1]) < 0;
              slot--
            )
            {
                listP[slot] = listP[slot - 1];
            }
            listP[slot] = current;
        }
    }

    // Done with insertion Algorithm

    // Helper method for Heapsort
    private static int LeftChild(int i)
    {
        return 2 * i + 1;
    }

    // Done with helper method for Heapsort

    // Heapsort algorithm
    public static void Heapsort(List<T> listP)
    {
        // Step 1: heapify, or build heap.
        for (int i = listP.Count / 2; i >= 0; i--)
            PercDown(listP, i, listP.Count);
        // Step 2: recursively extract the largest value.
        for (int i = listP.Count - 1; i > 0; i--)
        {
            Swap(listP, 0, i);
            PercDown(listP, 0, i);
        }
    }

    private static void PercDown(List<T> listP, int i, int N)
    {
        int Child;
        T current;
        for (current = listP[i]; LeftChild(i) < N; i = Child)
        {
            Child = LeftChild(i);
            if (
              Child != N - 1
              && listP[Child].CompareTo(listP[Child + 1]) < 0
            )
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

    // Done with heapsort algorithm

    // Bubble Algorithm
    public static void BubbleSort(List<T> listP)
    {
        for (int i = listP.Count - 1; i >= 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                if (listP[j].CompareTo(listP[j + 1]) > 0)
                    Swap(listP, j, j + 1);
            }
        }
    }

    // Done with bubble algorithm.

    // ShellSort Algorithm
    public static void ShellSort(List<T> listP)
    {
        int slot;
        T current;
        for (int gap = listP.Count / 3 + 1; gap > 0; gap /= 2)
        {
            for (int next = gap; next < listP.Count; next++)
            {
                // goes thru array by steps
                current = listP[next];
                for (
                  slot = next;
                  slot >= gap
                    && current.CompareTo(listP[slot - gap]) < 0;
                  slot -= gap
                )
                // slides current until in place
                {
                    listP[slot] = listP[slot - gap];
                }
                listP[slot] = current;
            }
        }
    }

    // Done with shellSort algorithm.

    // Selection Sort Algorithm
    public static void SelectionSort(List<T> listP)
    {
        SelectionSort(listP, 0, listP.Count - 1);
    }

    private static void SelectionSort(
      List<T> listP,
      int low,
      int high
    )
    {
        T current;
        for (int i = low; i <= high; ++i)
        {
            T min = listP[i]; // smallest element so far
            int min_index = i; // index of smallest

            for (int j = i + 1; j <= high; ++j)
                if (listP[j].CompareTo(min) < 0)
                {
                    min = listP[j];
                    min_index = j;
                }

            if (i != min_index)
            {
                current = listP[i];
                listP[i] = min;
                listP[min_index] = current;
            }
        }
    }

    // End of selection sort algorithm

    // Quick sort algorithm
    public static void QuickSort(
        List<T> listP
    )
    {
        QuickSort(listP, 0, listP.Count - 1, 3);
    }

    public static void QuickSort(
      List<T> listP,
      int leftP,
      int rightP,
      int stopOnP = 3
    )
    {
        int range = rightP - leftP + 1;
        // if range is larger than stopOn use insertion sort
        if (range >= stopOnP)
        {
            InsertionSort(listP);
        }
        else
        {
            T pivot = medianOfThree(listP, leftP, rightP);
            int i = leftP;
            int j = rightP;
            while(i < j)
            {
                // looking for value larger
                // than the pivot
                // on the left:
                while (listP[i].CompareTo(pivot) < 0) i++;
                // looking for value smaller
                // than the pivot
                // on the right.
                while (pivot.CompareTo(listP[j]) < 0) j--;

                if (i < j)
                    Swap(listP, i, j);
            }

            Swap(listP, i, rightP); // Move pivot back
            QuickSort(listP, leftP, i - 1, stopOnP); // sort small partition
            QuickSort(listP, i + 1, rightP, stopOnP); // sort large partition
        }
    }

    private static T medianOfThree(
      List<T> listP,
      int left,
      int right
    )
    {
        int center = (left + right) / 2;
        // We sort the left, center and right 
        // elements:
        if (listP[center].CompareTo(listP[left]) < 0)
            Swap(listP, left, center);
        if (listP[right].CompareTo(listP[left]) < 0)
            Swap(listP, left, right);
        if (listP[right].CompareTo(listP[center]) < 0)
            Swap(listP, center, right);

        // Move the pivot to the right:
        Swap(listP, center, right);
        return listP[right];
    }
    // End of quick Sort algorithm

}