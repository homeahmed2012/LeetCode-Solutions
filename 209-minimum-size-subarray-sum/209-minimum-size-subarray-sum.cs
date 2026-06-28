var result = new Solution().MinSubArrayLen(7, [2,3,1,2,4,3]);
System.Console.WriteLine(result);

public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int s, e;
        s = 1; e = nums.Length;
        while(s < e)
        {
            int mid = (s+e)/2;
            var valid = Solve(target, nums, mid);
            if(valid) e = mid;
            else s = mid+1; 
        }
        return Solve(target, nums, e)? e: 0;
    }

    bool Solve(int target, int[] nums, int length)
    {
        int sum = nums[0..length].Sum();
        for(int i = length; i < nums.Length; i++)
        {
            if(sum >= target) return true;
            sum += nums[i];
            sum -= nums[i- length];
        }
        return sum >= target;
    }
}