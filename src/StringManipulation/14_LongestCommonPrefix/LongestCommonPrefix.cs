
/**
Horizontal scanning 92 ms >97%
 */

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 1 || strs[0] == "")
            return strs[0];
        
        var commStr = strs[0];
        for (int i= 1; i < strs.Length; i++){
            if (strs[i] == "")
                return "";
            
            var str = "";
            for (int j= 0; j < Math.Min(strs[i].Length, commStr.Length); j++){
                if (strs[i][j] == commStr[j]){
                    str += strs[i][j];
                }
                else
                    break;
            }
            commStr = str;
        }
        return commStr;
    }
}

/*
Complexity Analysis

Time complexity : O(S), where S is the sum of all characters in all strings.

In the worst case all nn strings are the same. The algorithm compares the string S1S1 with the other strings 
There are SS character comparisons, where SS is the sum of all characters in the input array.


Space complexity : O(1).

We only used constant extra space.


*/