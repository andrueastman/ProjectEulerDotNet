using Project_Euler;
using Xunit;

namespace ProjectEulerTests
{
    public class MathTests
    {
        [Fact]
        public void TestPrimeFactors()
        {
            var primeFactors = Math.PrimeFactors(13195).ToArray();

            Assert.Equal(4, primeFactors.Length);
            Assert.Equal(5, primeFactors[0]);
            Assert.Equal(7, primeFactors[1]);
            Assert.Equal(13, primeFactors[2]);
            Assert.Equal(29, primeFactors[3]);
        }
    }
}