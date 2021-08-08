/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

 //递归法 o(n)

public class Solution {
    public ListNode ReverseList(ListNode head) 
    {
        if (head != null || head.next !=null)
            return head;
        var p = ReverseList(head.next);
        head.next.next = head;
        head.next = null;
        return p;
    }
}

/*
Complexity analysis

Time complexity : O(n) 
Assume that n is the list's length, the time complexity is O(n)

Space complexity : O(n) 
The extra space comes from implicit stack space due to recursion. The recursion could go up to n levels deep. 

*/