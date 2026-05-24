public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int s, e;
        s = 0; e = nums.Length;
        while(s < e)
        {
            var mid = (s + e)/2;
            if(nums[mid] == target) return mid;
            if(nums[mid] < target) s = mid+1;
            else e = mid;
        }
        return s;
    }
}