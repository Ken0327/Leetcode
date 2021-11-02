// 方向变量模拟路径 o(n)

public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) 
    {
        IList<int> result = new List<int>();
        if (matrix.Length == 0 || matrix[0].Length == 0)
            return result;
        
        int m = matrix.Length;
        int n = matrix[0].Length;
        var visited = new bool[m, n];
        
        int i = 0;
        int j = 0;
        int direction = 1;
        
        while (true)
        {
            if (i < 0 || j < 0 || i == m || j == n || visited[i, j])
                break;
                 
            result.Add(matrix[i][j]);
            visited[i, j] = true;
            switch (direction)
            {
                case 1:
                    if (j + 1 == n || visited[i, j + 1]){
                        i++;
                        direction = 2;
                    } 
                    else {
                        j++;
                    }
                    break;
                case 2:
                    if (i + 1 == m || visited[i + 1, j]){
                        j--;
                        direction = 3;
                    } else{
                        i++;
                    }
                    break;
                case 3:
                    if (i == 0 || visited[i, j - 1]){
                        i--;
                        direction = 4;
                    } else{
                        j--;
                    }
                    break;
                case 4:
                    if (j == 0 || visited[i - 1, j]){
                        j++;
                        direction = 4;
                    } else{
                        i--;
                    }
                    break;
                default:
                    break;
            }
        }
        return result;
    }
}