// Slot Fast pointer 87 ms
public class Solution {
    public bool IsHappy(int n) {
        int slow = n;
        int fast = getNext(n);
        while (fast != 1 && slow != fast){
            slow = getNext(slow);
            fast = getNext(getNext(fast));
        }
        return fast == 1;
    }
    
    private int getNext(int n){
        var sum = 0;
        while (n > 0){
            int d = n % 10;
            n = n / 10;
            sum += d*d;
        }
        return sum;
    }
}

/*
Complexity Analysis

Time complexity : O(log n). 
Builds on the analysis for the previous approach, 
except this time we need to analyse how much extra work is done by keeping track of two places instead of one, 
and how many times they'll need to go around the cycle before meeting.

If there is no cycle, then the fast runner will get to 1, and the slow runner will get halfway to 1. 
Because there were 2 runners instead of 1, we know that at worst, the cost was O(2logn) = O(logn).

Like above, we're treating the length of the chain to the cycle as insignificant compared to the cost of calculating 
the next value for the first n. Therefore, 
the only thing we need to do is show that the number of times the runners go back over previously seen numbers in the chain is constant.

Once both pointers are in the cycle (which will take constant time to happen) 
the fast runner will get one step closer to the slow runner at each cycle. 
Once the fast runner is one step behind the slow runner, they'll meet on the next step. Imagine there are kk numbers in the cycle. 
If they started at k −1 places apart (which is the furthest apart they can start), 
then it will take k −1 steps for the fast runner to reach the slow runner, which again is constant for our purposes. 
Therefore, the dominating operation is still calculating the next value for the starting n, which is O(logn).


Space complexity : O(1). 
For this approach, we don't need a HashSet to detect the cycles. 
The pointers require constant extra space.
*/