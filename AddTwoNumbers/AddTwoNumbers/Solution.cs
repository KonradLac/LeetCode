using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("AddTwoNumbersTests")]

namespace AddTwoNumbers
{
    /// <summary>
    /// Represents a node in a singly-linked list, with non-negative integer value.
    /// </summary>
    internal class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    internal static class Solution
    {
        /// <summary>
        /// Adds two non-empty linked lists representing two non-negative integers.
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        internal static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode();
            ListNode currentNode = result;
            int carry = default;
            int first = default;
            int second = default;
            int sum = default;
            while (l1 != null || l2 != null)
            {
                if(l1 != null)
                {
                    first = l1.val;
                }
                else
                {
                    first = 0;
                }
                if (l2 != null)
                {
                    second = l2.val;
                }
                else
                {
                    second = 0;
                }
                sum = carry + first + second;
                carry = sum / 10;
                currentNode.next = new ListNode(sum % 10);
                currentNode = currentNode.next;
                if (l1 != null)
                {
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    l2 = l2.next;
                }
            }
            if (carry > 0)
            {
                currentNode.next = new ListNode(carry);
            }
            return result.next;
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("KonradL LeetCode Add Two Numbers + Appropriate Tests");
            Console.ResetColor();
        }
    }
}
