using System;

class Program
{
    static void Main()
    {
        int[] nums = {1,2,3,1};
        bool result = ContainsDuplicate(nums);
        Console.WriteLine(result);
    }

    static bool ContainsDuplicate(int[] nums)
    {
        Array.Sort(nums);
        for(int i = 0; i < nums.Length - 1; i++)
        {
            if(nums[i] == nums[i + 1])
            {
                return true;
            }
        }
        return false;
    }
} 