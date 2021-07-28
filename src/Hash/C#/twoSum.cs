public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                if ((nums[i] + nums[j]) == target)
                {
                    return new int[] {i, j}; 
                }
            }
        }
        return null;
    }
}

/*
Complexity Analysis

Time complexity: O(n^2)
For each element, we try to find its complement by looping through the rest of the array which takes O(n) time. Therefore, the time complexity is O(n^2).

Space complexity: O(1)
The space required does not depend on the size of the input array, so only constant space is used.

*/