public static class PrimeHelper
{
    public static bool IsPrime(int n)
    {
        bool returned = true;
        if (n < 2)
            returned = false;
        if (n == 2 || n == 3)
            returned = true;
        if (n % 2 == 0)
            returned = false;
        // We use uint so that we can compute larger primes, since 
        // we know that i will not need to be negative.
        uint i = 3;

        /* 
         * Our goal is to find i > 1 and j > 1 such that
         * i * j = n
         * to prove that n is not prime.
         * Assuming i <= j, it suffices to look "up to" i * i <= n (i.e, so that i is less than √n).
         * We also exit our loop as soon as returned is proved false.        
         */

        while (i * i <= n && returned)
        {
            if (n % i == 0)
                returned = false;
            i += 2;
        }
        return returned;
    }

    public static int NextPrime(int n)
    {
        int returned = n;
        if (returned <= 2)
        {
            // The smallest prime greater than or equal to 2
            // is … 2!
            returned = 2;
        }
        else
        {
            // Since 2 is the only even prime,
            // we make the returned value even 
            // if it is divisible by 2.
            if (returned % 2 == 0)
                returned++;

            // Then, we simply look for the next Prime value,
            // incrementing two by two.
            while (!IsPrime(returned))
            {
                returned += 2;
            }
        }
        return returned;
    }
}
