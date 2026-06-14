var res = new Solution().SingleNumber([4,1,2,1,2]);
System.Console.WriteLine(res);

public class Solution {
    public int SingleNumber(int[] nums) {
        return nums.Aggregate((accumulator, nextItem) => accumulator ^ nextItem);
    }
}