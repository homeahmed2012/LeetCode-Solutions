var result = new Solution().Jump([2,3,0,1,4]);
System.Console.WriteLine(result);

public class Solution {
    private Dictionary<int, int> dp = new Dictionary<int, int>();
    public int Jump(int[] nums) {
        return Solve(nums, nums.Length-1);
    }

    private int Solve(int[] nums, int index)
    {
        if(index < 2) return index;
        if(dp.ContainsKey(index)) return dp[index];

        var min = int.MaxValue;
        for(int i = 0; i < index; i++)
        {
            if(nums[i] == 0 || nums[i] < index - i) continue;
            var sol = Solve(nums, i);
            if(sol < min)
            {
                min = sol;
            } 
        }
        return dp[index] = 1 + min;
    }
}