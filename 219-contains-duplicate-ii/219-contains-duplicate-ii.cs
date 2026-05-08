
var result = new Solution().ContainsNearbyDuplicate([1,2,3,1,2,3], 2);
System.Console.WriteLine(result);

public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        var dict = new HashSet<int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if(dict.Contains(nums[i])) return true;
            dict.Add(nums[i]);
            if(i >= k)
                dict.Remove(nums[i-k]);
        }
        return false;
    }
}