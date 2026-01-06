using static MedianOfTwoSortedArrays.Solution;

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
            double actual = FindMedianSortedArrays(nums1, nums2);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            int[] nums1 = { 1, 2 };
            int[] nums2 = { 3, 4 };
            double expected = 2.50;
            double actual = FindMedianSortedArrays(nums1, nums2);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            int[] nums1 = { 1, 2, 11 };
            int[] nums2 = { 3, 4, 6 };
            double expected = 3.5;
            double actual = FindMedianSortedArrays(nums1, nums2);
            Assert.Equal(expected, actual);
        }
    }
}
