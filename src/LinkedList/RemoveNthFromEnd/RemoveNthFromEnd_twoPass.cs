public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        // Two pass algorithm
        // 1. Find the node length
        ListNode dummyHead = new ListNode(0);
        dummyHead.next = head;
        int length = 0;
        ListNode first = head;
        while (first != null){
            first = first.next;
            length++;
        }
        
        // Remove the node in head
        length -= n;
        first = dummyHead;
        while (length > 0)
        {
            first = first.next;
            length--;
        }
        first.next = first.next.next;
        return dummyHead.next;
    }
}