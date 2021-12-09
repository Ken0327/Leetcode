#  先根据start进行排序之后merge 
#   o(n*log(n))
# Runtime: 84 ms, faster than 79.61% of Python3 online submissions for Merge Intervals.
# Memory Usage: 16.1 MB, less than 55.92% of Python3 online submissions for Merge Intervals.

class Solution:
    def merge(self, intervals):
        
        intervals.sort()
        
        output = []
        curr = intervals[0]
        output.append(curr)
        
        for i in intervals:
            currEnd = curr[1]
            nextStart = i[0]
            nextEnd = i[1]
            
            if currEnd >= nextStart:
                curr[1] = max(currEnd, nextEnd)
            else:
                curr = i
                output.append(curr)
        
        return output


# Apporach 2
# Runtime: 88 ms, faster than 58.29% of Python3 online submissions for Merge Intervals.
# Memory Usage: 16.2 MB, less than 10.89% of Python3 online submissions for Merge Intervals.

class Solution1:
    def merge1(self, intervals):

        intervals.sort()

        merged = []
        for interval in intervals:
            # if the list of merged intervals is empty or if the current
            # interval does not overlap with the previous, simply append it.
            if not merged or merged[-1][1] < interval[0]:
                merged.append(interval)
            else:
            # otherwise, there is overlap, so we merge the current and previous
            # intervals.
                a = merged[-1][1]
                b = interval[1]
                merged[-1][1] = max(merged[-1][1], interval[1])

        return merged

        # Negative numbers mean that you count from the right instead of the left.
        # list[-1] refers to the last element
        # list[-2] is the second-last, and so on.

if __name__ == '__main__':
    print(Solution().merge([[1,3],[1,6],[8,10],[15,18]]))
    print(Solution1().merge1([[1,3],[1,6],[2,5],[2,7],[8,10],[15,18]]))
    

# Complexity Analysis

# Time complexity : O(nlogn)

# Other than the sort invocation, we do a simple linear scan of the list, 
# so the runtime is dominated by the O(nlogn) complexity of sorting.

# Space complexity : O(logN) or O(n)

# If we can sort intervals in place, we do not need more than constant additional space, 
# although the sorting itself takes O(logn) space. Otherwise, 
# we must allocate linear space to store a copy of intervals and sort that.
