

# Method: Sort by Row  108 ms 44%
# Runtime: 48 ms, faster than 96.83% of Python3 online submissions for Zigzag Conversion.
# Memory Usage: 14.2 MB, less than 87.81% of Python3 online submissions for Zigzag Conversion.

class Solution:
    def convert(self, s: str, numRows: int) -> str:
        if numRows == 1:
            return s
        
        rows =  [""] * numRows  # == ['' for _ in range(numRows)]
        cur_row = 0
        forward = True
        
        for i in range(len(s)):
            rows[cur_row] += s[i]

            if forward:
                cur_row+=1
            else:
                cur_row-=1
                
            if forward and cur_row == numRows - 1:
                forward = False
            if not forward and cur_row == 0:
                forward = True
                
        return "".join(rows)

# Test cases
if __name__ == "__main__":
    print("Pass" if Solution().convert("PAYPALISHIRING", 2) == "PYAIHRNAPLSIIG" else "Fail") 
    print("Pass" if Solution().convert("PAYPALISHIRING", 3) == "PAHNAPLSIIGYIR" else "Fail") 
    print("Pass" if Solution().convert("PAYPALISHIRING", 4) == "PINALSIGYAHRPI" else "Fail") 


# Complexity Analysis

# Time Complexity: O(n) , where n = len(s)

# Space Complexity: O(n)
# Stored n Rows of hash table.

