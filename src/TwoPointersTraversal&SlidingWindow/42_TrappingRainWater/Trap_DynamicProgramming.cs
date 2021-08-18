//Dynamic Programming

public class Solution {
    public int Trap(int[] height) {
        // Dynamic Programming
        int size = height.Length;
        int[] LeftMax = new int[size];
        int[] RightMax = new int[size];
        int Result = 0;
        
        LeftMax[0] = height[0];
        for (int i = 1; i < size; i++){
            LeftMax[i] = Math.Max(height[i], LeftMax[i - 1]);
        }
        RightMax[size - 1] = height[size - 1];
        for (int i = size - 2; i >= 0; i--){
            RightMax[i] = Math.Max(height[i], RightMax[i + 1]);
        }
        
        int HeightMax = 0;
        for (int i = 0; i < size; i++){
            HeightMax = Math.Max(HeightMax, height[i]);
        }
        
        // LeftMax + RightMax - HeightMax - height
        for (int i = 0; i < size; i++){
            Result += LeftMax[i] + RightMax[i] - HeightMax - height[i];
        }
        return Result;
    }
}

/*
Time complexity: O(n)
We store the maximum heights upto a point using 2 iterations of O(n) each.
We finally update Result using the stored values in O(n).

Space complexity: O(n)
Additional O(n) space for left_max and right_max arrays than in Approach 1.

*/


public class Solution {
    public int Trap(int[] height) {
        // Dynamic Programming
        int size = height.Length;
        int[] LeftMax = new int[size];
        int[] RightMax = new int[size];
        int Result = 0;
        
        LeftMax[0] = height[0];
        for (int i = 1; i < size; i++){
            LeftMax[i] = Math.Max(height[i], LeftMax[i - 1]);
        }
        RightMax[size - 1] = height[size - 1];
        for (int i = size - 2; i >= 0; i--){
            RightMax[i] = Math.Max(height[i], RightMax[i + 1]);
        }
        
        // Better Method to find the insersection
        for (int i = 1; i < size - 1; i++){
            Result += Math.Min(LeftMax[i], RightMax[i]) - height[i];
        }
        return Result;
    }
}