var result = new Solution().PlusOne([9]);
System.Console.WriteLine(result.Length);
public class Solution {
    public int[] PlusOne(int[] digits) {
        var rem = 1;
        for(int i = digits.Length -1; i >= 0; i--)
        {
            if(rem == 0) break;
            rem = ++digits[i] / 10;
            digits[i] = digits[i]%10;
        }
        if(rem > 0) digits = [1, ..digits];
        return digits;
    }
}