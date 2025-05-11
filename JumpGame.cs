using System;

class Program
{
    static void Main()
    {
        int[] nums = {2,3,1,1,4};
        Console.WriteLine(CanJump(nums));
    }

    static bool CanJump(int[] nums)
    {
        return JumpHelper(nums, 0);
    }
    
    static bool JumpHelper(int[] nums, int index)
    {
        if(index >= nums.Length - 1) return true;
        
        int maxJump = nums[index];
        for(int i = 1; i <= maxJump; i++)
        {
            if(JumpHelper(nums, index + i))
            {
                return true;
            }
        }
        return false;
    }
} 