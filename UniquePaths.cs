using System;

class Program
{
    static void Main()
    {
        int m = 3, n = 7;
        Console.WriteLine(UniquePaths(m, n));
    }

    static int UniquePaths(int m, int n)
    {
        if(m == 1 || n == 1) return 1;
        return UniquePaths(m-1, n) + UniquePaths(m, n-1);
    }
} 