using ZigzagConversion;

namespace ZigzagConversionTests
{
    public class ConvertZigzagTests
    {
        [Fact]
        public void Test1()
        {
            string input = "PAYPALISHIRING";
            int numRows = 3;
            string expected = "PAHNAPLSIIGYIR";
            string actual = Solution.Convert(input, numRows);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            string input = "PAYPALISHIRING";
            int numRows = 4;
            string expected = "PINALSIGYAHRPI";
            string actual = Solution.Convert(input, numRows);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            string input = "A";
            int numRows = 1;
            string expected = "A";
            string actual = Solution.Convert(input, numRows);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test4()
        {
            string input = "ABCD";
            int numRows = 2;
            string expected = "ACBD";
            string actual = Solution.Convert(input, numRows);
            Assert.Equal(expected, actual);
        }
    }
}
