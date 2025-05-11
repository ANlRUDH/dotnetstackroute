using System;

class Program
{
    static void Main()
    {
        int[] nums = {10,9,2,5,3,7,101,18};
        Console.WriteLine(LengthOfLIS(nums));
    }

    static int LengthOfLIS(int[] nums)
    {
        int max = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            max = Math.Max(max, LISHelper(nums, i));
        }
        return max;
    }
    
    static int LISHelper(int[] nums, int index)
    {
        int max = 1;
        for(int i = index + 1; i < nums.Length; i++)
        {
            if(nums[i] > nums[index])
            {
                max = Math.Max(max, 1 + LISHelper(nums, i));
            }
        }
        return max;
    }
} 