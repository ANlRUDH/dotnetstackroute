using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[][] intervals = new int[][] {
            new int[] {1,3},
            new int[] {2,6},
            new int[] {8,10},
            new int[] {15,18}
        };
        var result = Merge(intervals);
        foreach(var interval in result)
        {
            Console.WriteLine($"[{interval[0]}, {interval[1]}]");
        }
    }

    static int[][] Merge(int[][] intervals)
    {
        if(intervals.Length == 0) return intervals;
        
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        var result = new List<int[]>();
        var current = intervals[0];
        
        for(int i = 1; i < intervals.Length; i++)
        {
            if(current[1] >= intervals[i][0])
            {
                current[1] = Math.Max(current[1], intervals[i][1]);
            }
            else
            {
                result.Add(current);
                current = intervals[i];
            }
        }
        result.Add(current);
        
        return result.ToArray();
    }
} 