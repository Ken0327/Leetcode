public class Solution {
    public ListNode RotateRight(ListNode head, int k) 
    {
        // 先連接成環,再找斷點
        var oldTail = head;
        if (head == null)
            return null;
        
        if (head.next == null)
            return head;
        
        var n= 1;
        for (int i = 0; oldTail.next != null; i++)
        { 
            oldTail = oldTail.next;
            n++;
        }
        oldTail.next = head;
        // 找斷點
        var newTail = head;
        for (int i = 0; i < n - k % n - 1; i++)
        {
            newTail = newTail.next;
        }
        var newHead = newTail.next;
        newTail.next = null;
        return newHead;
    }
}

/*
Complexity Analysis

Time complexity : O(n)
The algorithm makes two traversal of the list, first to calculate list length n - 1 and second almost is k th node. 
There are n + k -1  operations and time complexity is O(n).


Space complexity : O(1)
We only used constant extra space. 

*/