# Runtime: 28 ms, faster than 94.94% of Python3 online submissions for Subsets.
# Memory Usage: 14.4 MB, less than 79.66% of Python3 online submissions for Subsets.

class Solution:
    def subsets(self, nums: List[int]) -> List[List[int]]:
        result = [[]]
        for num in sorted(nums):
            result += [item + [num] for item in result]
        return result


# Complexity Analysis

# Time complexity: 
    # {O}(N × 2^N) to generate all subsets and then copy them into output list.

# Space complexity: 
    # {O}(N x 2^N)).
    # This is exactly the number of solutions for subsets multiplied by the number N of elements to keep for each subset.

    # For a given number, it could be present or absent (i.e. binary choice) in a subset solution. 
    # As as result, for N numbers, we would have in total 2^N choices (solutions).