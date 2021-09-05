
/**
 Method: Sort by Row  108 ms 44%
 */

public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1)
            return s;
        
        var rows = new Dictionary<int, string>();
        bool isForward = true;
        int n = 0;
        for (int i= 0; i < s.Length; i++){
            if (rows.ContainsKey(n))
                rows[n] += s[i].ToString();
            else
                rows[n] = s[i].ToString();
            
            if (isForward)
                n++;
            else
                n--;
            
            if (n == 0 && !isForward)
                isForward= true;
            
            if (n == numRows -1 && isForward)
                isForward = false;
        }
        var result = "";
        for (int i= 0; i < rows.Count; i++){
            result += rows[i];
        }
        return result;
    }
}

/*
Complexity Analysis

Time Complexity: O(n) , where n = len(s)

Space Complexity: O(n)
Stored n Rows of hash table.

*/