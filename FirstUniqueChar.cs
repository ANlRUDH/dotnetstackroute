using System;

class Program
{
    static void Main()
    {
        string s = "leetcode";
        Console.WriteLine(FirstUniqChar(s));
    }

    static int FirstUniqChar(string s)
    {
        for(int i = 0; i < s.Length; i++)
        {
            bool isUnique = true;
            for(int j = 0; j < s.Length; j++)
            {
                if(i != j && s[i] == s[j])
                {
                    isUnique = false;
                    break;
                }
            }
            if(isUnique)
            {
                return i;
            }
        }
        return -1;
    }
} 