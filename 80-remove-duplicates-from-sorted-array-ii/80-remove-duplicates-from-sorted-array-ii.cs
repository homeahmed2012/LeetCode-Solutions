
var result = new Solution().RemoveDuplicates([0,0,1,1,1,1,2,3,3]);
System.Console.WriteLine(result);

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length < 3) return nums.Length;

        int last = 2;
        for(int i = 2; i < nums.Length; i++)
        {
            if(nums[i] != nums[last - 2])
            {
                nums[last++] = nums[i];
            }
        }
        
        return last;
    }
}