// Sliding Window

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
Hint:
Start with the maximum width container and go to a shorter width container 
if there is a vertical line longer than the current containers shorter line. 
This way we are compromising on the width but we are looking forward to a longer length container.

Time complexity: O(n)
The algorithm makes one traversal of the list, there are n  operations and time complexity is O(n).

Space complexity : O(1)
We only use constant extra space. 

*/