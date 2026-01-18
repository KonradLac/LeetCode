[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("ReverseNodesGroupsTests")]

namespace ReverseNodesGroups
{
    /// <summary>
    /// Represents a node in a singly linked list of integers.
    /// </summary>
    /// <remarks>Each node contains an integer value and a reference to the next node in the list. This type
    /// is typically used to construct or traverse linked list data structures.</remarks>
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

    internal class Solution
    {
        /// <summary>
        /// Reverses the nodes of a singly linked list in groups of the specified size.
        /// </summary>
        /// <remarks>If k is less than or equal to 1, or the list is empty, the original list is returned
        /// unchanged.</remarks>
        /// <param name="head">The head node of the singly linked list to process. Can be null to indicate an empty list.</param>
        /// <param name="k">The size of the groups in which to reverse the nodes. Must be greater than 0.</param>
        /// <returns>The head node of the modified list, where nodes are reversed in groups of size k. If the number of nodes is
        /// not a multiple of k, the remaining nodes at the end are left in their original order.</returns>
        internal static ListNode ReverseKGroup(ListNode head, int k)
        {
            if (head == null || k <= 1)
            {
                return head;
            }
            ListNode curr = head;
            ListNode tail = null;
            ListNode newHead = null;
            while (curr != null)
            {
                int count = 0;
                ListNode temp = curr;
                while (temp != null && count < k)
                {
                    temp = temp.next;
                    count++;
                }
                if (count == k)
                {
                    ListNode prev = null;
                    ListNode node = curr;
                    for (int i = 0; i < k; i++)
                    {
                        ListNode nextNode = node.next;
                        node.next = prev;
                        prev = node;
                        node = nextNode;
                    }
                    if (newHead == null)
                    {
                        newHead = prev;
                    }
                    if (tail != null)
                    {
                        tail.next = prev;
                    }
                    tail = curr;
                    curr = temp;
                }
                else
                {
                    if (tail != null)
                    {
                        tail.next = curr;
                    }
                    break;
                }
            }
            return newHead ?? head;
        }

        [Obsolete]
        internal static ListNode ReverseKGroupBeta(ListNode head, int k)
        {
            if (head == null || k <= 1)
            {
                return head;
            }
            Stack<ListNode> stack = new();
            ListNode current = head;
            ListNode previous = null;
            while (current != null)
            {
                int count = 0;
                ListNode temp = current;
                while (temp != null && count < k)
                {
                    stack.Push(temp);
                    temp = temp.next;
                    count++;
                }
                if (count == k)
                {
                    while (stack.Count > 0)
                    {
                        if (previous == null)
                        {
                            previous = stack.Pop();
                            head = previous;
                        }
                        else
                        {
                            previous.next = stack.Pop();
                            previous = previous.next;
                        }
                    }
                    previous.next = temp;
                    current = temp;
                }
                else
                {
                    break;
                }
            }
            return head;
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("KonradL LeetCode Reverse Nodes in k Groups Two Versions + Appropriate Tests");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Iteration and Stack based solutions");
            Console.WriteLine("Time complexity: O(n)");
            Console.WriteLine("Space complexity: O(1)");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"https://leetcode.com/problems/reverse-nodes-in-k-group/");
            Console.ResetColor();
        }
    }
}
