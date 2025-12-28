using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("TwoSumTests")]

namespace TwoSum
{
    internal class Solution
    {
        /// <summary>
        /// Finds the indices of the two numbers that add up to the target.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        internal static int[] TwoSum(int[] nums, int target)
        {
            if (nums.Length < 2)
            {
                throw new ArgumentException("Array must contain at least two elements.");
            }
            else if (nums.Length == 2)
            {
                if (nums[0] + nums[1] == target)
                {
                    return [0, 1];
                }
                else
                {
                    throw new ArgumentException("No two sum solution exists.");
                }
            }
            else
            {
                Dictionary<int, int> map = [];
                for (int i = 0; i < nums.Length; i++)
                {
                    int complement = target - nums[i];
                    if (map.ContainsKey(complement))
                    {
                        return [map[complement], i];
                    }
                    map[nums[i]] = i;
                }
                throw new ArgumentException("No two sum solution exists.");
            }
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("KonradL LeetCode Two Sum + Aproppriate Tests");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Optimised Hash Map approach");
            Console.WriteLine("Time Complexity: O(n)");
            Console.WriteLine("Space Complexity: O(n)");
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine(@"https://leetcode.com/problems/two-sum/");
            Console.ResetColor();
        }
    }
}
