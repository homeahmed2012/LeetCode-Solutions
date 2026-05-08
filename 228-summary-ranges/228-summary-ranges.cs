var result = new Solution().SummaryRanges([-2147483648,0,2,3,4,6,8,9]);
foreach(var item in result)
    System.Console.WriteLine(item); 

public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        var result = new List<string>();
        if(nums.Length < 1) return result;
        int start = nums[0];
        for(int i = 1; i < nums.Length; i++)
        {
            if((long)nums[i] - nums[i-1] > 1)
            {
                result.Add(FormatRange(start, nums[i-1]));
                start = nums[i];
            }
        }
        result.Add(FormatRange(start, nums[^1]));
        return result;
    }

    private string FormatRange(int s, int e)
    {
        if(s == e)
            return s.ToString();
        return s.ToString() + "->" + e.ToString();
    }
}