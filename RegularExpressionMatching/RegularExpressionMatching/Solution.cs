[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("RegularExpressionMatchingTests")]

namespace RegularExpressionMatching
{
    internal class Solution
    {
        /// <summary>
        /// Determines whether the specified input string matches the given pattern, where the pattern may include '.'
        /// to match any single character and '*' to match zero or more of the preceding element.
        /// </summary>
        /// <remarks>The pattern supports two special characters: '.' matches any single character, and
        /// '*' matches zero or more occurrences of the preceding character. This method performs a full match of the
        /// input string against the pattern; partial matches are not considered.</remarks>
        /// <param name="s">The input string to test against the pattern. Cannot be null.</param>
        /// <param name="p">The pattern string, which may contain '.' and '*' as special characters. Cannot be null.</param>
        /// <returns>True if the input string matches the pattern; otherwise, false.</returns>
        internal static bool IsMatch(string s, string p)
        {
            bool[,] truthMatrix = new bool[s.Length + 1, p.Length + 1];
            truthMatrix[0, 0] = true;
            for (int j = 1; j <= p.Length; j++)
            {
                if (p[j - 1] == '*')
                {
                    truthMatrix[0, j] = truthMatrix[0, j - 2];
                }
            }
            for (int i = 1; i <= s.Length; i++)
            {
                for (int j = 1; j <= p.Length; j++)
                {
                    if (p[j - 1] == '.' || p[j - 1] == s[i - 1])
                    {
                        truthMatrix[i, j] = truthMatrix[i - 1, j - 1];
                    }
                    else if (p[j - 1] == '*')
                    {
                        truthMatrix[i, j] = truthMatrix[i, j - 2];
                        if (p[j - 2] == '.' || p[j - 2] == s[i - 1])
                        {
                            truthMatrix[i, j] = truthMatrix[i, j] || truthMatrix[i - 1, j];
                        }
                    }
                    else
                    {
                        truthMatrix[i, j] = false;
                    }
                }
            }
            return truthMatrix[s.Length, p.Length];
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("KonradL LeetCode Regular Expression Matching + Appropriate Tests");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Dynamic Programming");
            Console.WriteLine("Time complexity: O(m x n)");
            Console.WriteLine("Space complexity: O(m x n)");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"https://leetcode.com/problems/regular-expression-matching/");
            Console.ResetColor();
        }
    }
}
