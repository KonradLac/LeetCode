using static ContainerWithMostWater.Solution;

namespace MostWaterTests
{
    public class ContainerWaterTests
    {
        [Fact]
        public void Test1()
        {
            int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int expected = 49;
            int actual = MaxArea(height);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            int[] height = { 1, 1 };
            int expected = 1;
            int actual = MaxArea(height);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3() 
        {
            int[] height = { 1, 2, 1 };
            int expected = 2;
            int actual = MaxArea(height);
            Assert.Equal(expected, actual);
        }
    }
}
