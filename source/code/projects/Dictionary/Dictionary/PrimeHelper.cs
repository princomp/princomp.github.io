/*
 * Why prime numbers are needed is explained for example
 * at
 * https://cs.stackexchange.com/questions/11029
 */

public static class PrimeHelper
{
  public static bool IsPrime(int n)
  {
    // "A prime number is a natural number greater than 1 that is not a product of two smaller natural numbers."
    // https://en.wikipedia.org/wiki/Prime_number
    if (n < 2)
      return false;
    if (n == 2 || n == 3)
      return true;
    if (n % 2 == 0)
      return false;
    for (int i = 3; i * i <= n; i += 2)
      if (n % i == 0)
        return false;
    return true;
  }

  public static int NextPrime(int n)
  {
    if (n < 2)
    {
      n = 2;
    }
    else
    {
      // Since 2 is the only even prime,
      // we make the n even if it is divisible
      // by 2.
      if (n % 2 == 0)
        n++;

      while (!IsPrime(n))
      {
        n += 2;
      }
    }
    return n;
  }
}
