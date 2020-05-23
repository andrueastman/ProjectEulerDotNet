using System.Linq;

namespace Project_Euler
{
    public class Problem3 : Problem
    {
        private const long Number = 600851475143;

        public override string Answer()
        {
            var primeFactors = Math.PrimeFactors(Number);
            return $"{primeFactors.Last()}";
        }
    }
}