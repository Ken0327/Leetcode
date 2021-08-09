using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CSharp.SlidingWindow
{
    class _3Sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();

            Array.Sort(nums);

            for (int i = 0; i < nums.Count() - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
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
                        IList<int> list = new List<int>() { first, nums[start], nums[end] };
                        result.Add(list);
                        end--;
                        start++;
                        while (start < end && nums[start] == nums[start - 1])
                            start++;
                        while (start < end && nums[end] == nums[end + 1])
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
}
