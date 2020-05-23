using System;
using System.Collections.Generic;
using System.Linq;

namespace Project_Euler
{
    public class Math
    {
        /// <summary>
        /// The nth Fibonacci number
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
            if(n < 1)
                throw new ArgumentException("Number must be positive");

            if (n == 1)
                return false;
            
            if (n == 2 || n == 3|| n == 5)
                return false;

            if (n % 2 == 0 || n % 3 == 0 || n % 5 == 0)
                return false;

            // just test odd numbers. 
            // TODO possible optimization?
            for (var i = 7; i*i <= n; i+=2)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        public static IEnumerable<long> Factors(long n)
        {
            List<long> factors = new List<long>();
            for (var i = 1; i <= n; i ++)
            {
                if (n % i == 0)
                {
                    factors.Add(i);
                    n /= i;
                }
            }

            return factors;
        }

        public static IEnumerable<long> PrimeFactors(long n)
        {
            return Factors(n).Where(IsPrime);
        }
    }
}