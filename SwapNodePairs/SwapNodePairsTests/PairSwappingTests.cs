using SwapNodePairs;
using static SwapNodePairs.Solution;

namespace SwapNodePairsTests
{
    public class PairSwappingTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            ListNode node1 = new(1);
            ListNode node2 = new(2);
            ListNode node3 = new(3);
            ListNode node4 = new(4);
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            // Act
            ListNode? result = SwapPairs(node1);
            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result!.val);
            Assert.Equal(1, result.next!.val);
            Assert.Equal(4, result.next!.next!.val);
            Assert.Equal(3, result.next!.next!.next!.val);
            Assert.Null(result.next!.next!.next!.next);
        }

        [Fact]
        public void Test2()
        {
            // Arrange
            ListNode node1 = new(1);
            // Act
            ListNode? result = SwapPairs(node1);
            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result!.val);
        }

        [Fact]
        public void Test3()
        {
            // Arrange
            ListNode? head = null;
            // Act
            ListNode? result = SwapPairs(head);
            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void Test4()
        {
            // Arrange
            ListNode node1 = new(1);
            ListNode node2 = new(2);
            ListNode node3 = new(3);
            node1.next = node2;
            node2.next = node3;
            // Act
            ListNode? result = SwapPairs(node1);
            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result!.val);
            Assert.Equal(1, result.next!.val);
            Assert.Equal(3, result.next!.next!.val);
            Assert.Null(result.next!.next!.next);
        }
    }
}
