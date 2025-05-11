using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] nums = {4,1,2,1,2};
        int result = SingleNumber(nums);
        Console.WriteLine(result);
    }

    static int SingleNumber(int[] nums)
    {
        var dict = new Dictionary<int, int>();
        
        foreach(int num in nums)
        {
            if(dict.ContainsKey(num))
            {
                dict[num]++;
            }
            else
            {
                dict[num] = 1;
            }
        }
        
        foreach(var pair in dict)
        {
            if(pair.Value == 1)
            {
                return pair.Key;
            }
        }
        
        return -1;
    }
} 