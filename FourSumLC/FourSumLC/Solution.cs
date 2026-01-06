[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("FourSumLCTests")]

namespace FourSumLC
{
    internal class Solution
    {
        /// <summary>
        /// Finds all unique quadruplets in the specified array that sum to the given target value.
        /// </summary>
        /// <remarks>Each quadruplet in the result is unique; duplicate combinations are not included. The
        /// order of quadruplets and their elements is not guaranteed.</remarks>
        /// <param name="nums">An array of integers to search for quadruplets. The array may contain duplicate values.</param>
        /// <param name="target">The target sum for the quadruplets.</param>
        /// <returns>A list of lists, where each inner list contains four integers representing a unique quadruplet whose sum
        /// equals the target. If no quadruplets are found, the list is empty.</returns>
        internal static IList<IList<int>> FourSum(int[] nums, int target)
        {
            Array.Sort(nums);
            long targetLong = (long)target;
            IList<IList<int>> result = [];
            int n = nums.Length;
            for (int i = 0; i < n - 3; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                for (int j = i + 1; j < n - 2; j++)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1])
                    {
                        continue;
                    }
                    int left = j + 1;
                    int right = n - 1;
                    while (left < right)
                    {
                        long sum = (long)nums[i] + nums[j] + nums[left] + nums[right];
                        if (sum == targetLong)
                        {
                            result.Add([nums[i], nums[j], nums[left], nums[right]]);
                            while (left < right && nums[left] == nums[left + 1])
                            {
                                left++;
                            }
                            while (left < right && nums[right] == nums[right - 1])
                            {
                                right--;
                            }
                            left++;
                            right--;
                        }
                        else if (sum < targetLong)
                        {
                            left++;
                        }
                        else
                        {
                            right--;
                        }
                    }
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("KonradL LeetCode 4Sum + Appropriate Tests");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Two Pointer Approach, modified 3Sum");
            Console.WriteLine("Time complexity: O(n^3)");
            Console.WriteLine("Space complexity: O(1)");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"https://leetcode.com/problems/4sum/");
            Console.ResetColor();
        }
    }
}
