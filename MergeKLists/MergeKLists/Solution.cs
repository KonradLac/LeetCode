[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("MergeKListsTests")]

namespace MergeKLists
{
    /// <summary>
    /// Represents a node in a singly linked list, containing an integer value and a reference to the next node.
    /// </summary>
    /// <remarks>This class is typically used to construct and traverse singly linked lists, where each node
    /// points to the next node in the sequence. The list can be extended by linking additional nodes via the
    /// <c>next</c> field.</remarks>
    internal class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    internal class Solution
    {
        /// <summary>
        /// Merges multiple sorted singly linked lists into a single sorted linked list.
        /// </summary>
        /// <remarks>The relative order of nodes with equal values is preserved from the input lists. The
        /// method assumes that each input list is already sorted in ascending order.</remarks>
        /// <param name="lists">An array of ListNode objects, each representing the head of a sorted singly linked list. Elements may be
        /// null to indicate an empty list.</param>
        /// <returns>The head node of a new singly linked list containing all nodes from the input lists, sorted in ascending
        /// order. Returns null if all input lists are empty or null.</returns>
        internal static ListNode? ListMerge(ListNode?[] lists)
        {
            PriorityQueue<ListNode, int> temp = new();
            foreach (ListNode? node in lists)
            {
                if (node != null)
                {
                    temp.Enqueue(node, node.val);
                }
            }
            ListNode dummy = new();
            ListNode tail = dummy;
            while (temp.Count > 0)
            {
                ListNode node = temp.Dequeue();
                ListNode? next = node.next;
                node.next = null;
                tail.next = node;
                tail = node;
                if (next != null)
                {
                    temp.Enqueue(next, next.val);
                }
            }
            return dummy.next;
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("KonradL LeetCode Merge K Sorted Lists + Appropriate Tests");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Min Heap approach");
            Console.WriteLine("Time complexity: O(n log k), where n is the total number of nodes across all lists and k is the number of lists.");
            Console.WriteLine("Space complexity: O(k), where k is the number of lists.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"https://leetcode.com/problems/merge-k-sorted-lists/");
            Console.ResetColor();
        }
    }
}
