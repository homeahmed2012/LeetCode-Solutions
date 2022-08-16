public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        var costSoFar = new int[cost.Length+5];
        costSoFar[0] = cost[0];
        costSoFar[1] = cost[1];
        for(int i = 2; i <= cost.Length; i++){
            int currentCost = (i == cost.Length)? 0: cost[i];
            costSoFar[i] = currentCost + Math.Min(costSoFar[i-1], costSoFar[i-2]);
        }
        return costSoFar[cost.Length];
    }
}