
/*
Approach 1: Brute Force

Time Limit Exceeded
*/

public class Solution {
    public int FindUnsortedSubarray(int[] nums) {
        var l = nums.Count();
        var r = 0;
        for (var i = 0; i < nums.Count() - 1; i++){
            for (var j = i + 1; j < nums.Count(); j++){
                if (nums[i] > nums[j]){
                    l = Math.Min(i, l);
                    r = Math.Max(j, r);
                }
            }
        }
        return r - l < 0 ? 0 : r - l + 1;
    }
}

/*
Complexity Analysis

Time complexity : O(n^2). Two nested loops are there.

Space complexity : O(1). Constant space is used.

*/


/*
Approach 2: Using Sorting

Runtime: 198 ms, faster than 15.56% of C# online submissions for Shortest Unsorted Continuous Subarray.
Memory Usage: 38.8 MB, less than 86.67% of C# online submissions for Shortest Unsorted Continuous Subarray.
*/

public class Solution {
    public int FindUnsortedSubarray(int[] nums) {
        int[] sorted = (int[])nums.Clone();
        Array.Sort(sorted);
        var l = nums.Count();
        var r = 0;
        for (var i = 0; i < nums.Count(); i++){
            if (nums[i] != sorted[i]){
                l = Math.Min(i, l);
                r = Math.Max(i, r);
            }
        }
        return r - l < 0 ? 0 : r - l + 1;
    }
}

/*
Complexity Analysis

Time complexity : O(nlogn). Sorting takes n\log nnlogn time.

Space complexity : O(n). We are making copy of original array.

*/