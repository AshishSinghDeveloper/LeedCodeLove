using System;
namespace LeedCodeLove.LeedCodeL1
{
    public static class BestTimeToBuyAndSellStock
    {
        //TC: O(n) | SP: (1)
        public static int MaxProfit(int[] prices)
        {
            int buy = 0;
            int sell = 1;
            int maxProfit = 0;
            while (sell < prices.Length)
            {
                int profit = prices[sell] - prices[buy];
                    if (profit < 0)
                    {
                        buy = sell;
                    }
                    else if (profit > maxProfit)
                    {
                        maxProfit = profit;
                    }
                sell++;
            }
            return maxProfit;
        }
    }
}
