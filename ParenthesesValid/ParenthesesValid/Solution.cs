[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("ParenthesesValidTests")]

namespace ParenthesesValid
{
    internal class Solution
    {
        /// <summary>
        /// Determines whether the specified string contains valid and properly nested pairs of parentheses, brackets,
        /// and braces.
        /// </summary>
        /// <remarks>A string is considered valid if every opening parenthesis, bracket, or brace has a
        /// corresponding closing character in the correct order. Characters other than '()', '{}', and '[]' are
        /// ignored.</remarks>
        /// <param name="s">The string to validate for balanced and correctly ordered parentheses, brackets, and braces. Can be null or
        /// empty.</param>
        /// <returns>True if the string contains only properly matched and nested pairs of '()', '{}', and '[]'; otherwise,
        /// false.</returns>
        internal static bool IsValid(string s)
        {
            Stack<char> stack = new();
            Dictionary<char, char> parenthesesMap = new()
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' }
            };
            foreach (char c in s)
            {
                if (parenthesesMap.ContainsKey(c))
                {
                    stack.Push(c);
                }
                else if (parenthesesMap.ContainsValue(c))
                {
                    if (stack.Count == 0 || parenthesesMap[stack.Pop()] != c)
                    {
                        return false;
                    }
                }
            }
            if (stack.Count == 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Determines whether the specified string contains only properly nested and matched pairs of parentheses,
        /// brackets, and braces.
        /// </summary>
        /// <param name="s">The string to validate for balanced and correctly nested (), [], and {} pairs. Cannot be null.</param>
        /// <returns>True if the string contains only valid, balanced pairs of parentheses, brackets, and braces; otherwise,
        /// false.</returns>
        [Obsolete]
        internal static bool IsValidBeta(string s)
        {
            while(s.Contains("()") || s.Contains("[]") || s.Contains("{}"))
            {
                s = s.Replace("()", "").Replace("[]", "").Replace("{}", "");
            }
            return s.Length == 0;
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("KonradL LeetCode Valid Parentheses + Appropriate Tests");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Tries and errors");
            Console.WriteLine("Time Complexity: O(n)");
            Console.WriteLine("Space Complexity: O(n)");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"https://leetcode.com/problems/valid-parentheses/");
            Console.ResetColor();
        }
    }
}
