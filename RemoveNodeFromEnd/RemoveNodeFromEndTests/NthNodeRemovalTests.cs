using static RemoveNodeFromEnd.Solution;
using RemoveNodeFromEnd;

namespace RemoveNodeFromEndTests
{
    public class NthNodeRemovalTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            ListNode head = new(1, new(2, new(3, new(4, new(5)))));
            int n = 2;
            // Act
            ListNode result = RemoveNthFromEnd(head, n);
            // Assert
            ListNode expected = new(1, new(2, new(3, new(5))));
            while (result.next != null)
            {
                Assert.Equal(expected.val, result.val);
                expected = expected.next;
                result = result.next;
            }
            if(result.next != null)
            {
                Assert.Fail();
            }
        }

        [Fact]
        public void Test2()
        {
            // Arrange
            ListNode head = new(1);
            int n = 1;
            // Act
            ListNode result = RemoveNthFromEnd(head, n);
            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void Test3()
        {
            // Arrange
            ListNode head = new(1, new(2));
            int n = 1;
            // Act
            ListNode result = RemoveNthFromEnd(head, n);
            // Assert
            ListNode expected = new(1);
            while (result.next != null)
            {
                Assert.Equal(expected.val, result.val);
                expected = expected.next;
                result = result.next;
            }
            if (result.next != null)
            {
                Assert.Fail();
            }
        }

        [Fact]
        public void Test4()
        {
            // Arrange
            ListNode head = new(1, new(2));
            int n = 2;
            // Act
            ListNode result = RemoveNthFromEnd(head, n);
            // Assert
            ListNode expected = new(2);
            while (result.next != null)
            {
                Assert.Equal(expected.val, result.val);
                expected = expected.next;
                result = result.next;
            }
            if (result.next != null)
            {
                Assert.Fail();
            }
        }
    }
}
