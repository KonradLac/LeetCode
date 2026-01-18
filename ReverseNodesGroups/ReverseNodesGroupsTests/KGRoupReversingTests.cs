using ReverseNodesGroups;
using static ReverseNodesGroups.Solution;

namespace ReverseNodesGroupsTests
{
    public class KGRoupReversingTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            ListNode head = new(1, new(2, new(3, new(4, new(5)))));
            int k = 2;
            // Act
            ListNode result = ReverseKGroup(head, k);
            // Assert
            int[] expectedValues = [2, 1, 4, 3, 5];
            ListNode current = result;
            foreach (int expectedValue in expectedValues)
            {
                Assert.NotNull(current);
                Assert.Equal(expectedValue, current.val);
                current = current.next;
            }
            Assert.Null(current); // Ensure the list ends correctly
        }

        [Fact]
        public void Test2()
        {
            // Arrange
            ListNode head = new(1, new(2, new(3, new(4, new(5)))));
            int k = 3;
            // Act
            ListNode result = ReverseKGroup(head, k);
            // Assert
            int[] expectedValues = [3, 2, 1, 4, 5];
            ListNode current = result;
            foreach (int expectedValue in expectedValues)
            {
                Assert.NotNull(current);
                Assert.Equal(expectedValue, current.val);
                current = current.next;
            }
            Assert.Null(current); // Ensure the list ends correctly
        }

        [Fact]
        public void Test3()
        {
            // Arrange
            ListNode head = new(1, new(2, new(3, new(4, new(5)))));
            int k = 1;
            // Act
            ListNode result = ReverseKGroup(head, k);
            // Assert
            int[] expectedValues = [1, 2, 3, 4, 5];
            ListNode current = result;
            foreach (int expectedValue in expectedValues)
            {
                Assert.NotNull(current);
                Assert.Equal(expectedValue, current.val);
                current = current.next;
            }
            Assert.Null(current); // Ensure the list ends correctly
        }

        [Fact]
        public void Test4()
        {
            // Arrange
            ListNode head = new(1, new(2, new(3, new(4, new(5)))));
            int k = 4;
            // Act
            ListNode result = ReverseKGroup(head, k);
            // Assert
            int[] expectedValues = [4, 3, 2, 1, 5];
            ListNode current = result;
            foreach (int expectedValue in expectedValues)
            {
                Assert.NotNull(current);
                Assert.Equal(expectedValue, current.val);
                current = current.next;
            }
            Assert.Null(current); // Ensure the list ends correctly
        }

        [Fact]
        public void Test5()
        {
            // Arrange
            ListNode head = new(1, new(2, new(3, new(4, new(5)))));
            int k = 5;
            // Act
            ListNode result = ReverseKGroup(head, k);
            // Assert
            int[] expectedValues = [5, 4, 3, 2, 1];
            ListNode current = result;
            foreach (int expectedValue in expectedValues)
            {
                Assert.NotNull(current);
                Assert.Equal(expectedValue, current.val);
                current = current.next;
            }
            Assert.Null(current);
        }
    }
}
