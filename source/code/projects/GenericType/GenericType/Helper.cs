public class Helper
{
  // A generic way of reversing an array.
  public static T[] Reverse<T>(T[] arrayP)
  {
    T[] result = new T[arrayP.Length];
    int j = 0;
    for (int i = arrayP.Length - 1; i >= 0; i--)
    {
      result[j] = arrayP[i];
      j++;
    }
    return result;
  }

  // A generic way of describing an array.

  public static string Description<T>(T[] arrayP)
  {
    string returned = "";
    foreach (var element in arrayP)
    {
      returned += element + " ";
    }
    return returned;
  }
  // Done.
}
