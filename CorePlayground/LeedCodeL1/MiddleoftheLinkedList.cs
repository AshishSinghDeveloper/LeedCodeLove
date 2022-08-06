using System;
using CorePlayground.LeedCodeL1;

namespace LeedCodeLove.LeedCodeL1
{
    public static class MiddleoftheLinkedList
    {
        public static ListNode MiddleNodeAttempt1(ListNode head)
        {
            //This is first attempt:
            //Here I first traverse linkedList to get total `Count`.
            //Then divided Count to half to get middle count of LinkedList
            //Then travese the linkedList to the half using Count
            //and returned remaining half list

            // Time: O(n) Used two loop but not within
            // Space: O(1) Didn't used any complex data type like List
            var start = head;
            var end = head;
            int count = 0;
            while (end != null)
            {
                count++;
                end = end.next;
            }

            count = count / 2;
            for (int i = 0; i < count; i++)
            {
                start = start.next;
            }
            return start;
        }

        public static ListNode MiddleNodeAttempt2(ListNode head)
        {
            // This is second attempt:
            // Here I took two pointer
            // slow pointer is traversing at the speed of one.
            // Fast pointer is going at double speed.
            // So when fast pointer reaches to end slow pointer will always be in middle
            // Since we want right of middle (when we have two middle) I checked fast.next != null
            // if we wanted left of middle it would be fast.next.next != null

            // Time: O(n) used only one loop
            // Space: O(1)
            var slow = head;
            var fast = head;

            while(slow != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (fast == null) break;
            }

            return slow;
        }
    }
}
