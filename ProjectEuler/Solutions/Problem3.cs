namespace Project_Euler
{
    public class Problem3 : Problem
    {
        private const long Number = 600851475143;

        public override string Answer()
        {
            var primeFactors = Math.PrimeFactors(Number).ToArray();
            return $"{primeFactors[^1]}";
        }
    }
}