# slow fast pointers

# Runtime: 56 ms, faster than 63.56% of Python3 online submissions for Linked List Cycle.
# Memory Usage: 17.7 MB, less than 56.41% of Python3 online submissions for Linked List Cycle.

# Definition for singly-linked list.
class ListNode:
    def __init__(self, x):
        self.val = x
        self.next = None

class Solution:
    def hasCycle(self, head) -> bool:
        fast = head
        slow = head
        while fast and fast.next:
            fast = fast.next.next
            slow = slow.next
            if fast == slow:
                return True
        return False

    if __name__ == '__main__':
        print('hello')
        

# Time complexity: O(n).v
# The algorithm makes one traversal of the list head, there are n operations and time complexity is O(n).

# Space complexity: O(1)
# extra instant space.
