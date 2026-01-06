using static ParenthesesValid.Solution;

namespace ParenthesesValidTests
{
    public class ValidParenthesesTests
    {
        [Fact]
        public void Test1()
        {
            string input = "()";
            bool result = IsValid(input);
            Assert.True(result);
        }

        [Fact]
        public void Test2()
        {
            string input = "()[]{}";
            bool result = IsValid(input);
            Assert.True(result);
        }

        [Fact]
        public void Test3()
        {
            string input = "(]";
            bool result = IsValid(input);
            Assert.False(result);
        }

        [Fact]
        public void Test4()
        {
            string input = "([)]";
            bool result = IsValid(input);
            Assert.False(result);
        }

        [Fact]
        public void Test5()
        {
            string input = "{[]}";
            bool result = IsValid(input);
            Assert.True(result);
        }

        [Fact]
        public void Test6()
        {
            string input = "";
            bool result = IsValid(input);
            Assert.True(result);
        }

        [Fact]
        public void Test7()
        {
            string input = "((()))";
            bool result = IsValid(input);
            Assert.True(result);
        }

        [Fact]
        public void Test8()
        {
            string input = "((())";
            bool result = IsValid(input);
            Assert.False(result);
        }
    }
}
