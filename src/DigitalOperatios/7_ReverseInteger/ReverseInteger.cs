
/**
Approach 1: Pop and Push Digits & Check before Overflow
67 ms >14%
 */

public class Solution {
    public int Reverse(int x) {
        int rev = 0;
        while (x != 0){
            int pop = x % 10;
            x = x / 10;
            if (rev > Int32.MaxValue / 10 || rev < Int32.MinValue / 10)
                return 0;
            rev = rev * 10 + pop;
        }
        return rev;
    }
}

/*
Complexity Analysis

Time complexity : O(log(x))
There are roughly log(x) digits in x.

Space complexity : O(1)

*/