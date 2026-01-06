using static ReverseInteger.Solution;

namespace ReverseIntegerTests
{
    public class ReversingIntegerTests
    {
        [Fact]
        public void StandardTest1()
        {
            int input = 123;
            int expected = 321;
            int actual = Reverse(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StandardTest2()
        {
            int input = -123;
            int expected = -321;
            int actual = Reverse(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StandardTest3()
        {
            int input = 146384;
            int expected = 483641;
            int actual = Reverse(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ZeroEndingTestCase()
        {
            int input = 120;
            int expected = 21;
            int actual = Reverse(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void OnlyZeroTestCase()
        {
            int input = 0;
            int expected = 0;
            int actual = Reverse(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void OverflowTestCase()
        {
            int input = 1534236469;
            int expected = 0; // Overflow case
            int actual = Reverse(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UnderflowTestCase()
        {
            int input = -2147483648;
            int expected = 0; // Underflow case
            int actual = Reverse(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MinValueOfIntTestCase()
        {
            int input = -1463847412;
            int expected = -2147483641;
            int actual = Reverse(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReverseTwiceTestCase()
        {
            int input = 17827;
            int actual = input;
            int temp = Reverse(input);
            int expected = Reverse(temp); // Double reversal should yield original
            Assert.Equal(expected, actual);
        }
    }
}
