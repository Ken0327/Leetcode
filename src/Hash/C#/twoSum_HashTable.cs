using System.Collections

public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        var hash = new Hashtable();
        for (var i = 0; i < nums.Length; i++)
        {
            if (hash.ContainsKey(target - nums[i]))
            {
                var value = int.Parse(hash[target - nums[i]].ToString());
                return new int[] { value, i };
            }
            hash.Add(nums[i], i);
        }
        return null;
    }
}

/*
Complexity Analysis

Time complexity: O(n)
We traverse the list containing nn elements exactly twice. Since the hash table reduces the lookup time to O(1), the overall time complexity is O(n).

Space complexity: O(n)
The extra space required depends on the number of items stored in the hash table, which stores exactly nn elements.

*/