public class Solution {
    public int FirstUniqChar(string s) {
        Dictionary<char, int> dic = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (dic.ContainsKey(c))
                dic[c] += 1;
            else
                dic.Add(c, 1);
        }

        for(int i = 0; i < s.Length; i++)
            if (dic[s[i]] == 1)
                return i;

        return -1;
    }
}


/*
Complexity Analysis

Time complexity : {O}(N) 
since we go through the string of length N two times.

Space complexity : {O}(1) 
because English alphabet contains 26 letters.

*/