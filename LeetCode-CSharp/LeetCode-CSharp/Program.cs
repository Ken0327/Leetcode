using LeetCode_CSharp.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, this is LeetCode Challenge.");
            bool isRun = true;
            while (isRun)
            {
                Console.WriteLine("Please insert Topic Number");
                int topic = 0;
                topic = int.Parse(Console.ReadLine());
                chooseTopic(topic);
                Console.WriteLine("Finished");
                Console.WriteLine("Would you continue? Yes = 1");
                if (Console.ReadLine() == "1")
                    isRun = true;
                else
                    isRun = false;
            }
        }

        static void chooseTopic(int topic)
        {
            switch (topic)
            {
                case 3:
                    Console.WriteLine("3. Longest Substring Without Repeating Characters");
                    var lengthOfLongestSubstring = new SlidingWindow.LengthOfLongestSubstring();
                    var input3 = "abcabcbb";
                    Console.WriteLine($"Input = {input3}, expect output = 3");
                    var output3 = lengthOfLongestSubstring.LengthOfLongestSubstring_Rude(input3);
                    Console.WriteLine($"Output = {output3}");
                    output3 = lengthOfLongestSubstring.LengthOfLongestSubstring_SlidingWindow (input3);
                    Console.WriteLine($"Output = {output3}");
                    output3 = lengthOfLongestSubstring.LengthOfLongestSubstring_SlidingWindow2(input3);
                    Console.WriteLine($"Output = {output3}");
                    break;
                case 206:
                    var input206 = new ListNode(1);
                    input206.next = new ListNode(2);
                    input206.next.next = new ListNode(3);
                    var reverseList = new LinkedList.ReverseList();
                    var output206 = reverseList.reverseList(input206);
                    Console.WriteLine($"Output = {output206}");
                    break;
                default:
                    break;
            }
        }
    }
}
