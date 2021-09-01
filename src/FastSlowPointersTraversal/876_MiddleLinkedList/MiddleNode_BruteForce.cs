// Brute Force 101 ms

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
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        var length = 1;
        var first = head;
        var second = head;
        while (first.next != null){
            first = first.next;
            length++;
        }
        var middle = length / 2;
        for (int i= 0; i < middle; i++){
            second = second.next;
        }
        return second;
    }
}

/*
Complexity Analysis

Time Complexity: O(N)
where N + N/2 is the number of nodes in the given list.

Space complexity : O(1).
the space used by first and second.

*/
