var res = new Solution().CoinChange([1], 0);
System.Console.WriteLine(res);


public class Solution {
    Dictionary<int, int> dp = new Dictionary<int, int>{{0, 0}};
    
    public int CoinChange(int[] coins, int amount) {
        if(dp.ContainsKey(amount)) return dp[amount];
        dp[amount] = (int)1e6;
        foreach(var coin in coins)
        {
            if(coin > amount) continue;
            var res = CoinChange(coins, amount - coin);
            if(res != -1) dp[amount] = Math.Min(dp[amount], 1 + res);
        }
        if(dp[amount] == (int)1e6) return dp[amount] = -1;
        return dp[amount];
    }
}