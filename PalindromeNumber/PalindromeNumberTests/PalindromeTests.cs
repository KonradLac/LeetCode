using static PalindromeNumber.Solution;

namespace PalindromeNumberTests
{
    public class PalindromeTests
    {
        [Fact]
        public void Test1()
        {
            int input = 121;
            bool result = IsPalindrome(input);
            Assert.True(result);
        }

        [Fact]
        public void Test2()
        {
            int input = -121;
            bool result = IsPalindrome(input);
            Assert.False(result);
        }

        [Fact]
        public void Test3()
        {
            int input = 10;
            bool result = IsPalindrome(input);
            Assert.False(result);
        }

        [Fact]
        public void Test4()
        {
            int input = -101;
            bool result = IsPalindrome(input);
            Assert.False(result);
        }

        [Fact]
        public void Test5()
        {
            int input = 12321;
            bool result = IsPalindrome(input);
            Assert.True(result);
        }

        [Fact]
        public void Test6()
        {
            int input = 0;
            bool result = IsPalindrome(input);
            Assert.True(result);
        }
    }
}
