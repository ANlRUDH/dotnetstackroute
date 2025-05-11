using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[][] matrix = new int[][] {
            new int[] {1,2,3},
            new int[] {4,5,6},
            new int[] {7,8,9}
        };
        var result = SpiralOrder(matrix);
        Console.WriteLine(string.Join(",", result));
    }

    static IList<int> SpiralOrder(int[][] matrix)
    {
        var result = new List<int>();
        int top = 0, bottom = matrix.Length - 1;
        int left = 0, right = matrix[0].Length - 1;
        
        while(top <= bottom && left <= right)
        {
            for(int i = left; i <= right; i++)
            {
                result.Add(matrix[top][i]);
            }
            top++;
            
            for(int i = top; i <= bottom; i++)
            {
                result.Add(matrix[i][right]);
            }
            right--;
            
            if(top <= bottom)
            {
                for(int i = right; i >= left; i--)
                {
                    result.Add(matrix[bottom][i]);
                }
                bottom--;
            }
            
            if(left <= right)
            {
                for(int i = bottom; i >= top; i--)
                {
                    result.Add(matrix[i][left]);
                }
                left++;
            }
        }
        return result;
    }
} 