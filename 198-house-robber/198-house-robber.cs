public class Solution {
    public int Rob(int[] nums) {
        if(nums.Length == 1) return nums[0];
        nums[1] = Math.Max(nums[1], nums[0]);
        for(int i = 2; i < nums.Length; i++){
            nums[i] = Math.Max(nums[i] + nums[i - 2], nums[i - 1]);
        }       
        return nums[nums.Length - 1];
    }
}