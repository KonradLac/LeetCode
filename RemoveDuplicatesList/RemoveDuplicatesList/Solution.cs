[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("RemoveDuplicatesListTests")]

namespace RemoveDuplicatesList
{
    internal class Solution
    {
        internal static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int writeIndex = 1;
            for (int readIndex = 1; readIndex < nums.Length; readIndex++)
            {
                if (nums[readIndex] != nums[readIndex - 1])
                {
                    nums[writeIndex] = nums[readIndex];
                    writeIndex++;
                }
            }
            return writeIndex;
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("KonradL LeetCode Remove Duplicates from Sorted Array + Appropriate Tests");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Improvised");
            Console.WriteLine("Time Complexity: O(n)");
            Console.WriteLine("Space Complexity: O(1)");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"https://leetcode.com/problems/remove-duplicates-from-sorted-array/");
            Console.ResetColor();
        }
    }
}
