using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("MostWaterTests")]

namespace ContainerWithMostWater
{
    internal class Solution
    {
        /// <summary>
        /// Calculates the maximum area of water that can be contained between two vertical lines represented by the
        /// input heights.
        /// </summary>
        /// <remarks>The area is determined by selecting two lines and calculating the product of the
        /// distance between them and the minimum of their heights. This method is commonly used to solve the 'Container
        /// With Most Water' problem.</remarks>
        /// <param name="height">An array of non-negative integers where each element represents the height of a vertical line. The array
        /// must contain at least two elements.</param>
        /// <returns>The maximum area of water that can be contained between any two lines. Returns 0 if the array contains fewer
        /// than two elements.</returns>
        internal static int MaxArea(int[] height)
        {
            int heightLength = height.Length;
            int result = default;
            for (int left = 0, right = heightLength - 1; left < right;)
            {
                int minHeight = Math.Min(height[left], height[right]);
                int width = right - left;
                result = Math.Max(result, minHeight * width);
                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("KonradL LeetCode Container With Most Water + Appropriate Tests");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Two Pointer Approach");
            Console.WriteLine("Time complexity: O(n)");
            Console.WriteLine("Space complexity: O(1)");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"https://leetcode.com/problems/container-with-most-water/");
            Console.ResetColor();
        }
    }
}
