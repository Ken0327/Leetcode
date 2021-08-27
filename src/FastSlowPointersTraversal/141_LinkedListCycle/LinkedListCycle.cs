// Hash table 184ms

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        HashSet<ListNode> visited = new HashSet<ListNode>();
        while (head != null)
        {
            visited.Add(head);
            if (visited.Contains(head.next))
            {                    
                return true;
            }
            head = head.next;
        }
        return false;
    }
}

/*
Time complexity: O(n).
The algorithm makes one traversal of the list head, there are n operations and time complexity is O(n).

Space complexity: O(n)
Dictionary will store each elemnt of head.
*/


// slow fast pointers 96ms

public class Solution {
    public bool HasCycle(ListNode head) {
        ListNode slow = head;
        ListNode fast = head;
        while(slow != null && fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
            
            if(slow == fast) return true;
        }        
        return false;
    }
}

/*
Time complexity: O(n).
The algorithm makes one traversal of the list head, there are n operations and time complexity is O(n).

Space complexity: O(1)
extra instant space.

*/