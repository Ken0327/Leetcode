// Sliding Window
// int[]塞char + 双指针滑动窗口 o(n)  最快

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int left = 0;
        int right = 0;
        int maxLength = 0;
        var chars = new int[128];
        while (right < s.Length)
        {
            char r = s[right];
            chars[r]++;

            while (chars[r] > 1)
            {
                var l = s[left];
                chars[l]--;
                left++;
            }
            maxLength = Math.Max(maxLength, right - left + 1);
            right++;
        }
        return maxLength;
    }
}