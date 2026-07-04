using System;

public class Solution {
    public void Rotate(int[] nums, int k) {
        var n = nums.Length;
        k = k%n;
        Array.Reverse(nums, 0, n-k);
        Array.Reverse(nums, n-k, k);
        for(int i = 0; i < n/2; i++)
        {
            (nums[i], nums[n - 1 - i]) = (nums[n - 1 - i], nums[i]);
        }
    }
}