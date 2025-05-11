using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string s = "aab";
        var result = Partition(s);
        foreach(var partition in result)
        {
            Console.WriteLine(string.Join(",", partition));
        }
    }

    static IList<IList<string>> Partition(string s)
    {
        var result = new List<IList<string>>();
        PartitionHelper(s, 0, new List<string>(), result);
        return result;
    }
    
    static void PartitionHelper(string s, int start, List<string> current, List<IList<string>> result)
    {
        if(start == s.Length)
        {
            result.Add(new List<string>(current));
            return;
        }
        
        for(int i = start; i < s.Length; i++)
        {
            string sub = s.Substring(start, i - start + 1);
            if(IsPalindrome(sub))
            {
                current.Add(sub);
                PartitionHelper(s, i + 1, current, result);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
    
    static bool IsPalindrome(string s)
    {
        for(int i = 0; i < s.Length/2; i++)
        {
            if(s[i] != s[s.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
} 