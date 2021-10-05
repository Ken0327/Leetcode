
/**
Runtime: 64 ms, faster than 14.01%
 */

public class Solution {
    public int AddDigits(int num) {
        var digitRoot = 0;
        while (num > 0) {
            digitRoot += num % 10;
            num = num / 10;
            if (num == 0 && digitRoot / 10 > 0){
                num = digitRoot;
                digitRoot = 0;
            }
        }
        return digitRoot;
    }
}

/*
Complexity Analysis

Time complexity : O(n), n is length of num digits
Space complexity : O(1)

*/


/**
Approach 2: Mathematical: Digital Root
Runtime: 64 ms, faster than 14.01% 

How to derive it? Probably, you already know the following proof from school, where it was used for a divisibility by 9: 
"The original number is divisible by 9 if and only if the sum of its digits is divisible by 9". 
*/

public class Solution {
    public int AddDigits(int num) {
        if (num == 0) return 0;
        if (num % 9 == 0) return 9;
        return num % 9;
    }
}
/*
Complexity Analysis

Time complexity : O(1)
Space complexity : O(1)

*/