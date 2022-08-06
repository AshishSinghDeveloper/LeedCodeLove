using System;
namespace CorePlayground.LeedCodeL1
{
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
    public static class MergeTwoSortedList
    {
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            var dummy = new ListNode();
            var tail = dummy;
            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    tail.next = new ListNode(list1.val, null);
                    list1 = list1.next;
                }
                else
                {
                    tail.next = new ListNode(list2.val, null); ;
                    list2 = list2.next;
                }

                tail = tail.next;                
            }

            if (list1 != null)
                tail.next = list1;
            else if (list2 != null)
                tail.next = list2;

            return dummy.next;
        }
    }
}
