using System;

class Program
{
    static void Main()
    {
        int[] nums = {1,2,3,1};
        Console.WriteLine(Rob(nums));
    }

    static int Rob(int[] nums)
    {
        return RobHelper(nums, 0);
    }
    
    static int RobHelper(int[] nums, int index)
    {
        if(index >= nums.Length) return 0;
        
        return Math.Max(
            nums[index] + RobHelper(nums, index + 2),
            RobHelper(nums, index + 1)
        );
    }
} 