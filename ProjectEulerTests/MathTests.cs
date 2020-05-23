using System.Collections.Generic;
using System.Linq;
using Project_Euler;
using Xunit;

namespace ProjectEulerTests
{
    public class MathTests
    {
        [Fact]
        public void TestPrimeFactors()
        {
            List<long> primeFactors = Math.PrimeFactors(13195).ToList();

            Assert.Equal(4,primeFactors.Count);
            Assert.Equal(5,primeFactors[0]);
            Assert.Equal(7,primeFactors[1]);
            Assert.Equal(13,primeFactors[2]);
            Assert.Equal(29,primeFactors[3]);


        }
    }
}
