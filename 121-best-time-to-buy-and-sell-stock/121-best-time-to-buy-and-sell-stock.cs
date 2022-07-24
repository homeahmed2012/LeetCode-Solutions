public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int minPrice = prices[0];
        for(int i = 1; i < prices.Length; i++){
            if(prices[i] > minPrice){
                maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
            }else{
                minPrice = prices[i];
            }
        }
        return maxProfit;
    }
}