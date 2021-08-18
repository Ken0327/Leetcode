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
                    var lengthOfLongestSubstring = new TwoPointer.LengthOfLongestSubstring();
                    var input3 = "abcabcbb";
                    Console.WriteLine($"Input = {input3}, expect output = 3");
                    var output3 = lengthOfLongestSubstring.LengthOfLongestSubstring_Rude(input3);
                    Console.WriteLine($"Output = {output3}");
                    output3 = lengthOfLongestSubstring.LengthOfLongestSubstring_SlidingWindow (input3);
                    Console.WriteLine($"Output = {output3}");
                    output3 = lengthOfLongestSubstring.LengthOfLongestSubstring_SlidingWindow2(input3);
                    Console.WriteLine($"Output = {output3}");
                    break;
                case 11:
                    var containerWithMostWater = new TwoPointer.ContainerWithMostWater();
                    var input11 = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
                    Console.WriteLine($"Input = {input11}, expect output = 49");
                    var output11 = containerWithMostWater.MaxArea_BruteForce(input11);
                    Console.WriteLine($"Output = {output11}");
                    output11 = containerWithMostWater.MaxArea_SlidingWindow(input11);
                    Console.WriteLine($"Output = {output11}");
                    break;
                case 15:
                    var _3sum = new TwoPointer._3Sum();
                    var input15 = new int[] { -1, 0, 1, 2, -1, -4 };
                    Console.WriteLine($"Input = {input15}, expect output = [[-1,-1,2],[-1,0,1]]");
                    var output15 = _3sum.ThreeSum(input15);
                    var ans = "[";
                    foreach (var i in output15)
                    {
                        ans += "[";
                        foreach (var j in i)
                        {
                            ans += j.ToString() + " ";
                        }
                        ans += "], ";
                    }
                    ans += "]";
                    Console.WriteLine($"Output = {ans}");
                    break;
                case 42:
                    var TrappingRainWater = new TwoPointer.TrappingRainWater();
                    var input42 = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
                    Console.WriteLine($"Input = {input42}, expect output = 6");
                    var output42 = TrappingRainWater.Trap(input42);
                    Console.WriteLine($"Output = {output42}");
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
