// 暴力解
// Complexity O(n^2)
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s == "" )
            return 0;
        if (s == " ")
            return 1;
        string newStr = "";
        int longestLength = 0;
        for (int i =0; i < s.Length; i++)
        {
            newStr = s[i].ToString();
            if (newStr.Length > longestLength)
                longestLength = newStr.Length;
            for (int j =i + 1; j < s.Length; j++)
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
}