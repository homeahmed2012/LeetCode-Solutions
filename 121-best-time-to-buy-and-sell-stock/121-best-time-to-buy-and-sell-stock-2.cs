public class Solution {
    public int MaxProfit(int[] prices) {
        int minTillNow = prices[0];
        int maxProfit = 0;
        for (int i = 1; i < prices.Length; i++) {
            if (prices[i] < minTillNow) {
                minTillNow = prices[i];
            } else {
                maxProfit = Math.Max(maxProfit, prices[i] - minTillNow);
            }
        }
        return maxProfit;
    }
}