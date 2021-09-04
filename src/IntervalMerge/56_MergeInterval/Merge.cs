
/**
 * 先根据start进行排序之后merge o(n*log(n)) 248 ms 95%
 */

public class Solution {
    public int[][] Merge(int[][] intervals) {
        if (intervals.Length <= 1)
            return intervals;
        
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        int[] curr = intervals[0];
        var output = new List<int[]>();
        output.Add(curr);
        
        foreach (var interval in intervals){
            var currEnd = curr[1];
            var nextStart = interval[0];
            var nextEnd = interval[1];
            
            if (currEnd >= nextStart){
                curr[1] = Math.Max(currEnd, nextEnd);
            }
            else{
                curr = interval;
                output.Add(curr);
            }      
        }
        return output.ToArray();;
    }
}

/*
Complexity Analysis

Time complexity : O(nlogn)

Other than the sort invocation, we do a simple linear scan of the list, 
so the runtime is dominated by the O(nlogn) complexity of sorting.

Space complexity : O(logN) or O(n)

If we can sort intervals in place, we do not need more than constant additional space, 
although the sorting itself takes O(logn) space. Otherwise, 
we must allocate linear space to store a copy of intervals and sort that.

*/