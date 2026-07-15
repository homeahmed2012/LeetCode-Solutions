using System.Runtime.Intrinsics.Arm;

var result = new Solution().CanJump([0]);
System.Console.WriteLine(result);

public class Solution {
    private Dictionary<int, bool> dp = new Dictionary<int, bool>();
    public bool CanJump(int[] nums) {
        return Solve(nums, nums.Length-1);
    }
    
    private bool Solve(int[] nums, int index)
    {
        if(index == 0) return true;
        if(dp.ContainsKey(index)) return dp[index];

        for(int i = 0; i < index; i++)
        {
            if(nums[i] == 0 || nums[i] < index - i) continue;
            if(Solve(nums, i))
            {
                return dp[index] = true;
            } 
        }
        return dp[index] = false;
    }
}