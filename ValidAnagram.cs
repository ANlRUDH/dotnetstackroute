using System;

class Program
{
    static void Main()
    {
        string s = "anagram";
        string t = "nagaram";
        Console.WriteLine(IsAnagram(s, t));
    }

    static bool IsAnagram(string s, string t)
    {
        if(s.Length != t.Length) return false;
        
        char[] sArray = s.ToCharArray();
        char[] tArray = t.ToCharArray();
        
        Array.Sort(sArray);
        Array.Sort(tArray);
        
        for(int i = 0; i < sArray.Length; i++)
        {
            if(sArray[i] != tArray[i])
            {
                return false;
            }
        }
        return true;
    }
} 