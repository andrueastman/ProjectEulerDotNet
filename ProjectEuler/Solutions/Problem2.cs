using Project_Euler.Libraries;

namespace Project_Euler.Solutions
{
    public class Problem2 : Problem
    {
        private const int Maximum = 4000000;

        public override string Answer()
        {
            var term = 1;
            long total = 0;
            long fibonacciTerm = 1;

            do
            {
                if (fibonacciTerm % 2 == 0) total += fibonacciTerm;

                term++;
                fibonacciTerm = Math.Fibonacci(term);
            } while (fibonacciTerm < Maximum);

            return $"{total}";
        }
    }
}