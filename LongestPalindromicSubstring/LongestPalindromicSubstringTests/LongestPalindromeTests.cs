using LongestPalindromicSubstring;

namespace LongestPalindromicSubstringTests
{
    public class LongestPalindromeTests
    {
        [Fact]
        public void Test1()
        {
            string input = "babad";
            string expected1 = "bab";
            string expected2 = "aba";
            string result = Solution.LongestPalindrome(input);
            Assert.Equal(expected1, result);
        }

        [Fact]
        public void Test2()
        {
            string input = "cbbd";
            string expected = "bb";
            string result = Solution.LongestPalindrome(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test3()
        {
            string input = "a";
            string expected = "a";
            string result = Solution.LongestPalindrome(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test4()
        {
            string input = "aacabdkacaa";
            string expected1 = "aca";
            string result = Solution.LongestPalindrome(input);
            Assert.Equal(expected1, result);
        }
    }
}
