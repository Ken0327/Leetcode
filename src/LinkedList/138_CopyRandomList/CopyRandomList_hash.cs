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
        
        // create hash for Node in Key, Node.value in value
        var current = head;
        var map = new Dictionary<Node, Node>();
        while (current != null)
        {
            map[current] =  new Node(current.val);
            current = current.next;
        }

        // 新表next, random鏈結 connect to the node
        current = head;
        while (current != null)
        {
            if (current.next != null)
            {
                map[current].next = map[current.next];
            }
            if (current.random != null)
            {
                map[current].random = map[current.random];
            }
            current = current.next;
        }

        return map[head];
    }
}

/*
Complexity Analysis

Time complexity : O(n)
The algorithm makes three traversal of the list, there are 2n operations and time complexity is O(n).


Space complexity : O(n)
The extra space required depends on the number of items stored in the hash table, which stores exactly nn elements.

*/