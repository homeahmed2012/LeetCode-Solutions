var solution = new Solution();
Console.WriteLine(solution.ClimbStairs(4)); // 2
Console.ReadLine();

public class Solution {

    public int ClimbStairs(int n) {
        if (n <= 2) return n;
        int[] dp = new int[n + 1];
        dp[n] = 1;
        dp[n - 1] = 1;
        for (int i = n - 2; i >= 0; i--) {
            dp[i] = dp[i + 1] + dp[i + 2];
        }
        return dp[0];
    }
}