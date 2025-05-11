using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] nums1 = {1,2,2,1};
        int[] nums2 = {2,2};
        var result = Intersection(nums1, nums2);
        Console.WriteLine(string.Join(",", result));
    }

    static int[] Intersection(int[] nums1, int[] nums2)
    {
        var set1 = new HashSet<int>();
        var set2 = new HashSet<int>();
        var result = new List<int>();
        
        foreach(int num in nums1)
        {
            set1.Add(num);
        }
        
        foreach(int num in nums2)
        {
            set2.Add(num);
        }
        
        foreach(int num in set1)
        {
            if(set2.Contains(num))
            {
                result.Add(num);
            }
        }
        
        return result.ToArray();
    }
} 