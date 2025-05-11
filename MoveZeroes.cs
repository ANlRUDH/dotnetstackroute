using System;

class Program
{
    static void Main()
    {
        int[] nums = {0,1,0,3,12};
        MoveZeroes(nums);
        Console.WriteLine(string.Join(",", nums));
    }

    static void MoveZeroes(int[] nums)
    {
        int[] temp = new int[nums.Length];
        int j = 0;
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] != 0)
            {
                temp[j] = nums[i];
                j++;
            }
        }
        
        for(int i = 0; i < nums.Length; i++)
        {
            nums[i] = temp[i];
        }
    }
} 