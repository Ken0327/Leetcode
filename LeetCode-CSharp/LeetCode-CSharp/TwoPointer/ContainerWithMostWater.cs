using System;
using System.Linq;

namespace LeetCode_CSharp.TwoPointer
{
    class ContainerWithMostWater
    {
        public int MaxArea_BruteForce(int[] height)
        {
            var maxArea = 0;
            for (int i = 0; i < height.Count(); i++)
            {
                for (int j = i + 1; j < height.Count(); j++)
                {
                    var l = j - i;
                    var h = Math.Min(height[i], height[j]);
                    maxArea = Math.Max(maxArea, l * h);
                }
            }
            return maxArea;
        }

        public int MaxArea_SlidingWindow(int[] height)
        {
            var start = 0;
            var end = height.Count() - 1;
            var maxArea = 0;
            while (end > start)
            {

                var l = end - start;
                var h = Math.Min(height[end], height[start]);
                var area = l * h;
                if (area > maxArea)
                {
                    maxArea = area;
                }
                if (height[end] > height[start])
                {
                    start++;
                }
                else
                {
                    end--;
                }
            }
            return maxArea;
        }
    }
}