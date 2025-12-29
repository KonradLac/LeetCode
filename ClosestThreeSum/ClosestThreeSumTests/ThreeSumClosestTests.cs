using static ClosestThreeSum.Solution;

namespace ClosestThreeSumTests
{
    public class ThreeSumClosestTests
    {
        [Fact]
        public void Test1()
        {
            int[] nums = { -1, 2, 1, -4 };
            int target = 1;
            int expected = 2;
            int result = ThreeSumClosest(nums, target);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2()
        {
            int[] nums = { 1, 2, 3, 4 };
            int target = 1;
            int expected = 6;
            int result = ThreeSumClosest(nums, target);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test3()
        {
            int[] nums = { 1, -2, 3, 4 };
            int target = 1;
            int expected = 2;
            int result = ThreeSumClosest(nums, target);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test4()
        {
            int[] nums = { 0, 0, 0 };
            int target = 1;
            int expected = 0;
            int result = ThreeSumClosest(nums, target);
            Assert.Equal(expected, result);
        }
    }
}
