# Recusion

# Time complexity: O(2^n)- since T(n) = T(n-1) + T(n-2)is an exponential time
# Space complexity: O(n) - space for recursive function call stack

class Solution:
    def fib(self, n: int) -> int:
        if n==0:
            return 0
        elif n==1 or n==2:
            return 1
        else:
            return self.fib(n-1) + self.fib(n-2)