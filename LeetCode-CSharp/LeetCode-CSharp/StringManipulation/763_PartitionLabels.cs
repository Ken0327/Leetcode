using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode_CSharp.StringManipulation
{
    class _763_PartitionLabels
    {
        public IList<int> PartitionLabel(string s)
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
}