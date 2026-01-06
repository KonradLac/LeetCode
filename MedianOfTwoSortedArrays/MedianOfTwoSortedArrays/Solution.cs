[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("MedianOfTwoSortedArraysTests")]

namespace MedianOfTwoSortedArrays
{
    internal class Solution
    {
        /// <summary>
        /// Finds the median value of two sorted integer arrays as if they were merged into a single sorted sequence.
        /// </summary>
        /// <remarks>Both input arrays must be sorted in non-decreasing order. The method does not modify
        /// the input arrays.</remarks>
        /// <param name="nums1">The first sorted array of integers. Cannot be null.</param>
        /// <param name="nums2">The second sorted array of integers. Cannot be null.</param>
        /// <returns>The median value of the combined sorted arrays. If the total number of elements is even, returns the average
        /// of the two middle values; otherwise, returns the middle value.</returns>
        internal static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int firstLength = nums1.Length;
            int secondLength = nums2.Length;
            int i = default;
            int j = default;
            int middle = -1;
            int secondMiddle = -1;
            for (int counter = 0; counter <= (firstLength + secondLength) / 2; counter++)
            {
                secondMiddle = middle;
                if (i != firstLength && j != secondLength)
                {
                    if (nums1[i] > nums2[j])
                    {
                        middle = nums2[j++];
                    }
                    else
                    {
                        middle = nums1[i++];
                    }
                }
                else if (i < firstLength)
                {
                    middle = nums1[i++];
                }
                else
                {
                    middle = nums2[j++];
                }
            }
            if ((firstLength + secondLength) % 2 == 1)
            {
                return middle;
            }
            else
            {
                return (middle + secondMiddle) / 2.0;
            }

        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("KonradL LeetCode Median of Two Sorted Arrays + Appropriate Tests");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Binary Search approach");
            Console.WriteLine("Time complexity: O(log min(m, n))");
            Console.WriteLine("Space complexity: O(1)");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"https://leetcode.com/problems/median-of-two-sorted-arrays/");
            Console.ResetColor();
        }
    }
}
