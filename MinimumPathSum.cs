using System;

class Program
{
    static void Main()
    {
        int[][] grid = new int[][] {
            new int[] {1,3,1},
            new int[] {1,5,1},
            new int[] {4,2,1}
        };
        Console.WriteLine(MinPathSum(grid));
    }

    static int MinPathSum(int[][] grid)
    {
        return MinPathHelper(grid, 0, 0);
    }
    
    static int MinPathHelper(int[][] grid, int i, int j)
    {
        if(i == grid.Length - 1 && j == grid[0].Length - 1)
            return grid[i][j];
            
        if(i >= grid.Length || j >= grid[0].Length)
            return int.MaxValue;
            
        return grid[i][j] + Math.Min(
            MinPathHelper(grid, i+1, j),
            MinPathHelper(grid, i, j+1)
        );
    }
} 