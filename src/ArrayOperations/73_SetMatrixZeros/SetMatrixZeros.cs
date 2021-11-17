
/**
Runtime: 148 ms, faster than 59.40% of C# online submissions for Set Matrix Zeroes.
Memory Usage: 43.5 MB, less than 41.39% of C# online submissions for Set Matrix Zeroes.
 */

public class Solution {
    public void SetZeroes(int[][] matrix) 
    {
        bool isFirstRowZeros = false;
        bool isFirstColumnZeros = false;
        
        for(int i = 0; i < matrix.Length ; i++)
        {
            for(int j = 0; j < matrix[i].Length ; j++)
            {
                if(matrix[i][j] == 0)
                {
                    if(i == 0 || j == 0)
                    {
                        if(i == 0)
                            isFirstRowZeros = true;
                        
                        if(j == 0)
                            isFirstColumnZeros = true;
                        
                        continue;
                    }
                    
                    matrix[i][0] = 0;
                    matrix[0][j] = 0;
                }
            }
        }
        
        for(int j = 1; j < matrix[0].Length; j++)
        {
            if( matrix[0][j] == 0)
            {
                for(int row = 0; row < matrix.Length ; row++)
                    matrix[row][j] = 0;
            }
        }
        
        for(int i = 1; i < matrix.Length; i++)
        {
            if( matrix[i][0] == 0)
            {
                for(int col = 0; col < matrix[i].Length ; col++)
                    matrix[i][col] = 0;
            }
        }
        
        if(isFirstColumnZeros)
        {
            for(int i = 0; i < matrix.Length; i++)
            {
                matrix[i][0] = 0;
            }
        }
        
        if(isFirstRowZeros)
        {
            for(int i = 0; i < matrix[0].Length; i++)
            {
                matrix[0][i] = 0;
            }   
        }
    }
}

/*
Complexity Analysis

Time complexity : O(M×N)

Space complexity : O(1).

*/