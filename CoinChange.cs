using System;

class Program
{
    static void Main()
    {
        int[] coins = {1,2,5};
        int amount = 11;
        Console.WriteLine(CoinChange(coins, amount));
    }

    static int CoinChange(int[] coins, int amount)
    {
        if(amount == 0) return 0;
        if(amount < 0) return -1;
        
        int min = int.MaxValue;
        foreach(int coin in coins)
        {
            int result = CoinChange(coins, amount - coin);
            if(result != -1)
            {
                min = Math.Min(min, result + 1);
            }
        }
        return min == int.MaxValue ? -1 : min;
    }
} 