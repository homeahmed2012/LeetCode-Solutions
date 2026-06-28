public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        for(int i = 0; i < numbers.Length - 1; i++)
        {
            var rest = Array.BinarySearch(numbers, target - numbers[i]);
            if(rest == i) 
                if(numbers[i] != numbers[i+1]) rest = -1;
                else rest++;
            if(rest > i) return [i+1, rest+1];
        }
        return [0, 0];
    }
}