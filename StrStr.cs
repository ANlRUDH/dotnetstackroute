using System;

class Program
{
    static void Main()
    {
        string haystack = "hello";
        string needle = "ll";
        Console.WriteLine(StrStr(haystack, needle));
    }

    static int StrStr(string haystack, string needle)
    {
        if(needle == "") return 0;
        
        for(int i = 0; i <= haystack.Length - needle.Length; i++)
        {
            string sub = haystack.Substring(i, needle.Length);
            if(sub == needle)
            {
                return i;
            }
        }
        return -1;
    }
} 