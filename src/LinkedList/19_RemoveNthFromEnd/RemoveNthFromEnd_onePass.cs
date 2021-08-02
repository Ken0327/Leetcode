public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int k) {
        // One pass algorithm by two pointer
        ListNode dummyHead = new ListNode(0);
        dummyHead.next = head;
        ListNode first = dummyHead;
        ListNode second = dummyHead;
        for (int i = 0; i <= k; i++)
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

/*
Complexity Analysis

Time complexity : O(n)
The algorithm makes one traversal of the list, there are n operations and time complexity is O(n).

Space complexity : O(1).
We only used constant extra space.

*/