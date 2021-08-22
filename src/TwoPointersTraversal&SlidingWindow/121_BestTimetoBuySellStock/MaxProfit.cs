// two pointer

public class Solution {
    public int MaxProfit(int[] prices) {
        int MaxProfit = 0;
        int start = 0;
        int end = 1;
        while (end < prices.Length){
            int profit = prices[end] - prices[start];
            if (profit == 0)
                end++;
            else if (profit < 0){
                start++;
            }
            else {
                MaxProfit = Math.Max(MaxProfit, prices[end] - prices[start]);
                end++;
            }
        }
        return MaxProfit;
    }
}

/*
Time complexity: O(n)
Two pointer by using 1 iterations of O(n).

Space complexity: O(1)
Only two variable used.

*/

// Faster method
public class Solution {
    public int MaxProfit(int[] prices) {
        var minPrice = 10000;
        var maxProfit = 0;
        
        foreach (var price in prices) {
            if (price < minPrice) {
                minPrice = price;
            } else if (price - minPrice > maxProfit) {
                maxProfit = price - minPrice;
            }           
        }
        
        return maxProfit;
    }
}