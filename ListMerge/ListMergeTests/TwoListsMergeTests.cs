using ListMerge;
using static ListMerge.Solution;

namespace ListMergeTests
{
    public class TwoListsMergeTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            ListNode list1 = new(1, new(2, new(4)));
            ListNode list2 = new(1, new(3, new(4)));
            // Act
            ListNode mergedList = MergeTwoLists(list1, list2);
            // Assert
            int[] expectedValues = { 1, 1, 2, 3, 4, 4 };
            ListNode current = mergedList;
            foreach (int expectedValue in expectedValues)
            {
                Assert.NotNull(current);
                Assert.Equal(expectedValue, current.val);
                current = current.next;
            }
            Assert.Null(current); // Ensure the merged list ends correctly
        }

        [Fact]
        public void Test2()
        {
            // Arrange
            ListNode list1 = null;
            ListNode list2 = null;
            // Act
            ListNode mergedList = MergeTwoLists(list1, list2);
            // Assert
            Assert.Null(mergedList);
        }

        [Fact]
        public void Test3()
        {
            // Arrange
            ListNode list1 = null;
            ListNode list2 = new(0);
            // Act
            ListNode mergedList = MergeTwoLists(list1, list2);
            // Assert
            Assert.NotNull(mergedList);
            Assert.Equal(0, mergedList.val);
            Assert.Null(mergedList.next);
        }
    }
}
