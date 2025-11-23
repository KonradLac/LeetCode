using MedianOfTwoSortedArrays;

namespace MedianOfTwoSortedArraysTests
{
    public class FindMedianSortedArraysTests
    {
        [Fact]
        public void Test1()
        {
            int[] nums1 = { 1, 3 };
            int[] nums2 = { 2 };
            double expected = 2;
            double actual = Solution.FindMedianSortedArrays(nums1, nums2);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            int[] nums1 = { 1, 2 };
            int[] nums2 = { 3, 4 };
            double expected = 2.50;
            double actual = Solution.FindMedianSortedArrays(nums1, nums2);
            Assert.Equal(expected, actual);
        }
    }
}
