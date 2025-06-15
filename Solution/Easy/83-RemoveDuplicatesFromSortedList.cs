using System.Reflection.Metadata;
using LeetCode.Solution.Helpers;
using static LeetCode.Solution.Easy.MergeTwoSortedLists;

namespace LeetCode.Solution.Easy;
public class RemoveDuplicatesFromSortedList
{
    // Complexity: O(n) 
    // Space = O(1)
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null) return null;

        ListNode current = head;

        while (current.next != null)
        {
            if (current.val == current.next.val)
            {
                current.next = current.next.next;
            }
            else
            {
                current = current.next;
            }
        }

        return head;
    }

    public ListNode DeleteDuplicatesRecursive(ListNode head)
    {
        // Base case: if the list is empty or has only one node, it's already deduplicated
        if (head == null || head.next == null)
            return head;

        // Recursively deduplicate the rest of the list starting from the next node
        head.next = DeleteDuplicatesRecursive(head.next);

        // If the current node and the next node have the same value,
        // skip the current node by returning head.next (removes the duplicate)
        if (head.val == head.next.val)
            return head.next;

        // Otherwise, keep the current node and return it
        return head;
    }
}
