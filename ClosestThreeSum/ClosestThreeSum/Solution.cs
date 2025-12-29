[assembly:System.Runtime.CompilerServices.InternalsVisibleTo("ClosestThreeSumTests")]

namespace ClosestThreeSum
{
    internal class Solution
    {
        /// <summary>
        /// Finds the sum of three integers in the array that is closest to the specified target value.</summary>
        /// <remarks>If multiple sums are equally close to the target, the first one found is returned. The input array is modified by sorting it in place.</remarks>
        /// <param name="nums">An array of integers to search for the three numbers whose sum is closest to the target. Must contain at least three elements.</param>
        /// <param name="target">The target sum to approach as closely as possible.</param>
        /// <returns>The sum of the three integers in the array whose total is closest to the target value.</returns>
        internal static int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int closestSum = nums[0] + nums[1] + nums[2];
            for (int i = 0; i < nums.Length - 2; i++)
            {
                int left = i + 1;
                int right = nums.Length - 1;
                while (left < right)
                {
                    int currentSum = nums[i] + nums[left] + nums[right];
                    if (Math.Abs(currentSum - target) < Math.Abs(closestSum - target))
                    {
                        closestSum = currentSum;
                    }
                    if (currentSum < target)
                    {
                        left++;
                    }
                    else if (currentSum > target)
                    {
                        right--;
                    }
                    else
                    {
                        return currentSum;
                    }
                }
            }
            return closestSum;
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("KonradL Three Sum Closest + Appropriate Tests");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Two Pointer Approach");
            Console.WriteLine("Time Complexity: O(n^2)");
            Console.WriteLine("Space Complexity: O(1)");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"https://leetcode.com/problems/3sum-closest/");
            Console.ResetColor();
        }
    }
}
