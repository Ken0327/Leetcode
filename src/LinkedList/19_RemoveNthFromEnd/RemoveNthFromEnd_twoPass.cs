public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int k) {
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
        length -= k;
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

/*
Complexity Analysis

Time complexity : O(n)
The algorithm makes two traversal of the list, first to calculate list length n and second to find the (L - k)th node. 
There are 2n-k operations and time complexity is O(L).

Space complexity : O(1).
We only used constant extra space.

*/