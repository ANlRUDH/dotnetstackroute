using System;

class Program
{
    static void Main()
    {
        int[] prices = {7,1,5,3,6,4};
        int profit = MaxProfit(prices);
        Console.WriteLine(profit);
    }

    static int MaxProfit(int[] prices)
    {
        int max = 0;
        for(int i = 0; i < prices.Length; i++)
        {
            for(int j = i + 1; j < prices.Length; j++)
            {
                if(prices[j] - prices[i] > max)
                {
                    max = prices[j] - prices[i];
                }
            }
        }
        return max;
    }
} 