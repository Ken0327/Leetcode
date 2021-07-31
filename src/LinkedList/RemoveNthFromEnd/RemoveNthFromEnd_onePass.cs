public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        // One pass algorithm by two pointer
        ListNode dummyHead = new ListNode(0);
        dummyHead.next = head;
        ListNode first = dummyHead;
        ListNode second = dummyHead;
        for (int i = 0; i <= n; i++)
        {
            first = first.next;
        }
        while (first != null)
        {
            first = first.next;
            second = second.next;
        }
        second.next = second.next.next;     
        return dummyHead.next;
    }
}