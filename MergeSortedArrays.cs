using System;

class Program
{
    static void Main()
    {
        int[] nums1 = {1,2,3,0,0,0};
        int[] nums2 = {2,5,6};
        Merge(nums1, 3, nums2, 3);
        Console.WriteLine(string.Join(",", nums1));
    }

    static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int[] temp = new int[m + n];
        int i = 0, j = 0, k = 0;
        
        while(i < m && j < n)
        {
            if(nums1[i] <= nums2[j])
            {
                temp[k] = nums1[i];
                i++;
            }
            else
            {
                temp[k] = nums2[j];
                j++;
            }
            k++;
        }
        
        while(i < m)
        {
            temp[k] = nums1[i];
            i++;
            k++;
        }
        
        while(j < n)
        {
            temp[k] = nums2[j];
            j++;
            k++;
        }
        
        for(int x = 0; x < m + n; x++)
        {
            nums1[x] = temp[x];
        }
    }
} 