
/*
Runtime: 1640 ms, faster than 5.13% of C# online submissions for Minimum Increment to Make Array Unique.
Memory Usage: 46.7 MB, less than 20.51% of C# online submissions for Minimum Increment to Make Array Unique.
*/

public class Solution {
    public int MinIncrementForUnique(int[] nums)
    {
        Array.Sort(nums);
        
        var times = 0;
        for (var i = 0; i < nums.Length - 1; i++)
        {
            while (nums[i + 1] <= nums[i])
            {
                nums[i + 1]++;
                times++;
            }
        }

        return times;
    }
}

// Better Approach
// Runtime: 252 ms, faster than 46.15% of C# online submissions for Minimum Increment to Make Array Unique.
// Memory Usage: 46.7 MB, less than 20.51% of C# online submissions for Minimum Increment to Make Array Unique.

public class Solution {
    public int MinIncrementForUnique(int[] nums) {
        Array.Sort(nums);
        int result = 0;

        for (int i = 1; i < nums.Length; i++) {
            if(nums[i] <= nums[i - 1]) {
                result = result + nums[i - 1] - nums[i] + 1;
                nums[i] = nums[i - 1] + 1;
            }
        }

        return result;
    }
}

/*

Complexity Analysis

Let N be the length of nums and M be the maximum value in nums.

Time Complexity: O(N + M)
We iterate over every possible value of x from 1 to N + MN+M and each iteration requires O(1) time.

Space Complexity: O(N + M)
In the Java implementation, O(N + M) space is allocated for count and O(1)O(1) space for taken. 
In the Python implementation, a hash map is used for count which will contain at most NN elements when every value in the input array is unique. 
A list is used for taken which will contain N - 1 elements when every value in the input array is the same. 
Thus the Java implementation uses O(N + M) space while the python implementation uses O(N) space. 

 */