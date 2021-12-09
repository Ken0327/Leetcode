using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode_CSharp.ArrayOperations
{
    class _954_MinIncrementForUnique
    {
        public int MinIncrementForUnique(int[] nums)
        {
            var times = 0;

            Array.Sort(nums);

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

        public int MinIncrementForUnique1(int[] nums)
        {
            Array.Sort(nums);
            int result = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] <= nums[i - 1])
                {
                    result = result + nums[i - 1] - nums[i] + 1;
                    nums[i] = nums[i - 1] + 1;
                }
            }

            return result;
        }
    }
}