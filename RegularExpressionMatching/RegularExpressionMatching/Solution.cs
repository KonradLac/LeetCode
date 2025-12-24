using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("RegularExpressionMatchingTests")]

namespace RegularExpressionMatching
{
    internal class Solution
    {
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
            Console.WriteLine("KonradL LeetCode Regulary Expression Matching + Appropriate Tests");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Dynamic Programming");
            Console.WriteLine("Time complexity: O(m x n)");
            Console.WriteLine("Space complexity: O(m x n)");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"https://leetcode.com/problems/regular-expression-matching");
            Console.ResetColor();
        }
    }
}
