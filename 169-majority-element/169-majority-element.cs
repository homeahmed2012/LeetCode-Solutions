public class Solution {
    public int MajorityElement(int[] nums) {
        var numbers = new Dictionary<int, int>();
        foreach(var item in nums){
            if(numbers.ContainsKey(item))
            {
                numbers[item] += 1;
            }else{
                numbers[item] = 1;
            }
        }
        int mElement = -1;
        int maxConcurrent = 0;
        foreach(var item in numbers){
            if(item.Value > maxConcurrent){
                mElement = item.Key;
                maxConcurrent = item.Value;
            }
        }
        return mElement;
    }
}