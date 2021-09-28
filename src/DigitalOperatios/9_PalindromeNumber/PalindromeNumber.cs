
/**
hash table
56 ms, faster than 93.5%
 */

public class Solution {
    public bool IsPalindrome(int x) {
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
}

/*
Complexity Analysis

Time complexity : O(n)
Space complexity : O(n)

*/


/**
Approach 2: Revert half of the number
76 ms, faster than 45.59% 
 */

public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0 || (x % 10 == 0 && x != 0))
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

/*
Complexity Analysis

Time complexity : O(log(n))
Space complexity : O(1)

*/