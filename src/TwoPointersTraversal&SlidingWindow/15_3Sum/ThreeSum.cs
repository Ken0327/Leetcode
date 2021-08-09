// Sliding Window & two pointer

public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) 
    {
        IList<IList<int>> result = new List<IList<int>>();
        
        Array.Sort(nums);
        
        for (int i =0; i < nums.Count() - 2; i++)
        {
            if(i > 0 && nums[i] == nums[i - 1])  // bypass if value duplicate
                continue;
            
            var first = nums[i];
            var twoSum = -first;
            int start = i + 1;
            int end = nums.Count() - 1;
            while (start < end)
            {
                var sum = nums[start] + nums[end];
                if (sum == twoSum)
                {
                    IList<int> list = new List<int>() {first, nums[start], nums[end]};
                    result.Add(list);
                    end--;
                    start++;
                    while (start < end && nums[start] == nums[start-1])
                        start++;
                    while (start < end && nums[end] == nums[end+1])
                        end--;
                }
                else if (sum > twoSum)
                {
                    end--;
                }
                else if (sum < twoSum)
                {
                    start++;
                }
            }
        }
        return result;
    }
}

/*
1. Array Sort 
2. twoSum = -first
3. two pointer between start and end

Time complexity: O(n^2)
数组排序 O(NlogN), 遍历数组O(n), 双指针遍历 O(n), 总体复杂度为 O(NlogN) + O(n) * O(n) ，O(n^2)

Space complexity: O(1)

*/