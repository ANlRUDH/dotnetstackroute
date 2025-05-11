using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string s = "()[]{}";
        Console.WriteLine(IsValid(s));
    }

    static bool IsValid(string s)
    {
        var stack = new Stack<char>();
        foreach(char c in s)
        {
            if(c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            else
            {
                if(stack.Count == 0) return false;
                var top = stack.Pop();
                if(c == ')' && top != '(') return false;
                if(c == ']' && top != '[') return false;
                if(c == '}' && top != '{') return false;
            }
        }
        return stack.Count == 0;
    }
} 