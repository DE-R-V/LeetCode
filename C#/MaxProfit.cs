using System;

public class MaxProfit
{
    /*
        Given an array prices where prices[i] is the price of a stock on day i, find the maximum profit you can achieve.
        You must buy before you sell.

        Examples
        Input:  [7,1,5,3,6,4]
        Output: 5

        Explanation:
        Buy at 1
        Sell at 6
        Profit = 5

        Input:  [7,6,4,3,1]
        Output: 0

        Explanation:
        There is no profitable transaction.
    */

    public static int MaxProfitSolution(int[] prices)
    {
        int possibleBuy = int.MaxValue;
        int possibleSell = int.MinValue;
        int possibleProfit = 0;

        for(int i = 0; i < prices.Length; i++)
        {
            if(possibleBuy > prices[i])
            {
                possibleBuy = prices[i];
                possibleSell = int.MinValue;
            } else {
                if(possibleSell < prices[i] && (prices[i] - possibleBuy >= possibleProfit))
                {
                    possibleSell = prices[i];
                    possibleProfit = possibleSell - possibleBuy;
                }
            }
        }

        return possibleProfit;
    }
}