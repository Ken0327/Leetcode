// Iterative
public class Solution {
    public int Fib(int n) 
    {
        if (n <= 1)
        {
            return n;
        }

        int a = 0, b = 1;

        while (n-- > 1)
        {
            var sum = a + b;
            a = b;
            b = sum;
        }
        return b;
    }
}

/*
Time complexity: O(n)
Space complexity: O(1)
*/