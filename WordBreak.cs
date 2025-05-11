using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string s = "leetcode";
        var wordDict = new List<string> {"leet", "code"};
        Console.WriteLine(WordBreak(s, wordDict));
    }

    static bool WordBreak(string s, IList<string> wordDict)
    {
        if(s == "") return true;
        
        foreach(string word in wordDict)
        {
            if(s.StartsWith(word))
            {
                if(WordBreak(s.Substring(word.Length), wordDict))
                {
                    return true;
                }
            }
        }
        return false;
    }
} 