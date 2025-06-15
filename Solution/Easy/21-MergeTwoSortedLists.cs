namespace LeetCode.Solution.Easy;
public class MergeTwoSortedLists
{
    //https://www.youtube.com/watch?v=E5XXiY6QnAs
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var head = new ListNode();
        var current = head;
        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
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

        current.next = list1 ?? list2;
        return head.next;
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
