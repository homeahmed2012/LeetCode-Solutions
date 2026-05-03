using System.Dynamic;

var result = new Solution().TwoSum([3,3], 6);
System.Console.WriteLine(result[0]);
System.Console.WriteLine(result[1]);

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(target - nums[i]))
                return [dict[target - nums[i]], i];
            
            dict.TryAdd(nums[i], i);
        }
        return [];
    }
}