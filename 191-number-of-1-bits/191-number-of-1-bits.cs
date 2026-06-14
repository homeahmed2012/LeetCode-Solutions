var result = new Solution().HammingWeight(128);
System.Console.WriteLine(result);

public class Solution {
    public int HammingWeight(int n) {
        return Convert.ToString(n, 2).Count('1');
    }
}   