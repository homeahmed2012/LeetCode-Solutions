public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var sortedNums = (int[]) nums.Clone();
        Array.Sort(sortedNums);

        for (int i = 0; i < sortedNums.Length - 1; i++)
        {
            int res = Array.BinarySearch(sortedNums, i + 1, sortedNums.Length - i - 1, target - sortedNums[i]);
            if (res > 0)
            {
                if(sortedNums[i] == sortedNums[res])
                {
                    int firstIndex = Array.IndexOf(nums, sortedNums[i]);
                    return new int[] { firstIndex, Array.IndexOf(nums, sortedNums[res], firstIndex + 1) };
                }
                return new int[] { Array.IndexOf(nums, sortedNums[i]), Array.IndexOf(nums, sortedNums[res]) };
            }

        }
        return new int[2];
    }
}