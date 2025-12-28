[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("ThreeSumTests")]

namespace ThreeSumBody
{
    internal class Solution
    {
        /// <summary>
        /// Finds all unique triplets in the specified array that sum to zero.
        /// </summary>
        /// <remarks>Triplets are returned in no particular order. Each triplet contains values in
        /// non-descending order. The input array is not modified by this method.</remarks>
        /// <param name="nums">The array of integers to search for triplets. The array can contain duplicate values.</param>
        /// <returns>A list of lists, where each inner list contains three integers that sum to zero. Each triplet is unique with
        /// respect to the values and their order within the triplet.</returns>
        internal static IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> result = [];
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                int left = i + 1;
                int right = nums.Length - 1;
                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];
                    if (sum == 0)
                    {
                        result.Add([nums[i], nums[left], nums[right]]);
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
                    else if (sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("KonradL LeetCode Three Sum + Aproppriate Tests");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Sorted Two Pointer approach with duplicate detection");
            Console.WriteLine("Time Complexity: O(n^2)");
            Console.WriteLine("Space Complexity: O(1)");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"https://leetcode.com/problems/3sum/");
            Console.ResetColor();
        }
    }
}
