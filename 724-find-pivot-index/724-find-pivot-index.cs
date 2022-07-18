public class Solution {
    public int PivotIndex(int[] nums) {
        if(nums.Length == 1){
          return nums[0];  
        } 
        
        var cumSum = new int[nums.Length];
        cumSum[nums.Length -1 ] = nums[nums.Length-1];
        for(int i = nums.Length - 2; i >= 0 ; i--){
            cumSum[i] = cumSum[i+1] + nums[i];
        }
        
        int index = -1;
        int LSum = 0;
        for(int i = 0; i < nums.Length; i++){
            if((i == nums.Length -1 && LSum == 0) || (i < nums.Length-1 && LSum == cumSum[i+1])){
                index = i;
                break;
            }
            LSum += nums[i];
        }
        return index;
    }
}