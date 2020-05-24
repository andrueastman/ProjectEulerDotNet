namespace Project_Euler.Libraries
{
    public class Math
    {
        /// <summary>
        ///     The nth Fibonacci number
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static long Fibonacci(int n)
        {
            if (n < 2)
                return 1;

            return Fibonacci(n - 2) + Fibonacci(n - 1);
        }

        public static bool IsPrime(long n)
        {
            if (n < 1)
                return false; // TODO fixme

            if (n == 1)
                return false;

            if (n == 2 || n == 3 || n == 5)
                return true;

            if (n % 2 == 0 || n % 3 == 0 || n % 5 == 0)
                return false;

            // just test odd numbers. 
            // TODO possible optimization?
            for (var i = 7; i * i <= n; i += 2)
                if (n % i == 0)
                    return false;

            return true;
        }

        public static List<long> Factors(long n)
        {
            var factors = new List<long>();
            for (var i = 1; i <= n; i++)
                if (n % i == 0)
                {
                    factors.Add(i);
                    n /= i;
                }

            return factors;
        }

        public static List<long> PrimeFactors(long n)
        {
            return Factors(n).Where(IsPrime);
        }
    }
}