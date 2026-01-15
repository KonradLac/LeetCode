[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("SwapNodePairsTests")]

namespace SwapNodePairs
{
    /// <summary>
    /// Represents a node in a singly linked list of integers.
    /// </summary>
    internal class ListNode
    {
        internal int val;
        internal ListNode? next;
        internal ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    internal class Solution
    {
        /// <summary>
        /// Swaps every two adjacent nodes in a singly linked list and returns the new head of the list.
        /// </summary>
        /// <remarks>The relative order of nodes not swapped is preserved. The method does not modify the
        /// values of the nodes, only their links.</remarks>
        /// <param name="head">The head node of the singly linked list to process. Can be null to indicate an empty list.</param>
        /// <returns>The head node of the modified list after swapping every two adjacent nodes. Returns the original head if the
        /// list has zero or one node.</returns>
        internal static ListNode? SwapPairs(ListNode? head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode? newHead = head.next;
            ListNode? prevTail = null;
            ListNode? current = head;
            while (current != null && current.next != null)
            {
                ListNode? firstNode = current;
                ListNode? secondNode = current.next;
                ListNode? nextPairHead = secondNode.next;
                secondNode.next = firstNode;
                firstNode.next = nextPairHead;
                // Link previous pair to current swapped pair. Works only with nullable prevTail,
                // for the original LeetCode ListNode it would not work and would have to be done with IF.
                prevTail?.next = secondNode; 
                prevTail = firstNode;
                current = nextPairHead;
            }
            return newHead;
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("KonradL LeetCode Swap Nodes In Pairs + Appropriate Test");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Improvisation");
            Console.WriteLine("Time complexity: O(n)");
            Console.WriteLine("Space complexity: O(1)");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"https://leetcode.com/problems/swap-nodes-in-pairs/");
            Console.ResetColor();
        }
    }
}
