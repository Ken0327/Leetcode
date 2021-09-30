
/**
brute force
time exceed
 */

public class Solution {
    public int trailingZeroes(int num) {
        int rs = 0;
        for (int i = 1; i <= num; i++) {
            int j = i;
            while (j % 5 == 0) {
                rs++;
                j /= 5;
            }
        }
        return rs;
    }
}

/*
Complexity Analysis

Time complexity : O(n)
Space complexity : O(1)

*/


/**
Approach 2: Find the factor count of power of 5.
40 ms, faster than 79.90%
 */

public class Solution {
    public int TrailingZeroes(int n) {
        int count = 0;
        while (n > 0){
            count += n / 5;
            n = n / 5;
        }
        return count;
    }
}

/*
Complexity Analysis

Time complexity : O(log(n))
Space complexity : O(1)

*/