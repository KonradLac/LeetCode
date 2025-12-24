using static RegularExpressionMatching.Solution;

namespace RegularExpressionMatchingTests
{
    public class RegextMatchTests
    {
        [Fact]
        public void Test1()
        {
            string s = "aa";
            string p = "a";
            bool result = IsMatch(s, p);
            Assert.False(result);
        }

        [Fact]
        public void Test2()
        {
            string s = "aa";
            string p = "a*";
            bool result = IsMatch(s, p);
            Assert.True(result);
        }

        [Fact]
        public void Test3()
        {
            string s = "ab";
            string p = ".*";
            bool result = IsMatch(s, p);
            Assert.True(result);
        }

        [Fact]
        public void Test4()
        {
            string s = "aab";
            string p = "c*a*b";
            bool result = IsMatch(s, p);
            Assert.True(result);
        }
    }
}
