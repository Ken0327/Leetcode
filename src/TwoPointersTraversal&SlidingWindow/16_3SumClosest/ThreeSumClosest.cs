// Sliding Window & two pointer

public class Solution {
    public int ThreeSumClosest(int[] nums, int target) 
    {
        Array.Sort(nums);
        
        var result = nums[0] + nums[1] + nums[2];
        
        for (var i =0; i < nums.Count() - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i-1])
                continue;
            
            var start = i + 1;
            var end = nums.Count() - 1;
            while (start < end)
            {
                var sum = nums[i] + nums[start] + nums[end];
                var diff = sum - target;
                if (Math.Abs(diff) < Math.Abs(result - target))
                {
                    result = sum;
                }
                if (diff == 0)
                    return target;
                else if (sum > target)
                {
                    end--;
                }
                else
                    start++;
            }            
        }
        return result;
    }
}

/*
1. Array Sort 
2. initail three sum 
3. two pointer between start and end

Time complexity: O(n^2)
数组排序 O(NlogN), 遍历数组O(n), 双指针遍历 O(n), 总体复杂度为 O(NlogN) + O(n) * O(n) ，O(n^2)

Space complexity: O(1)

*/