
/**
Hashtable  228 ms >77%
 */

public class Solution {
    public IList<int> PartitionLabels(string s)
    {
        Dictionary<char, int> last = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (last.ContainsKey(s[i]))
            {
                last[s[i]] = i;
            }
            else
            {
                last.Add(s[i], i);
            }
        }

        int start = 0;
        int end = 0;
        IList<int> ans = new List<int>();
        for (int j = 0; j < s.Length; j++)
        {
            end = Math.Max(end, last[s[j]]);
            if (j == end)
            {
                ans.Add(end - start + 1);
                start = end + 1;
            }
        }
        return ans;
    }
}

/*
1. Store last index of character
2. Find the size of partition


Complexity Analysis

Time complexity : O(n)

n is length of s, and algorithm run 2n.

Space complexity : O(1)

hashtable stored less than 26 characters. 

*/