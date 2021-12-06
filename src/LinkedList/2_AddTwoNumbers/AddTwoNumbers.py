# Runtime: 56 ms, faster than 99.09% of Python3 online submissions for Add Two Numbers.
# Memory Usage: 14.2 MB, less than 91.26% of Python3 online submissions for Add Two Numbers.


# Definition for singly-linked list.
class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

class Solution:
    def addTwoNumbers(self, l1: Optional[ListNode], l2: Optional[ListNode]) -> Optional[ListNode]:
        if not l1:
            return l2
        if not l2:
            return l1 
        
        pre = ListNode(0)
        List = pre
        add = 0
        
        while l1 or l2:
            x = 0
            y = 0
            if l1:
                x = l1.val
                l1 = l1.next
            if l2:
                y = l2.val
                l2 = l2.next

            sum = x + y + add
            add = sum // 10
            
            List.next = ListNode(sum % 10)
            List = List.next
            
        if add > 0:
            List.next = ListNode(add)
            
        return pre.next


# Complexity Analysis

# Time complexity : O(max(m, n))
# Assume that mm and nn represents the length of l1 and l2 respectively, 
# the algorithm above iterates at most max(m, n) times.

# Space complexity : O(max(m, n))
# The length of the new list is at most max(m,n)+1.
