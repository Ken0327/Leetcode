using System;

namespace LeetCode_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }

        public static int FirstUniqChar(string s)
        {
            var hash1 = new Hashtable();
            var hash2 = new Hashtable();
            for (var i = 0; i < s.Length; i++)
            {
                if (hash1.ContainsKey(s[i]))
                {
                    hash2[s[i]] = int.Parse(hash2[s[i]].ToString()) + 1;
                }
                else
                {
                    hash2[s[i]] = 1;
                }
                hash1.Add(i, s[i]);
            }
            foreach (var i in hash2)
            {
                if (int.Parse(i.Value.ToString()) == 1)
                {
                    return s.IndexOf(i.Key);
                }
            }
            return -1;
        }
    }
}
