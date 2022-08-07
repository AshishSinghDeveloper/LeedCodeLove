using System.Collections.Generic;
using CorePlayground.LeedCodeL1;

namespace LeedCodeLove.LeedCodeL1
{
    public static class LInkedListCycleII
    {
        public static ListNode DetectCycle(ListNode head)
        {
            HashSet<ListNode> listVal = new HashSet<ListNode>();
            while (head != null && !listVal.Contains(head))
            {
                listVal.Add(head);
                head = head.next;

            }
            return head;
        }
    }
}
