using System;

class Program
{
    static void Main()
    {
        string s = "()[]{}";
        Console.WriteLine(IsValid(s));
    }

    static bool IsValid(string s)
    {
        while(s.Contains("()") || s.Contains("[]") || s.Contains("{}"))
        {
            s = s.Replace("()", "");
            s = s.Replace("[]", "");
            s = s.Replace("{}", "");
        }
        return s.Length == 0;
    }
} 