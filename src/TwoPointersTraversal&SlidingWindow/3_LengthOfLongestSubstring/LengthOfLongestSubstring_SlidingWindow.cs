// Sliding Window
// Hash+双指针滑动窗口 o(n)

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int left = 0;
        int right = 0;
        int maxLength = 0;
        var dic = new Dictionary<string, int>();
        while (right < s.Length)
        {
            var index = -1;
            if (dic.ContainsKey(s[right].ToString()))
            {
                index = dic[s[right].ToString()];
                dic.Remove(s[right].ToString());
            }
            dic.Add(s[right].ToString(), right);
            if (index != -1 && index >= left)
            {
                left = index + 1;
            }
            if (right - left + 1 > maxLength)
            {
                maxLength = right - left + 1;
            }
            right++;
        }
        return maxLength;
    }
}


// Reference https://blog.techbridge.cc/2019/09/28/leetcode-pattern-sliding-window/