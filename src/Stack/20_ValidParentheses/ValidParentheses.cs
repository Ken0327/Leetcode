
/*
Runtime: 68 ms, faster than 98.42% of C# online submissions for Valid Parentheses.
Memory Usage: 37.5 MB, less than 39.06% of C# online submissions for Valid Parentheses.
*/

public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == '[' || s[i] == '(' || s[i] == '{')
                stack.Push(s[i]);
            else
            {
                if (stack.Count == 0){
                    return false;
                }
                else
                {
                    if (s[i] == ']' && stack.Pop() != '[')
                    {
                        return false;
                    }
                    else if (s[i] == ')' && stack.Pop() != '(')
                    {
                        return false;
                    }
                    else if (s[i] == '}' && stack.Pop() != '{')
                    {
                        return false;
                    }      
                }
            }
        }
        return stack.Count() == 0;
    }
}

/*
Complexity Analysis

Time Complexity: O(n) , where n = len(s)

Space Complexity: O(n)
Stored n Rows of Stack.

*/