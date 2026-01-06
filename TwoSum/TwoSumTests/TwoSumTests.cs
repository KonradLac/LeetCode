using static TwoSum.Solution;

namespace TwoSumTests
{
    public class TwoSumTests
    {
        [Fact]
        public void Test1()
        {
            int[] testSet1 = [2, 7, 11, 15];
            int target1 = 9;
            int[] correct1 = [0, 1];
            Assert.Equal(correct1, TwoSumCalculation(testSet1, target1));
        }

        [Fact]
        public void Test2()
        {
            int[] testSet2 = [3, 2, 4];
            int target2 = 6;
            int[] correct2 = [1, 2];
            Assert.Equal(correct2, TwoSumCalculation(testSet2, target2));
        }

        [Fact]
        public void Test3()
        {
            int[] testSet3 = [3, 3];
            int target3 = 6;
            int[] correct3 = [0, 1];
            Assert.Equal(correct3, TwoSumCalculation(testSet3, target3));
        }

        [Fact]
        public void Test4()
        {
            int[] testSet4 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            int target4 = 19;
            int[] correct4 = [8, 9];
            Assert.Equal(correct4, TwoSumCalculation(testSet4, target4));
        }

        [Fact]
        public void Test5()
        {
            int[] testSet5 = [0, -1, 2, -3, 1];
            int target5 = -2;
            int[] correct5 = [3, 4];
            Assert.Equal(correct5, TwoSumCalculation(testSet5, target5));
        }

        [Fact]
        public void Test6()
        {
            int[] testSet6 = [1, 2, 3];
            int target6 = 7;
            Assert.Throws<ArgumentException>(() => TwoSumCalculation(testSet6, target6));
        }
    }
}
