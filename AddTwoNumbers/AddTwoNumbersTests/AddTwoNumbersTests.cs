using static AddTwoNumbers.Solution;
using AddTwoNumbers;

namespace AddTwoNumbersTests
{
    public class AddTwoNumbersTests
    {
        [Fact]
        public void Test1()
        {
            ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
            ListNode resultList = AddTwoNumbersFromNodes(l1, l2);
            List<int> expectedListValues = [8, 0, 7];
            List<int> resultListValues = [resultList.val, resultList.next.val, resultList.next.next.val];
            resultListValues.Reverse();
            Assert.True(expectedListValues.SequenceEqual(resultListValues));
        }

        [Fact]
        public void Test2()
        {
            ListNode l1 = new ListNode(0);
            ListNode l2 = new ListNode(0);
            ListNode resultList = AddTwoNumbersFromNodes(l1, l2);
            List<int> expectedListValues = [0];
            List<int> resultListValues = [resultList.val];
            Assert.True(expectedListValues.SequenceEqual(resultListValues));
        }

        [Fact]
        public void Test3()
        {
            ListNode l1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode (9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
            ListNode l2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));
            ListNode resultList = AddTwoNumbersFromNodes(l1, l2);
            List<int> expectedListValues = [8, 9, 9, 9, 0, 0, 0, 1];
            List<int> resultListValues = [];
            while (resultList != null)
            {
                resultListValues.Add(resultList.val);
                resultList = resultList.next;
            }
            Assert.True(expectedListValues.SequenceEqual(resultListValues));
        }
    }
}
