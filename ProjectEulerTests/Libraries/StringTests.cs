using Project_Euler.Libraries;
using Xunit;

namespace ProjectEulerTests.Libraries
{
    public class StringTests
    {
        [Fact]
        public void IsPallindrome()
        {
            Assert.True(String.IsPallindrome("9009"));
            Assert.True(String.IsPallindrome("090090"));
        }

        [Fact]
        public void IsNotPallindrome()
        {
            Assert.False(String.IsPallindrome("90sdfs09"));
        }
    }
}