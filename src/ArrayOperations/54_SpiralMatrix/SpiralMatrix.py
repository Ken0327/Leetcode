# 方向变量模拟路径 o(n)

class Solution:
    def spiralOrder(self, matrix: List[List[int]]) -> List[int]:
        
        if (len(matrix) * len(matrix[0]) == 0):
            return []
        
        top = 0
        left = 0
        bottom = len(matrix) - 1
        right = len(matrix[0]) - 1 
        size = len(matrix) * len(matrix[0])
        
        out = []
        
        
        while(len(out) < size):
            
            for i in range(left, right+ 1):
                if (len(out) < size):
                    out.append(matrix[top][i])
            top += 1
            
            
            for i in range(top, bottom +1):
                if (len(out) < size):
                    out.append(matrix[i][right])
                
            right -= 1
            
            
            for i in range(right, left-1, -1):
                if (len(out) < size):
                    out.append(matrix[bottom][i])
                    
            bottom -= 1
            
            for i in range(bottom, top-1, -1):
                if (len(out) < size):
                    out.append(matrix[i][left])
            
            left += 1
            
            
            print(out)
            
        return out