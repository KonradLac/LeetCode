using MergeKLists;
using static MergeKLists.Solution;

namespace MergeKListsTests
{
    public class ListMergingTests
    {
        [Fact]
        public void Test1()
        {
            ListNode?[] lists =
            [
                new ListNode(1, new ListNode(4, new ListNode(5))),
                new ListNode(1, new ListNode(3, new ListNode(4))),
                new ListNode(2, new ListNode(6))
            ];
            ListNode? result = ListMerge(lists);
            int[] expectedValues = [1, 1, 2, 3, 4, 4, 5, 6];
            List<int> actualValues = [];
            while (result != null)
            {
                actualValues.Add(result.val);
                result = result.next;
            }
            Assert.Equal(expectedValues, actualValues.ToArray());
        }

        [Fact]
        public void Test2()
        {
            ListNode?[] lists = [];
            ListNode? result = ListMerge(lists);
            Assert.Null(result);
        }

        [Fact]
        public void Test3()
        {
            ListNode?[] lists = [null];
            ListNode? result = ListMerge(lists);
            Assert.Null(result);
        }
    }
}
