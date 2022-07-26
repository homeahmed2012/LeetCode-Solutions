public class Solution {
    public int Search(int[] nums, int target) {
        int s, e, mid;
        
        s = 0;
        e = nums.Length -1;
        while(s <= e){
            mid = (s+e) /2;
            if(nums[mid] == target)
                return mid;
            if(nums[mid] < target)
                s = mid+1;
            else
                e = mid-1;
        }
        return -1;
    }
}