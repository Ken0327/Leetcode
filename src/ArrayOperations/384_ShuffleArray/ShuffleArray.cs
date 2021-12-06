
/*
Runtime: 224 ms, faster than 60.70% of C# online submissions for Shuffle an Array.
Memory Usage: 54.4 MB, less than 41.75% of C# online submissions for Shuffle an Array.
*/
public class Solution {
    int[] array;
    int[] original;
    Random rand = new Random();
    
    public Solution(int[] nums) {
        array = nums;     
        original = (int[])nums.Clone();
    }
    
    public int[] Reset() {
        return original;
    }
    
    public int[] Shuffle() {
        var aux = array.ToList();
        
        for (var i =0; i < array.Count(); i++){
            var removeIndex = rand.Next(aux.Count());
            array[i] = aux[removeIndex];
            aux.RemoveAt(removeIndex);
        }
        
        return array;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int[] param_1 = obj.Reset();
 * int[] param_2 = obj.Shuffle();
 */


/*
Complexity Analysis

Time complexity : O(n^2)

The quadratic time complexity arises from the calls to list.remove (or list.pop), which run in linear time. 
n linear list removals occur, which results in a fairly easy quadratic analysis.

Space complexity : O(n)

Because the problem also asks us to implement reset, we must use linear additional space to store the original array. 
Otherwise, it would be lost upon the first call to shuffle.

*/