using System;

class Program
{
    static void Main()
    {
        int n = 5;
        Console.WriteLine(ClimbStairs(n));
    }

    static int ClimbStairs(int n)
    {
        if(n == 1) return 1;
        if(n == 2) return 2;
        
        return ClimbStairs(n-1) + ClimbStairs(n-2);
    }
} 