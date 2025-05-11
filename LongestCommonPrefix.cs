using System;

class Program
{
    static void Main()
    {
        string[] strs = {"flower","flow","flight"};
        Console.WriteLine(LongestCommonPrefix(strs));
    }

    static string LongestCommonPrefix(string[] strs)
    {
        if(strs.Length == 0) return "";
        
        string first = strs[0];
        string result = "";
        
        for(int i = 0; i < first.Length; i++)
        {
            char c = first[i];
            for(int j = 1; j < strs.Length; j++)
            {
                if(i >= strs[j].Length || strs[j][i] != c)
                {
                    return result;
                }
            }
            result += c;
        }
        return result;
    }
} 