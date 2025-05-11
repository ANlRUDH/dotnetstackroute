using System;

class Program
{
    static void Main()
    {
        string s = "12";
        Console.WriteLine(NumDecodings(s));
    }

    static int NumDecodings(string s)
    {
        if(s.Length == 0) return 1;
        if(s[0] == '0') return 0;
        
        int ways = NumDecodings(s.Substring(1));
        
        if(s.Length >= 2)
        {
            int num = int.Parse(s.Substring(0, 2));
            if(num >= 10 && num <= 26)
            {
                ways += NumDecodings(s.Substring(2));
            }
        }
        
        return ways;
    }
} 