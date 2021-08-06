# DPA(Dynamic Programming Algorithm)
# reduce repeat operation

# Time complexity: O(n)
# Space complexity: O(n)

class Solution:
    output = [None]*1000  # storage cache 
    def fib(self, n: int) -> int:
        result = self.output[n]
        
        if result==None:
            if n==0:
                return 0
            elif n==1:
                return 1
            else:
                result = self.fib(n-1) + self.fib(n-2)
            self.output[n] = result
        return result