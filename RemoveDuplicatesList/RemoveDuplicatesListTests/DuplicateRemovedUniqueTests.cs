using static RemoveDuplicatesList.Solution;

namespace RemoveDuplicatesListTests
{
    public class DuplicateRemovedUniqueTests
    {
        [Fact]
        public void Test1()
        {
            int[] nums = [1, 1, 2];
            int expectedLength = 2;
            int actualLength = RemoveDuplicates(nums);
            Assert.Equal(expectedLength, actualLength);
        }

        [Fact]
        public void Test2()
        {
            int[] nums = [1, 2, 3, 4, 5, 6, 7];
            int expectedLength = 7;
            int actualLength = RemoveDuplicates(nums);
            Assert.Equal(expectedLength, actualLength);
        }

        [Fact]
        public void Test3()
        {
            int[] nums = [1, 1, 1, 1, 1, 1, 1];
            int expectedLength = 1;
            int actualLength = RemoveDuplicates(nums);
            Assert.Equal(expectedLength, actualLength);
        }

        [Fact]
        public void Test4()
        {
            int[] nums = [1, 1, 2, 2, 3, 3, 4, 4, 5, 5];
            int expectedLength = 5;
            int actualLength = RemoveDuplicates(nums);
            Assert.Equal(expectedLength, actualLength);
        }

        [Fact]
        public void Test5()
        {
            int[] nums = [];
            int expectedLength = 0;
            int actualLength = RemoveDuplicates(nums);
            Assert.Equal(expectedLength, actualLength);
        }

        [Fact]
        public void Test6()
        {
            int[] nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
            int expectedLength = 5;
            int actualLength = RemoveDuplicates(nums);
            Assert.Equal(expectedLength, actualLength);
        }

        [Fact]
        public void Test7()
        {
            int[] nums = [1, 1, 1, 1, 2];
            int expectedLength = 2;
            int actualLength = RemoveDuplicates(nums);
            Assert.Equal(expectedLength, actualLength);
        }
    }
}
