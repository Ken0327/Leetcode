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