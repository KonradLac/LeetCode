[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("RemoveNodeFromEndTests")]

namespace RemoveNodeFromEnd
{
    /// <summary>
    /// Represents a node in a singly linked list of integers.
    /// </summary>
    internal class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val; this.next = next;
        }
    }

    internal class Solution
    {
        /// <summary>
        /// Removes the n-th node from the end of a singly linked list and returns the head of the modified list.
        /// </summary>
        /// <remarks>If the node to remove is the head of the list, the returned list will start with the
        /// next node. The method does not modify the input nodes except for removing the specified node from the
        /// list.</remarks>
        /// <param name="head">The head node of the singly linked list. Can be null to represent an empty list.</param>
        /// <param name="n">The position from the end of the list of the node to remove. Must be greater than or equal to 1 and less
        /// than or equal to the length of the list.</param>
        /// <returns>The head node of the linked list after the specified node has been removed. Returns null if the list becomes
        /// empty.</returns>
        internal static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummy = new(0, head);
            ListNode left = dummy;
            ListNode right = head;
            while (n > 0)
            {
                right = right.next;
                n--;
            }
            while (right != null)
            {
                left = left.next;
                right = right.next;
            }
            left.next = left.next.next;
            return dummy.next;
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("KonradL LeetCode Remove Nth Node From the End of the List + Appropriate Tests");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Two Pointer Approach");
            Console.WriteLine("Time complexity: O(N)");
            Console.WriteLine("Space complexity: O(1)");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"https://leetcode.com/problems/remove-nth-node-from-end-of-list/");
            Console.ResetColor();
        }
    }
}
