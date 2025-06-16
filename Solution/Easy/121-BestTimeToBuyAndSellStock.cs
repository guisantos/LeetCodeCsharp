using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solution.Easy;
public class BestTimeToBuyAndSellStock
{
    public int MaxProfit(int[] prices)
    {
        var left = 0;
        var right = 1;
        var maxProfit = 0;

        while (right < prices.Length)
        {
            if (prices[left] < prices[right])
            {
                var profit = prices[right] - prices[left];
                maxProfit = Math.Max(maxProfit, profit);
            }
            else
            {
                left = right;
            }

            right++;
        }

        return maxProfit;
    }
}
