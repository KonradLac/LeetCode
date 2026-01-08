using static ParenthesesGeneration.Solution;

namespace ParenthesesGenerationTests
{
    public class ParenthesesValidTests
    {
        [Fact]
        public void Test1()
        {
            int n = 3;
            IList<string> expected = new List<string> { "((()))", "(()())", "(())()", "()(())", "()()()" };
            IList<string> result = GenerateParenthesis(n);
            Assert.Equal(expected.OrderBy(x => x), result.OrderBy(x => x));
        }

        [Fact]
        public void Test2()
        {
            int n = 1;
            IList<string> expected = new List<string> { "()" };
            IList<string> result = GenerateParenthesis(n);
            Assert.Equal(expected.OrderBy(x => x), result.OrderBy(x => x));
        }

        [Fact]
        public void Test3()
        {
            int n = 2;
            IList<string> expected = new List<string> { "(())", "()()" };
            IList<string> result = GenerateParenthesis(n);
            Assert.Equal(expected.OrderBy(x => x), result.OrderBy(x => x));
        }
    }
}
