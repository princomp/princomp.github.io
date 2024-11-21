/* 
 * This class uses the generic interface,
 * https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-interfaces
 * The generic T must be instantiated.
 * This code is actually very close to the one used by C#, 
 * cf.
 * https://learn.microsoft.com/en-us/dotnet/api/system.icomparable-1.compareto?view=net-9.0
 */
public interface IComparable<T>
{
  int CompareTo(T arg);
  /* Compares the calling object with
   * the object passed as an argument.
   * Returns a negative integer, zero, or a positive
   * integer as the calling object is less than,
   * equal to, or greater
   * than the specified object.*/
}
