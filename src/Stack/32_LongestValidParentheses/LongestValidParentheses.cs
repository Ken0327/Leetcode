
/*
Using Stack
Runtime: 80 ms, faster than 46.87% of C# online submissions for Longest Valid Parentheses.
Memory Usage: 38.8 MB, less than 8.72% of C# online submissions for Longest Valid Parentheses.
*/

public class Solution {
    public int LongestValidParentheses(string s) {
        var maxLength = 0;
        var stack = new Stack();
        stack.Push(-1);
        for (var i = 0; i < s.Length; i++){
            if (s[i] == '('){
                stack.Push(i);
            }
            else
            {
                stack.Pop();
                if (stack.Count != 0){
                    if (s[i] == ')'){
                        maxLength = Math.Max(maxLength, i - (int)stack.Peek());
                    }
                } else{
                    stack.Push(i);
                }
            }
        }
        return maxLength;
    }
}

/*
Complexity Analysis

Time complexity: O(n). 
n is the length of the given string.

Space complexity: O(n). 
The size of stack can go up to nn.

*/