using System;

class Program
{
    static void Main()
    {
        int x = 121;
        Console.WriteLine(IsPalindrome(x));
    }

    static bool IsPalindrome(int x)
    {
        if(x < 0) return false;
        
        string num = x.ToString();
        string reversed = "";
        
        for(int i = num.Length - 1; i >= 0; i--)
        {
            reversed += num[i];
        }
        
        return num == reversed;
    }
} 