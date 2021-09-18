
/**
o(n) 重点还是判断溢出
92 ms, faster than 34.66%
 */

public class Solution {
    public int MyAtoi(string s) {
        s = s.Trim();
        int sign = 1;
        long res = 0;
        int n = 0;
        
        if (string.IsNullOrEmpty(s))
            return 0;
        
        if (s[0] == '+' || s[0] == '-')
        {
            sign = s[0] == '+'? 1 : -1;   
            n++;
        }

        for (int i= n; i < s.Length; i++)
        {
            if (s[i] == '.')
                return sign * (int)res;
            if (char.IsNumber(s[i]))
            {
                res = res * 10 + s[i] - '0';
                if (res * sign > int.MaxValue) return int.MaxValue;
                if (res * sign < int.MinValue) return int.MinValue;
            } 
            else
                break;
        }
        return sign * (int)res; 
    }
}

/*
Complexity Analysis

Time complexity : O(n)

Space complexity : O(1)

*/