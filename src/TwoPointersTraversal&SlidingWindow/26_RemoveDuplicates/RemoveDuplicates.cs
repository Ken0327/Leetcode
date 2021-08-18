// two pointer

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0)
            return nums.Length;
        int curr = 0;
        for (int i = 1; i< nums.Length; i++){
            if (nums[i] != nums[curr]){
                curr++;
                nums[curr] = nums[i];
            }
        }
        return curr + 1;
    }
}

/*
Time complexity: O(n)
go through n times of nums array

Space complexity: O(1)

*/