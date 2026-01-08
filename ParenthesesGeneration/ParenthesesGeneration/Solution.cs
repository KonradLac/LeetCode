[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("ParenthesesGenerationTests")]

namespace ParenthesesGeneration
{
    internal class Solution
    {
        /// <summary>
        /// Generates all valid combinations of parentheses for a given number of pairs and adds them to the specified
        /// result list.
        /// </summary>
        /// <remarks>This method is intended for internal recursive use and builds up valid combinations
        /// by tracking the number of open parentheses and the current string. The results are accumulated in the
        /// provided list. The method does not return a value; all output is added to <paramref name="res"/>.</remarks>
        /// <param name="n">The total number of pairs of parentheses to generate. Must be greater than zero.</param>
        /// <param name="open">The current number of open parentheses used in the combination. Should not exceed <paramref name="n"/>.</param>
        /// <param name="curr">The current string representing the partial combination of parentheses being built.</param>
        /// <param name="res">The list that will be populated with all valid combinations of parentheses as strings.</param>
        internal static void ValidParentheses(int n, int open, string curr, List<string> res)
        {
            if (n == 0)
            {
                return;
            }
            if (curr.Length == n * 2)
            {
                res.Add(curr);
                return;
            }
            if (open < n)
            {
                ValidParentheses(n, open + 1, curr + "(", res);
            }
            if (curr.Length - open < open)
            {
                ValidParentheses(n, open, curr + ")", res);
            }
        }

        /// <summary>
        /// Generates all combinations of well-formed parentheses for the specified number of pairs.
        /// </summary>
        /// <param name="n">The number of pairs of parentheses to generate. Must be non-negative.</param>
        /// <returns>A list of strings, each representing a unique combination of well-formed parentheses. Returns an empty list
        /// if <paramref name="n"/> is zero.</returns>
        internal static IList<string> GenerateParenthesis(int n)
        {
            List<string> res = [];
            ValidParentheses(n, 0, "", res);
            return res;
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("KonradL LeetCode Generate Valid Parentheses + Appropriate Tests");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Time complexity: O(n)");
            Console.WriteLine("Space complexity: O(min(m,n)) where n is the length of the string and m is the size of the charset");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"https://leetcode.com/problems/generate-parentheses/");
            Console.ResetColor();
        }
    }
}
