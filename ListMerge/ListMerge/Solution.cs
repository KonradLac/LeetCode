[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("ListMergeTests")]

namespace ListMerge
{
    /// <summary>
    /// Represents a node in a singly linked list of integers.
    /// </summary>
    /// <remarks>Each node contains an integer value and a reference to the next node in the list. This type
    /// is typically used to construct linked list data structures for algorithms or data manipulation tasks.</remarks>
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
        /// Merges two sorted singly linked lists into a single sorted linked list.
        /// </summary>
        /// <remarks>The merged list reuses the nodes from the input lists; no new nodes are created. The
        /// input lists must be sorted in non-decreasing order for the result to be correctly sorted.</remarks>
        /// <param name="list1">The head node of the first sorted linked list. Can be null to represent an empty list.</param>
        /// <param name="list2">The head node of the second sorted linked list. Can be null to represent an empty list.</param>
        /// <returns>The head node of a new sorted linked list containing all nodes from both input lists, or null if both input
        /// lists are empty.</returns>
        internal static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode dummy = new();
            ListNode current = dummy;
            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }
                current = current.next;
            }
            if (list1 != null)
            {
                current.next = list1;
            }
            else
            {
                current.next = list2;
            }
            return dummy.next;
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("KonradL LeetCode Merge Two Sorted Lists + Appropriate Tests");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Brute Force");
            Console.WriteLine("Time complexity: O(n + m)");
            Console.WriteLine("Space complexity: O(1)");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"https://leetcode.com/problems/merge-two-sorted-lists/");
            Console.ResetColor();
        }
    }
}
