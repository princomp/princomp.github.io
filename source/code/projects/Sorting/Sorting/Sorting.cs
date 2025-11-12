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

  //  Merge Sort Algorithm
  public static void RecMergeSort(List<T> listP)
  {
    RecMergeSort(listP, 0, listP.Count);
  }

  private static void RecMergeSort(
    List<T> array,
    int start,
    int end
  )
  {
    if (end - start <= 1)
      return;
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

  private static void Merge(
    List<T> listP,
    int start,
    int middle,
    int end
  )
  {
    List<T> merge = new List<T>(end - start); //T[end-start];
    for (int j = 0; j < end - start; ++j)
      merge.Add(default(T));
    int l = 0,
      r = 0,
      i = 0;
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

  // QuickSort Algorithm
  public static void QuickSort(
    List<T> listP,
    int stopOn = 3
  )
  {
    QuickSort(listP, 0, listP.Count - 1, stopOn);
    Console.WriteLine(
      "After QuickSort but before it calls InsertionSort"
    );
    Displaying<T>.Display(listP);
    Console.WriteLine();
    InsertionSort(listP);
  }

  private static T median3(
    List<T> listP,
    int left,
    int right
  )
  {
    Console.Write(
      "\tIn median3: {0}  {1}  {2}",
      listP[left],
      listP[(left + right) / 2],
      listP[right]
    );
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

  public static void QuickSort(
    List<T> listP,
    int left,
    int right,
    int stopOn
  )
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
      for (int j = right; i < j; )
      {
        while (listP[++i].CompareTo(pivot) < 0)
          ;
        while (pivot.CompareTo(listP[--j]) < 0)
          ;
        if (i < j)
          Swap(listP, i, j);
        else
          break;
      }
      Swap(listP, i, right); // Move pivot back
      Console.Write("{0}", new String(' ', left * 4));
      Displaying<T>.Display3(listP, left, right + 1, i);

      QuickSort(listP, left, i - 1, stopOn); // sort small partition
      QuickSort(listP, i + 1, right, stopOn); // sort large partition
    }
  }
}
