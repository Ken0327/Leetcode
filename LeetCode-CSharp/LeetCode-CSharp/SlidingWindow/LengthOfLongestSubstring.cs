using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode_CSharp.SlidingWindow
{
    class LengthOfLongestSubstring
    {
        public int LengthOfLongestSubstring_Rude(string s)
        {
            if (s == "")
                return 0;
            if (s == " ")
                return 1;
            string newStr = "";
            int longestLength = 0;
            for (int i = 0; i < s.Length; i++)
            {
                newStr = s[i].ToString();
                if (newStr.Length > longestLength)
                    longestLength = newStr.Length;
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (newStr.Contains(s[j]))
                    {
                        if (newStr.Length > longestLength)
                            longestLength = newStr.Length;
                        newStr = "";
                        break;
                    }
                    else
                    {
                        newStr += s[j].ToString();
                        if (newStr.Length > longestLength)
                            longestLength = newStr.Length;
                    }
                }
            }
            return longestLength;
        }

        public int LengthOfLongestSubstring_SlidingWindow(string s)
        {
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

        public int LengthOfLongestSubstring_SlidingWindow2(string s)
        {
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
}