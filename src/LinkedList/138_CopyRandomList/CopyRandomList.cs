/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) 
    {
        if (head == null)
            return head;
        
        var copy = head;
        while (copy != null)
        {
            var next = copy.next;
            copy.next = new Node(copy.val);
            copy.next.next = next;
            copy = next;
        }
        
        copy = head;
        while (copy != null)
        {
            if (copy.random != null)
            {
                copy.next.random = copy.random.next;
            }
            copy = copy.next.next;
        }
        
        copy = head;
        var copyHead = head.next;
        var copy2 = copyHead;        
        while (copy2.next != null)
        {
            copy.next = copy.next.next;
            copy = copy.next;
            
            copy2.next = copy2.next.next;
            copy2 = copy2.next;
        }
        copy.next = copy.next.next;
        
        return copyHead;
    }
}

/*
Complexity Analysis

Time complexity : O(n)
The algorithm makes three traversal of the list, there are 3n  operations and time complexity is O(n).


Space complexity : O(1)
We only used constant extra space. 

*/