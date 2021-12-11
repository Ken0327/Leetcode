
# Runtime: 36 ms, faster than 49.52% of Python3 online submissions for Reverse Integer.
# Memory Usage: 14.2 MB, less than 46.23% of Python3 online submissions for Reverse Integer.

class Solution:
    def reverse(self, x):
        positive =1
        if x < 0:
            positive=-1
            x = x * -1
        rev = 0
        while x != 0:
            pop = x % 10
            x = x // 10
            rev = rev*10 + pop
            if rev > 2**31 or rev < -2**31 -1:
                return 0
        return rev * positive

if __name__ == '__main__':
    print(Solution().reverse(123))
    print(Solution().reverse(-123))
    print(Solution().reverse(120))


# Complexity Analysis

# Time complexity : O(log(x))
# There are roughly log(x) digits in x.

# Space complexity : O(1)
