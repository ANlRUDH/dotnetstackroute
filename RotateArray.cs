using System;

class Program
{
    static void Main()
    {
        int[] nums = {1,2,3,4,5,6,7};
        int k = 3;
        Rotate(nums, k);
        Console.WriteLine(string.Join(",", nums));
    }

    static void Rotate(int[] nums, int k)
    {
        k = k % nums.Length;
        int[] temp = new int[nums.Length];
        
        for(int i = 0; i < nums.Length; i++)
        {
            int newIndex = (i + k) % nums.Length;
            temp[newIndex] = nums[i];
        }
        
        for(int i = 0; i < nums.Length; i++)
        {
            nums[i] = temp[i];
        }
    }
} 