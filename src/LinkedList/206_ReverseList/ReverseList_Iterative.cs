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

 //遍历直接反向修改next指针 o(n)

public class Solution {
    public ListNode ReverseList(ListNode head) 
    {
        ListNode pre = null;
        ListNode curr = head;
        while (curr != null)
        {
            ListNode nxt = curr.next;
            // curr反接 pre反轉
            curr.next = pre;
            pre = curr;
            // 接下一個node
            curr = nxt;
        }
        return pre;
    }
}

/*
Complexity Analysis

Time complexity : O(n)
The algorithm makes one traversal of the list, there are n  operations and time complexity is O(n).


Space complexity : O(1)
We only used constant extra space. 

*/