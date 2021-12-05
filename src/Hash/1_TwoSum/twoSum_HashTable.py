# Runtime: 60 ms, faster than 79.00% of Python3 online submissions for Two Sum.
# Memory Usage: 15.4 MB, less than 41.57% of Python3 online submissions for Two Sum.


class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        hash_map = {}
        for index, value in enumerate(nums):
            if target - value in hash_map:
                return [index, hash_map[target - value]]
            else:
                hash_map[value] = index


# Complexity Analysis

# Time complexity: O(n)
# We traverse the list containing nn elements exactly twice. Since the hash table reduces the lookup time to O(1), the overall time complexity is O(n).

# Space complexity: O(n)
# The extra space required depends on the number of items stored in the hash table, which stores exactly nn elements.
