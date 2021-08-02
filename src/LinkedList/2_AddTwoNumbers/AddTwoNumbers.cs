/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        if (l1 == null) return l2;
        if (l2 == null) return l1;

        var dummyHead = new ListNode(0);
        var List = dummyHead;
        var add = 0;

        while (l1 != null || l2 != null)
        {
            int x = l1 != null ? l1.val : 0;
            int y = l2 != null ? l2.val : 0;
            int sum = x + y + add;
            add = sum / 10;

            List.next = new ListNode(sum % 10);
            List = List.next;

            if (l1 != null)
                l1 = l1.next;
            if (l2 != null)
                l2 = l2.next;
        }
        if (add > 0)
        {
            List.next = new ListNode(add);
        }
        return dummyHead.next;
    }
}

/*
Complexity Analysis

Time complexity : O(max(m, n))
Assume that mm and nn represents the length of l1 and l2 respectively, 
the algorithm above iterates at most max(m, n) times.

Space complexity : O(max(m, n))
The length of the new list is at most max(m,n)+1.

*/