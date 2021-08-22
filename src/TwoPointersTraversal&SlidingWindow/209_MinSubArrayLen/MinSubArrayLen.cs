// Two Pointer

// First method 444ms
public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int start = 0;
        int end = 0;
        int n = nums.Length;
        int minlength = 100000;
        while (end < n) {
            int sum = 0;
            for (int i = start; i < end + 1; i++) {
                sum += nums[i];
            }
            if (sum >= target) {
                var length = end - start + 1;
                minlength = Math.Min(minlength, length);
                start++;
            }
            else {
                end++;
            }
        }
        if (minlength == 100000)
            return 0;
        return minlength;
    }
}


// Better method 92ms
public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int left = 0;
        int minlength = int.MaxValue;
        int sum = 0;
        for (int i = 0; i < nums.Length; i++){
            sum += nums[i];
            while (sum >= target){
                minlength = Math.Min(minlength, i + 1 - left);
                sum -= nums[left];
                left++;
            }
        }
        return minlength == int.MaxValue? 0 : minlength;
    }
}

/*
Time complexity: O(n). Single iteration of O(n)
Each element can be visited atmost twice, once by the right pointer(i) and once by the left pointer.

Space complexity: O(1)
extra space. Only constant space required for left, sum, minlength and i.

*/