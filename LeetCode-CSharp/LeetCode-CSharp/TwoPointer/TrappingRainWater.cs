using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CSharp.TwoPointer
{
    class TrappingRainWater
    {
        public int Trap(int[] height)
        {
            // Dynamic Programming
            int size = height.Length;
            int[] LeftMax = new int[size];
            int[] RightMax = new int[size];
            int Result = 0;

            LeftMax[0] = height[0];
            for (int i = 1; i < size; i++)
            {
                LeftMax[i] = Math.Max(height[i], LeftMax[i - 1]);
            }
            RightMax[size - 1] = height[size - 1];
            for (int i = size - 2; i >= 0; i--)
            {
                RightMax[i] = Math.Max(height[i], RightMax[i + 1]);
            }

            // Better Method to find the insersection
            for (int i = 1; i < size - 1; i++)
            {
                Result += Math.Min(LeftMax[i], RightMax[i]) - height[i];
            }
            return Result;
        }
    }
}
