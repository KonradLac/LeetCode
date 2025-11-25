using StringToInteger;

namespace StringToIntegerTests
{
    public class AtoiTests
    {
        [Fact]
        public void StandardTest()
        {
            string input = "42";
            int expected = 42;
            int result = Solution.MyAtoi(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void LeadingWhiteSpacesAndNegative()
        {
            string input = "   -42";
            int expected = -42;
            int result = Solution.MyAtoi(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void WordsAfterANumber()
        {
            string input = "4193 with words";
            int expected = 4193;
            int result = Solution.MyAtoi(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void WordsBeforeANumber()
        {
            string input = "words and 987";
            int expected = 0;
            int result = Solution.MyAtoi(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void UnderflowMinValue()
        {
            string input = "-91283472332";
            int expected = int.MinValue;
            int result = Solution.MyAtoi(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void LeadingZeros()
        {
            string input = "0032";
            int expected = 32;
            int result = Solution.MyAtoi(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void LeadingPlusSign()
        {
            string input = "+1";
            int expected = 1;
            int result = Solution.MyAtoi(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void LeadingWhiteSingsAndThenPlusSign()
        {
            string input = "   +0 123";
            int expected = 0;
            int result = Solution.MyAtoi(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void NegativeLeadingZeros()
        {
            string input = "-000000000000001";
            int expected = -1;
            int result = Solution.MyAtoi(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void OverflowMaxValue()
        {
            string input = "2147483648";
            int expected = int.MaxValue;
            int result = Solution.MyAtoi(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void OnlyPlusSign()
        {
            string input = "+";
            int expected = 0;
            int result = Solution.MyAtoi(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void OnlyMinusSign()
        {
            string input = "-";
            int expected = 0;
            int result = Solution.MyAtoi(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void SuperBigNumber()
        {
            string input = "20000000000000000000";
            int expected = int.MaxValue;
            int result = Solution.MyAtoi(input);
            Assert.Equal(expected, result);
        }
    }
}
