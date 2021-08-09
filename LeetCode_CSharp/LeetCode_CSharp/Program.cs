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

        public static Node CopyRandomList(Node head)
        {
            if (head == null)
                return head;

            var copy = head;
            while (copy != null)
            {
                var next = copy.next;
                copy.next = new Node(copy.val);
                copy.next.next = next;
                copy = next;
            }

            copy = head;
            while (copy != null)
            {
                if (copy.random != null)
                {
                    copy.next.random = copy.random;
                }
            }

            copy = head;
            var copyHead = head.next;
            var copy2 = copyHead;
            while (copy2.next != null)
            {
                copy.next = copy.next.next;
                copy = copy.next;

                copy2.next = copy2.next.next;
                copy2 = copy2.next;
            }
            copy.next = copy.next.next;

            return copyHead;
        }

        // Definition for a Node.
        public class Node
        {
            public int val;
            public Node next;
            public Node random;

            public Node(int _val)
            {
                val = _val;
                next = null;
                random = null;
            }
        }
    }
}
