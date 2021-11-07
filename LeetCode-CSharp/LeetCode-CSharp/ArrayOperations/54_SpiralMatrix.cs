using System.Collections.Generic;

namespace LeetCode_CSharp.ArrayOperations
{
    class _54_SpiralMatrix
    {
        public IList<int> SpiralOrder(int[,] matrix)
        {
            IList<int> result = new List<int>();
            if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
                return result;

            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);
            var visited = new bool[m, n];

            int i = 0;
            int j = 0;
            int direction = 1;

            while (true)
            {
                if (i < 0 || j < 0 || i == m || j == n || visited[i, j])
                    break;

                result.Add(matrix[i,j]);
                visited[i, j] = true;
                switch (direction)
                {
                    case 1:
                        if (j + 1 == n || visited[i, j + 1])
                        {
                            i++;
                            direction = 2;
                        }
                        else
                        {
                            j++;
                        }
                        break;
                    case 2:
                        if (i + 1 == m || visited[i + 1, j])
                        {
                            j--;
                            direction = 3;
                        }
                        else
                        {
                            i++;
                        }
                        break;
                    case 3:
                        if (j == 0 || visited[i, j - 1])
                        {
                            i--;
                            direction = 4;
                        }
                        else
                        {
                            j--;
                        }
                        break;
                    case 4:
                        if (i == 0 || visited[i - 1, j])
                        {
                            j++;
                            direction = 1;
                        }
                        else
                        {
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
}