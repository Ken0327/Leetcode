using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CSharp.DigitalOperations
{
    class _9_PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            int input = x;
            int output = 0;
            List<int> numbers = new List<int>();
            while (x != 0)
            {
                numbers.Add(x % 10);
                x = x / 10;
            }

            int n = 1;
            for (int i = numbers.Count(); i > 0; i--)
            {
                output += numbers[i - 1] * n;
                n = n * 10;
            }
            if (input == output)
                return true;
            else
                return false;
        }
        public bool IsPalindrome2(int x)
        {
            if (x < 0)
                return false;

            int revertNumber = 0;
            while (x > revertNumber)
            {
                revertNumber = revertNumber * 10 + x % 10;
                x /= 10;
            }

            return x == revertNumber || x == revertNumber / 10;
        }
    }
}
