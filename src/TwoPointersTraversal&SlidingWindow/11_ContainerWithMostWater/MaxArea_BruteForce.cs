// Brute Force

public class Solution {
    public int MaxArea(int[] height) 
    {
        var start =0;
        var end =height.Count()-1;
        var maxArea =0;
        while (end > start) 
        {
            
            var l = end - start;
            var h = Math.Min(height[end], height[start]);
            var area = l*h;
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

/*
Time complexity: O(n^2)
The algorithm makes two traversal of the list, there are n(n-1)/2 operations and time complexity is O(n^2).
ex: n + (n-1) + .... + 1 = n(n-1)/2

Space complexity : O(1)
We only use constant extra space. 

*/