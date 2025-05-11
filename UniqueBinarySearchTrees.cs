using System;

class Program
{
    static void Main()
    {
        int n = 3;
        Console.WriteLine(NumTrees(n));
    }

    static int NumTrees(int n)
    {
        if(n <= 1) return 1;
        
        int total = 0;
        for(int i = 1; i <= n; i++)
        {
            total += NumTrees(i-1) * NumTrees(n-i);
        }
        return total;
    }
} 