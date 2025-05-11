using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        char[] s = {'h','e','l','l','o'};
        ReverseString(s);
        Console.WriteLine(new string(s));
    }

    static void ReverseString(char[] s)
    {
        var temp = new List<char>();
        for(int i = s.Length - 1; i >= 0; i--)
        {
            temp.Add(s[i]);
        }
        
        for(int i = 0; i < s.Length; i++)
        {
            s[i] = temp[i];
        }
    }
} 