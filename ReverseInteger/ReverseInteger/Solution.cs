using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ReverseIntegerTests")]

namespace ReverseInteger
{
    internal class Solution
    {
        /// <summary>
        /// Reverses the digits of a 32-bit signed integer.
        /// </summary>
        /// <remarks>If reversing the digits causes the value to exceed the range of a 32-bit signed
        /// integer, the method returns 0.</remarks>
        /// <param name="x">The integer value to reverse.</param>
        /// <returns>The reversed integer if the result is within the range of a 32-bit signed integer; otherwise, 0.</returns>
        internal static int Reverse(int x)
        {
            if(x == 0 || x > int.MaxValue || x < int.MinValue)
            {
                return 0;
            }
            int result = default;
            while (x != 0)
            {

                int pop = x % 10;
                x /= 10;
                // Check for overflow/underflow before actually adding the digit
                if ((result > int.MaxValue / 10 || result < int.MinValue / 10))
                {
                    return 0;
                }
                result = result * 10 + pop;
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("KonradL LeetCode Reverse Integer + Appropriate Tests");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Time complexity: O(log (n))");
            Console.WriteLine("Space complexity: O(1)");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("https://leetcode.com/problems/reverse-integer/");
        }
    }
}
