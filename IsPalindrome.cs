using System;

class Program
{
    static void Main()
    {
        string s = "A man, a plan, a canal: Panama";
        Console.WriteLine(IsPalindrome(s));
    }

    static bool IsPalindrome(string s)
    {
        string clean = "";
        foreach(char c in s.ToLower())
        {
            if(char.IsLetterOrDigit(c))
            {
                clean += c;
            }
        }
        
        char[] arr = clean.ToCharArray();
        Array.Reverse(arr);
        string reversed = new string(arr);
        
        return clean == reversed;
    }
} 