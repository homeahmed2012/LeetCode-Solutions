public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0;
        bool haveStock = false;
        int lastPrice = 0;
        for(int i = 0; i < prices.Length - 1; i++)
        {
            if(prices[i+1] < prices[i] && haveStock)
            {
                // sell
                profit += prices[i] - lastPrice;
                haveStock = false;
            }
            else if(prices[i+1] > prices[i] && !haveStock)
            {
                // buy 
                lastPrice = prices[i];
                haveStock = true;
            }
        }
        if(haveStock) profit += prices[^1] - lastPrice;
        return profit;
    }
}
