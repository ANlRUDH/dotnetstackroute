using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] nums = {1,1,2,2,3,3,4};
        int k = RemoveDuplicates(nums);
        Console.WriteLine(k);
    }

    static int RemoveDuplicates(int[] nums)
    {
        if(nums.Length == 0) return 0;
        
        var unique = new List<int>();
        unique.Add(nums[0]);
        
        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[i] != nums[i-1])
            {
                unique.Add(nums[i]);
            }
        }
        
        for(int i = 0; i < unique.Count; i++)
        {
            nums[i] = unique[i];
        }
        
        return unique.Count;
    }
} 