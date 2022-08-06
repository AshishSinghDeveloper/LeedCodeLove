using System;
namespace CorePlayground.LeedCodeL1
{
    public static class ReverseLinkedList
    {
        public static ListNode ReverseList(ListNode head)
        {
            ListNode current = head;
            ListNode previous = null;

            while (current != null)
            {
                var temp = current.next;
                current.next = previous;
                previous = current;
                current = temp;
            }
            return previous;
        }
    }
}
