using Project_Euler.Libraries;
using Xunit;

namespace ProjectEulerTests.Libraries
{
    public class ListTests
    {
        [Fact]
        public void CanAddToList()
        {
            var list = new List<int>();

            list.Add(1);
            list.Add(3);
            list.Add(5);
            list.Add(6);

            Assert.Equal(4, list.ToArray().Length);
            Assert.Equal(1, list.ToArray()[0]);
            Assert.Equal(3, list.ToArray()[1]);
            Assert.Equal(5, list.ToArray()[2]);
            Assert.Equal(6, list.ToArray()[3]);
        }

        [Fact]
        public void CanFilterList()
        {
            var list = new List<int>();

            list.Add(1);
            list.Add(3);
            list.Add(5);
            list.Add(6);

            list = list.Where(item => item > 2);

            Assert.Equal(3, list.ToArray().Length);
            Assert.Equal(3, list.ToArray()[0]);
            Assert.Equal(5, list.ToArray()[1]);
            Assert.Equal(6, list.ToArray()[2]);
        }
    }
}