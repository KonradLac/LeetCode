using static LongestSubstring.Solution;

namespace LongestSubstringTests
{
    public class LengthOfLongestSubstringTests
    {
        [Fact]
        public void Test1()
        {
            string testInput = "abcabcbb";
            int expectedOutput = 3;
            int actualOutput = LengthOfLongestSubstring(testInput);
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void Test2()
        {
            string testInput = "bbbbb";
            int expectedOutput = 1;
            int actualOutput = LengthOfLongestSubstring(testInput);
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void Test3()
        {
            string testInput = "pwwkew";
            int expectedOutput = 3;
            int actualOutput = LengthOfLongestSubstring(testInput);
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void Test4()
        {
            string testInput = "";
            int expectedOutput = 0;
            int actualOutput = LengthOfLongestSubstring(testInput);
            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}
